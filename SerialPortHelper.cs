using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace MKS_SERVO42C_CONTROL
{
    public class SerialPortSetting
    {
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public SerialPortSetting()
        {
            this.PortName = "COM3";
            this.Baud = 38400;
            this.DataBits = 8;
            this.StopBits = StopBits.One;
            this.Parity = Parity.None;
            this.Handshake = Handshake.None;
            this.NewLine = "\r\n";
        }

        /// <summary>
        /// 转换为字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string str = this.NewLine.Aggregate("", (current, ch) => current + ((byte)ch).ToString("X2"));
            return (this.PortName + ","
                + this.Baud.ToString() + ","
                + this.DataBits.ToString() + ","
                + ((int)this.StopBits).ToString() + ","
                + ((int)this.Parity).ToString() + ","
                + ((int)this.Handshake).ToString() + ","
                + str);
        }

        /// <summary>
        /// 串口号
        /// </summary>
        public string PortName { get; set; }

        /// <summary>
        /// 波特率
        /// </summary>
        public int Baud { get; set; }

        /// <summary>
        /// 位数
        /// </summary>
        public int DataBits { get; set; }

        /// <summary>
        /// 握手协议
        /// </summary>
        public Handshake Handshake { get; set; }

        /// <summary>
        /// 新行标识
        /// </summary>
        public string NewLine { get; set; }

        /// <summary>
        /// 奇偶校验位
        /// </summary>
        public Parity Parity { get; set; }

        /// <summary>
        /// 停止位
        /// </summary>
        public StopBits StopBits { get; set; }
    }


    public static class SerialPortHelper
    {
        private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>
        /// open serialport.
        /// </summary>
        public static SerialPort Open(string portName, int baud = 38400, string parity = "None", int dataBits = 8, string stopBits = "One")
        {
            try
            {
                // 创建串口对象
                var comPort = new SerialPort(portName, baud);
                comPort.DataBits = dataBits;
                comPort.Parity = GetParity(parity);
                comPort.StopBits = GetStopBits(stopBits);

                comPort.ReadTimeout = 500;
                comPort.WriteTimeout = 500;
                comPort.Encoding = Encoding.UTF8;

                // 打开串口
                comPort.Open();
                return comPort;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                throw;
            }
        }


        public static SerialPort Open(SerialPortSetting portSetting)
        {
            try
            {
                // 创建串口对象
                var comPort = new SerialPort(portSetting.PortName, portSetting.Baud);
                comPort.DataBits = portSetting.DataBits;
                comPort.Parity = portSetting.Parity;
                comPort.StopBits = portSetting.StopBits;
                comPort.Handshake = portSetting.Handshake;
                comPort.NewLine = portSetting.NewLine;

                comPort.ReadTimeout = 500;
                comPort.WriteTimeout = 500;
                comPort.Encoding = Encoding.UTF8;

                // 打开串口
                comPort.Open();
                return comPort;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                throw;
            }
        }


        /// <summary>
        /// Receive serialport data, Data validation.
        /// </summary>
        public static byte[] Received(SerialPort comPort, int readIntervalTime = 10)
        {
            try
            {
                if (comPort.IsOpen)
                {
                    // 等待串口数据完整接收
                    int len = 0;
                    do
                    {
                        // 查询串口中目前保存了多少数据
                        len = comPort.BytesToRead;
                        Thread.Sleep(readIntervalTime);

                    } while ((len < comPort.BytesToRead) && (comPort.BytesToRead < 4800));

                    // 读取数据
                    byte[] buffer = new byte[len];
                    comPort.Read(buffer, 0, len);

                    // print result to log
                    string cmdResult = BytesToHexStr(buffer);
                    _logger.Debug("Received: " + cmdResult + Environment.NewLine);

                    return buffer;

                }
                else
                {
                    throw new IOException("串口没有打开！");
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                throw;
            }
        }


        /// <summary>
        /// sum check
        /// </summary>
        /// <param name="data">bytes data </param>
        /// <param name="index">start index </param>
        /// <param name="len"> bytes length </param>
        /// <returns></returns>
        public static byte SumCheck(byte[] data, int index, int len)
        {
            uint num = 0;
            for (int i = index; i < (index + len); i++)
            {
                num += data[i];
            }
            return (byte)num;
        }


        /// <summary>
        /// xor check
        /// </summary>
        /// <param name="data">bytes data </param>
        /// <param name="index">start index </param>
        /// <param name="len">bytes length </param>
        /// <returns></returns>
        public static byte XorCheck(byte[] data, int index, int len)
        {
            byte num = 0;
            for (int i = index; i < (index + len); i++)
            {
                num ^= data[i];
            }
            return num;
        }


        /// <summary>
        /// Serial port send data, automatically add tCHK
        /// </summary>
        public static string SendCommand(SerialPort comPort, byte[] command, int writeIntervalTime = 2)
        {
            try
            {
                if (comPort.IsOpen)
                {
                    if (command != null)
                    {
                        comPort.DiscardInBuffer();

                        // append TCHK
                        var cmd = AppendTCHK(command);

                        // print command string to log
                        var commandStr = BytesToHexStr(cmd);
                        _logger.Debug($"send command: {commandStr}");

                        //send data to serial port
                        comPort.Write(cmd, 0, cmd.Length);
                        Thread.Sleep(writeIntervalTime);

                        return commandStr;
                    }
                    else
                    {
                        _logger.Debug($"send data is null!");
                        return null;
                    }
                }
                else
                {
                    // 提示端口没打开                   
                    throw new IOException("Serialport is not open！");
                }
            }
            catch (Exception ex)
            {
                // 提示端口没打开
                _logger.Error(ex);
                throw;
            }
        }


        private static byte[] AppendTCHK(byte[] command)
        {
            var len = command.Length;
            var cmd = new byte[len + 1];
            var tCHK = SumCheck(command, 0, command.Length);
            command.CopyTo(cmd, 0);
            cmd[len] = tCHK;
            return cmd;
        }


        /// <summary>
        /// Convert byte array to hexadecimal string
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string BytesToHexStr(byte[] bytes)
        {
            if (bytes == null || bytes.Length < 1)
            {
                return null;
            }

            StringBuilder str = new StringBuilder();
            foreach (byte Byte in bytes)
            {
                str.AppendFormat("{0:X2} ", Byte);
            }
            return str.ToString();
        }


        /// <summary>
        /// Convert the hexadecimal string to a byte array
        /// </summary>
        /// <param name="hexStr"></param>
        /// <returns></returns>
        public static byte[] HexStrToBytes(string hexStr)
        {
            //以 ' ' 分割字符串，并去掉空字符
            string[] chars = hexStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            byte[] returnBytes = new byte[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                returnBytes[i] = Convert.ToByte(chars[i], 16);
            }
            return returnBytes;
        }


        /// <summary>
        /// Gets the parity by string.
        /// </summary>
        /// <param name="parityVal">The string parity value. </param>
        /// <returns>The <see cref="Parity"/>.</returns>
        public static Parity GetParity(string parityVal)
        {
            Parity patityBit;
            switch (parityVal?.ToLower())
            {
                case "0":
                case "n":
                case "none":
                    patityBit = Parity.None;
                    break;
                case "1":
                case "o":
                case "odd":
                    patityBit = Parity.Odd;
                    break;
                case "2":
                case "e":
                case "even":
                    patityBit = Parity.Even;
                    break;
                case "3":
                case "m":
                case "mark":
                    patityBit = Parity.Mark;
                    break;
                case "4":
                case "s":
                case "space":
                    patityBit = Parity.Space;
                    break;
                default:
                    patityBit = Parity.None;
                    break;
            }
            return patityBit;
        }


        /// <summary>
        /// Gets the stopbits by string.
        /// </summary>
        /// <param name="stopBitsVal">The string stop bits. </param>
        /// <returns>The <see cref="StopBits"/>.</returns>
        public static StopBits GetStopBits(string stopBitsVal)
        {
            StopBits stopBit;
            switch (stopBitsVal?.ToLower())
            {
                case "0":
                case "n":
                case "none":
                    stopBit = StopBits.None;
                    break;
                case "1":
                case "o":
                case "one":
                    stopBit = StopBits.One;
                    break;
                case "2":
                case "t":
                case "two":
                    stopBit = StopBits.Two;
                    break;
                case "3":
                case "1.5":
                case "f":
                case "of":
                case "opf":
                case "onepointfive":
                    stopBit = StopBits.OnePointFive;
                    break;
                default:
                    stopBit = StopBits.One;
                    break;
            }

            return stopBit;
        }


        /// <summary>
        /// Gets the handshake by string.
        /// </summary>
        /// <param name="shake">The string handshake value. </param>
        /// <returns>Handshake.</returns>
        public static Handshake GetHandshake(string shake)
        {
            Handshake handShake;
            switch (shake?.ToLower())
            {
                case "0":
                case "n":
                case "none":
                    handShake = Handshake.None;
                    break;
                case "1":
                case "x":
                case "xoxo":
                case "xonxoff":
                case "software":
                    handShake = Handshake.XOnXOff;
                    break;
                case "2":
                case "r":
                case "rts":
                case "requesttosend":
                case "hardware":
                    handShake = Handshake.RequestToSend;
                    break;
                case "3":
                case "rx":
                case "rtsxx":
                case "requesttosendxonxoff":
                case "both":
                    handShake = Handshake.RequestToSendXOnXOff;
                    break;
                default:
                    handShake = Handshake.None;
                    break;
            }
            return handShake;
        }


        //Motor reversal mask
        private static byte Reversal = 0x80;

        /// <summary>
        /// Convert velocity string value to bytes
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="forward"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static byte Speed(string speedStr, bool forward = true)
        {
            return Speed(Convert.ToByte(speedStr), forward);
        }


        /// <summary>
        /// Motor speed conversion, the first digit is the direction, 
        /// and the last 6 digits are the speed value.
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="forward"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static byte Speed(byte speed, bool forward = true)
        {
            if (speed > 127 || speed < 0)
            {
                throw new ArgumentOutOfRangeException("speed");
            }

            byte tmpSpeed = speed;
            if (!forward)
            {
                tmpSpeed = Convert.ToByte(speed | Reversal);
            }
            return tmpSpeed;
        }


        public static byte ReverseSpeed(byte speed)
        {
            if (speed > 127 || speed < 0)
            {
                throw new ArgumentOutOfRangeException("speed");
            }

            return Convert.ToByte(speed | Reversal);
        }


        /// <summary>
        /// high-low reversal, convert UInt32 Hex string to bytes
        /// </summary>
        /// <param name="hexStr"></param>
        /// <returns></returns>
        public static byte[] Uint32ToBytes(string hexStr)
        {
            return Uint32ToBytes(Convert.ToUInt32(hexStr));
        }


        /// <summary>
        /// high-low reversal, convert UInt32 to bytes
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Uint32ToBytes(UInt32 data)
        {
            var bytes = BitConverter.GetBytes(data);
            Array.Reverse(bytes);
            return bytes;
        }


        /// <summary>
        /// high-low reversal, convert UInt16 Hex string to bytes
        /// </summary>
        /// <param name="hexStr"></param>
        /// <returns></returns>
        public static byte[] Uint16ToBytes(string hexStr)
        {
            return Uint16ToBytes(Convert.ToUInt16(hexStr));
        }


        /// <summary>
        /// high-low reversal, convert UInt16 to bytes
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Uint16ToBytes(UInt16 data)
        {
            var bytes = BitConverter.GetBytes(data);
            Array.Reverse(bytes);
            return bytes;
        }


        /// <summary>
        /// high-low reversal, convert bytes to UInt16
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static UInt16 BytesToUInt16(byte[] bytes)
        {
            Array.Reverse(bytes);
            return BitConverter.ToUInt16(bytes, 0);
        }

        /// <summary>
        /// high-low reversal, convert bytes to UInt32
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static UInt32 BytesToUInt32(byte[] bytes)
        {
            Array.Reverse(bytes);
            return BitConverter.ToUInt32(bytes, 0);
        }


        /// <summary>
        /// Assemble a two-byte serial command
        /// </summary>
        /// <param name="address"></param>
        /// <param name="motorCmd"></param>
        /// <returns></returns>
        public static byte[] BuildTwoBytesCmd(byte address, byte motorCmd)
        {
            var command = new byte[2] { address, motorCmd };
            return command;
        }


        /// <summary>
        /// Assemble a three-byte serial port command
        /// </summary>
        /// <param name="address"></param>
        /// <param name="motorCmd"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static byte[] BuildThreeBytesCmd(byte address, byte motorCmd, byte param)
        {
            var command = new byte[3] { address, motorCmd, param };
            return command;
        }


        /// <summary>
        /// Assemble a four-byte serial port command
        /// </summary>
        /// <param name="address"></param>
        /// <param name="motorCmd"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static byte[] BuildFourBytesCmd(byte address, byte motorCmd, UInt16 param)
        {
            var command = new byte[4] { address, motorCmd, 0, 0 };

            Uint16ToBytes(param).CopyTo(command, 2);
            return command;
        }


        /// <summary>
        /// Assemble a seven-byte serial port command
        /// </summary>
        /// <param name="address"></param>
        /// <param name="motorCmd"></param>
        /// <param name="speed"></param>
        /// <param name="pulse"></param>
        /// <returns></returns>
        public static byte[] BuildSevenBytesCmd(byte address, byte motorCmd, byte speed, UInt32 pulse)
        {
            var command = new byte[7];
            command[0] = address;
            command[1] = motorCmd;
            command[2] = speed;
            Uint32ToBytes(pulse).CopyTo(command, 3);
            return command;
        }

    }
}
