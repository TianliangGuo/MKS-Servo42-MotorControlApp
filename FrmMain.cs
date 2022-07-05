using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;


namespace MKS_SERVO42C_CONTROL
{
    public partial class FrmMain : Form
    {
        SerialPort mySerialPort;

        // electric current
        readonly string[] I_Ma = { "0", "200", "400", "600", "800", "1000", "1200", "1400", "1600", "1800", "2000", "2200", "2400", "2600", "2800", "3000" };

        // baud rate
        readonly string[] UartBaud = { "9600", "19200", "25000", "38400", "57600", "115200" };

        // motor address
        readonly string[] UartAddr = { "0xE0", "0xE1", "0xE2", "0xE3", "0xE4", "0xE5", "0xE6", "0xE7", "0xE8", "0xE9" };


        public FrmMain()
        {
            InitializeComponent();

            ButtonDisable();

            Control.CheckForIllegalCrossThreadCalls = false;
        }


        private void ButtonDisable()
        {
            grpReadParameters.Enabled = false;
            grpSysSettings.Enabled = false;
            grpPID.Enabled = false;
            grpSetZeroParameters.Enabled = false;
            grpMotorContorl.Enabled = false;
            btnRestore.Enabled = false;
            lblRestore.Enabled = false;
            btnSwing.Enabled = false;
            btnStopSWing.Enabled = false;
        }


        private void ButtonEnable()
        {
            grpReadParameters.Enabled = true;
            grpSysSettings.Enabled = true;
            grpPID.Enabled = true;
            grpSetZeroParameters.Enabled = true;
            grpMotorContorl.Enabled = true;
            btnRestore.Enabled = true;
            lblRestore.Enabled = true;
            btnSwing.Enabled = true;
            btnStopSWing.Enabled = true;
        }


        private void btnOpenCom_Click(object sender, EventArgs e)
        {
            // If the serial port is not closed, close it immediately
            if (mySerialPort != null)
            {
                mySerialPort.Close();
                mySerialPort = null;
            }

            try
            {
                // open serialport
                mySerialPort = SerialPortHelper.Open(cmbComName.Text, Convert.ToInt32(cmbBaud.Text));

                // serialport data receive event
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(PortReceivedData);
            }
            catch
            {
                MessageBox.Show(Text2_Connect, Text1_window);
            }
            finally
            {
                ButtonEnable();

                cmbComName.Enabled = false;
                cmbBaud.Enabled = false;
                btnScanCom.Enabled = false;
                btnOpenCom.Enabled = false;
                btnCloseCom.Enabled = true;
            }
        }


        private void btnCloseCom_Click(object sender, EventArgs e)
        {
            try
            {
                if (mySerialPort != null)
                {
                    mySerialPort.Close();

                    txtEncodeVal.Text = String.Empty;
                    txtTotalPulse.Text = String.Empty;
                    txtMotorPosition.Text = String.Empty;
                    txtAngleError.Text = String.Empty;
                    txtBoardStatus.Text = String.Empty;
                    txtLockedFlag.Text = String.Empty;
                }
            }
            catch
            {
                MessageBox.Show(Text1_Connect, Text1_window);
            }
            finally
            {
                ButtonDisable();

                cmbComName.Enabled = true;
                cmbBaud.Enabled = true;
                btnScanCom.Enabled = true;
                btnOpenCom.Enabled = true;
                btnCloseCom.Enabled = false;
            }
        }


        private void SendCmdToSerialPort(byte[] data)
        {
            if (mySerialPort != null && mySerialPort.IsOpen)
            {
                if (data != null && data.Length > 1)
                {
                    var commandStr = SerialPortHelper.SendCommand(mySerialPort, data);
                    if (!string.IsNullOrEmpty(commandStr))
                    {
                        // print command                
                        PrintCmdStr("Send: " + commandStr + Environment.NewLine);
                    }
                }
                else
                {
                    MessageBox.Show(Text1_SerialError, Text2_window);
                }
            }
            else
            {
                MessageBox.Show(Text2_Connect, Text1_window);
            }

        }


        private void PortReceivedData(object sender, SerialDataReceivedEventArgs e)
        {
            if (mySerialPort != null && mySerialPort.IsOpen)
            {
                try
                {
                    var cmdReturn = SerialPortHelper.Received(mySerialPort);
                    if (cmdReturn != null)
                    {
                        string cmdReturnStr = SerialPortHelper.BytesToHexStr(cmdReturn);
                        PrintCmdStr("Received: " + cmdReturnStr + Environment.NewLine);

                        CmdReturnDisplay(cmdReturn);
                    }
                }
                catch (Exception ex)
                {

                    if (mySerialPort != null)
                    {
                        mySerialPort.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show(Text2_Connect, Text1_window);
            }
        }


        private void PrintCmdStr(string value)
        {
            Action act = () => { rtxCmdDisplay.AppendText(value); };

            if (rtxCmdDisplay.InvokeRequired)
            {
                rtxCmdDisplay.Invoke(act);
            }
            else
            {
                act();
            }
        }


        private MotorCmdFlag cmdFlag = MotorCmdFlag.None;


        private void CmdReturnDisplay(byte[] serialPortResult)
        {
            // prefix
            var hexPrefix = "0x";

            switch (cmdFlag)
            {
                case MotorCmdFlag.ReadEncoderVal: // read encode value
                    var encodeValBytes = new byte[2];
                    Array.Copy(serialPortResult, 1, encodeValBytes, 0, 2);
                    string encodeStr;
                    if (rdoHex.Checked)
                    {
                        encodeStr = hexPrefix + SerialPortHelper.BytesToHexStr(encodeValBytes).Replace(" ", "");
                    }
                    else
                    {
                        encodeStr = SerialPortHelper.BytesToUInt16(encodeValBytes).ToString();
                    }
                    SetTextBox(txtEncodeVal, encodeStr);
                    break;

                case MotorCmdFlag.ReadTotalPulse: // 读取输入累计脉冲数
                    var totlePulseBytes = new byte[4];
                    Array.Copy(serialPortResult, 1, totlePulseBytes, 0, 4);
                    string totlePluseStr;
                    if (rdoHex.Checked)
                    {
                        totlePluseStr = hexPrefix + SerialPortHelper.BytesToHexStr(totlePulseBytes).Replace(" ", "");
                    }
                    else
                    {
                        totlePluseStr = SerialPortHelper.BytesToUInt32(totlePulseBytes).ToString();
                    }
                    SetTextBox(txtTotalPulse, totlePluseStr);
                    break;

                case MotorCmdFlag.ReadPosition: // 读取闭环电机的实时位置
                    var positionBytes = new byte[4];
                    Array.Copy(serialPortResult, 1, positionBytes, 0, 4);
                    string positionStr;
                    if (rdoHex.Checked)
                    {
                        positionStr = hexPrefix + SerialPortHelper.BytesToHexStr(positionBytes).Replace(" ", "");
                    }
                    else
                    {
                        positionStr = SerialPortHelper.BytesToUInt32(positionBytes).ToString();
                    }
                    SetTextBox(txtMotorPosition, positionStr);
                    break;

                case MotorCmdFlag.ReadAngleError: // 读取位置角度误差
                    var angleErrorBytes = new byte[2] { serialPortResult[1], serialPortResult[2] };
                    Array.Copy(serialPortResult, 1, angleErrorBytes, 0, 2);
                    string angleErrorStr;
                    if (rdoHex.Checked)
                    {
                        angleErrorStr = hexPrefix + SerialPortHelper.BytesToHexStr(angleErrorBytes).Replace(" ", "");
                    }
                    else
                    {
                        angleErrorStr = SerialPortHelper.BytesToUInt16(angleErrorBytes).ToString();
                    }
                    SetTextBox(txtAngleError, angleErrorStr);
                    break;

                case MotorCmdFlag.ReadBoardFlag: // 读取驱动板的使能状态
                    var boardFlay = serialPortResult[1];
                    SetTextBox(txtBoardStatus, BoradFlagStr(boardFlay));
                    break;

                case MotorCmdFlag.ReadBlockFlag: //读取堵转标志位
                    var blockFlag = serialPortResult[1];
                    SetTextBox(txtLockedFlag, BlockFlagStr(blockFlag));
                    break;

                default:
                    break;
            }

            /************* 非常重要 *************/
            // switch 后立即复位全局的 MotorCmdFlag
            cmdFlag = MotorCmdFlag.None;
        }


        private void SetTextBox(TextBox txt, string value)
        {
            Action act = () => { txt.Text = value; };

            if (txt.InvokeRequired)
            {
                txt.Invoke(act);
            }
            else
            {
                act();
            }
        }


        private string BoradFlagStr(byte flag)
        {
            string flagStr;
            if (flag == 1)
            {
                flagStr = "Enable";
            }
            else if (flag == 2)
            {
                flagStr = "Disable";
            }
            else
            {
                flagStr = "Error";
            }

            return flagStr;
        }


        private string BlockFlagStr(byte flag)
        {
            string flagString = "";
            if (flag == 1)
            {
                flagString = "Block";
            }
            else if (flag == 2)
            {
                flagString = "Unblock";
            }
            else
            {
                flagString = "Error";
            }

            return flagString;
        }


        private void btnScanCom_Click(object sender, EventArgs e)
        {
            //扫描并讲课用串口添加至下拉列表
            SearchAndAddSerialPortToComboBox();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 添加本机串口
            SearchAndAddSerialPortToComboBox();

            // 使用中文菜单
            SetChineseUI();

            // 添加速度选择列表
            AddComboBoxSpeed();

            // 添加 MStep 选择列表
            AddMStep();

            // 波特率选项添加
            cmbBaud.Items.Clear();
            cmbBaud.Items.AddRange(UartBaud);

            // 波特率选项添加
            cmbSetUartBaud.Items.Clear();
            cmbSetUartBaud.Items.AddRange(UartBaud);

            // 电机地址选项添加
            cmbMotorAddr.Items.Clear();
            cmbMotorAddr.Items.AddRange(UartAddr);

            // 电机地址选项添加
            cmbSetUartAddr.Items.Clear();
            cmbSetUartAddr.Items.AddRange(UartAddr);

            // 电流选项添加
            cmbSetMa.Items.Clear();
            cmbSetMa.Items.AddRange(I_Ma);

            // 默认波特率 38400
            cmbBaud.SelectedIndex = 3;

            // 默认电机地址
            cmbMotorAddr.SelectedIndex = 0;


            // 默认电机类型 1.8°
            cmbSetMotType.SelectedIndex = 1;

            // 默认工作模式 串口控制
            cmbSetCtrMode.SelectedIndex = 2;

            cmbSetMa.SelectedIndex = 5;

            // 默认的 MStep  16
            cmbSetMStep.SelectedIndex = 15;

            // 设置 En
            cmbSetEn.SelectedIndex = 0;

            // 默认的电机旋转方向 CW
            cmbSetDir.SelectedIndex = 0;

            // 默认自动息屏关闭
            cmbSetAutoSDD.SelectedIndex = 0;

            // 堵转保护
            cmbSetProtect.SelectedIndex = 1;

            // 插补算法
            cmbSetMPlyer.SelectedIndex = 1;

            //
            cmbSetUartBaud.SelectedIndex = 3;

            //
            cmbSetUartAddr.SelectedIndex = 0;

            // 回零速度
            cmbZeroSpeed.SelectedIndex = 0;

            // 脉冲数
            txtPulseCounter.Text = "3600";

            // 默认的 MStep  16
            cmbMStep2.SelectedIndex = 17;

            btnOpenCom.Enabled = true;
            btnCloseCom.Enabled = false;

            //
            cmbSpeedGear.SelectedIndex = 9;
            cmbSpeedGear2.SelectedIndex = 9;


            btnPowerOnRun.Enabled = false;
            btnPowerOnStop.Enabled = false;
        }


        private void SearchAndAddSerialPortToComboBox()
        {
            //清空ComboBox内容
            cmbComName.Items.Clear();
            var ports = SerialPort.GetPortNames();
            cmbComName.Items.AddRange(ports);

            if (cmbComName.Items.Count > 0)
            {
                cmbComName.SelectedIndex = 0;
            }
        }


        private void AddComboBoxSpeed()
        {
            object[] data = new object[127];
            for (int i = 0; i < 127; i++)
            {
                data[i] = i + 1;
            }
            cmbSpeedGear.Items.AddRange(data);
            cmbSpeedGear2.Items.AddRange(data);
        }


        private void AddMStep()
        {
            object[] data = new object[256];
            for (int i = 0; i < 256; i++)
            {
                data[i] = i + 1;
            }
            cmbSetMStep.Items.AddRange(data);
            cmbMStep2.Items.AddRange(data);
        }


        private void ChineseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SetChineseUI();
        }


        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetEnglishUI();
        }


        private void SetChineseUI()
        {
            #region 中文界面

            grpLinkSetings.Text = "连接设置";
            grpReadParameters.Text = "读取参数";
            grpPID.Text = "设置PID/加速度/扭矩参数";
            grpMotorContorl.Text = "电机控制";
            grpMotorStart.Text = "控制电机正反转";
            grpMotorPosition.Text = "控制电机位置";
            grpSysSettings.Text = "设置系统参数";
            grpPIDSettings.Text = "PID参数";
            grpAcceleration.Text = "加速度参数";
            grpMaxT.Text = "最大扭矩";
            grpSetZeroParameters.Text = "设置自动回零";


            lblMStep.Text = "细分设置";
            lblComName.Text = "串  口";
            lblBaud.Text = "波特率";
            lblSpeedGear.Text = "速度档位";
            lblSpeedGear2.Text = "速度档位";
            lblPulseCounter.Text = "脉冲数";
            lblPulseCounterAlert.Text = "提示：在16细分时，3200脉冲 = 360°";
            lblSetEn.Text = "使能设置";
            lblMotorAddr.Text = "通讯地址";
            lblSpeedGearAlert.Text = "提示：速度档位范围0-127";
            lblMotorType.Text = "电机类型";
            lblCtrMode.Text = "工作模式";
            lblMa.Text = "电流值(mA)";
            lblSetDir.Text = "电机方向";
            lblSetAutoSDD.Text = "自动息屏";
            lblSetProtect.Text = "堵转保护";
            lblSetMPlyer.Text = "细分插补";
            lblSetUartBaud.Text = "串口波特率";
            lblSetUartAddr.Text = "通讯地址";
            label20.Text = "注意:此处的参数设置不当，可能会损坏主板，请谨慎设置，如果不确定，请不要修改。";
            lblSetKP.Text = "位置Kp";
            lblSetKI.Text = "位置Ki";
            lblSetKD.Text = "位置Kd";
            label24.Text = "加速度";
            lblSetMaxT.Text = "扭矩";
            lblZeroMode.Text = "回零模式";
            lblSetZeroPosition.Text = "请手动将电机轴转至需要设置的零点位置，然后点击确认。";
            lblZeroSpeed.Text = "回零速度";
            lblZeroDir.Text = "回零方向";
            lblRestore.Text = "注意：点击“恢复出厂设置”后需要重新上电。";
            lblMStepAlert.Text = "提示：细分范围 1-256";
            lblMStep2.Text = "细分设置";

            btnOpenCom.Text = "打开串口";
            btnSetMStep.Text = "确认";
            btnEncoderVal.Text = "编码器值";
            btnTotalPulseCounter.Text = "输入累计脉冲数";
            btnMotorPosition.Text = "电机位置";
            btnAngleError.Text = "位置角度误差";
            btnBoardStatus.Text = "驱动板使能状态";
            btnLockedFlag.Text = "堵转标志位";
            btnDisenableBorad.Text = "关闭驱动板";
            btnEnableBorad.Text = "使能驱动板";
            btnStart.Text = "开始";
            btnStop.Text = "停止";
            btnPowerOnRun.Text = "开启上电自动运行";
            btnPowerOnStop.Text = "关闭上电自动运行";
            btnStart2.Text = "开始";
            btnStop2.Text = "停止";
            btnScanCom.Text = "扫描";
            btnCloseCom.Text = "关闭串口";
            btnCal.Text = "校准";
            btnSetMotType.Text = "确认";
            btnSetCtrMode.Text = "确认";
            btnSetMa.Text = "确认";
            btnSetEn.Text = "确认";
            btnSetDir.Text = "确认";
            btnSetAutoSDD.Text = "确认";
            btnSetProtect.Text = "确认";
            btnSetMPlyer.Text = "确认";
            btnSetUartBaud.Text = "确认";
            btnSetUartAddr.Text = "确认";
            btnSetKP.Text = "确认";
            btnSetKI.Text = "确认";
            btnSetKD.Text = "确认";
            btnSetACC.Text = "确认";
            btnSetMaxT.Text = "确认";
            btnEnableZeroMode.Text = "开启";
            btnDisableZeroMode.Text = "关闭";
            btnSetZeroPos.Text = "确认";
            btnSetZeroSpeed.Text = "确认";
            btnSetZeroDir.Text = "确认";
            buttonGotoZeroPos.Text = "返回零点";
            btnRestore.Text = "恢复出厂配置";
            btnMStep2.Text = "确认";
            btnClearDisplay.Text = "清除";

            rdoForward.Text = "正转(CW)";
            rdoReversal.Text = "反转(CCW)";
            rdoForward2.Text = "正转(CW)";
            rdoReversal2.Text = "反转(CCW)";
            rdoHex.Text = "十六进制";
            rdoDec.Text = "十进制";
            rdoDirMode.Text = "方向模式";
            rdoNearMode.Text = "就近模式";
            rdoZeroReversal.Text = "反转(CCW)";
            rdoZeroForward.Text = "正转(CW)";

            ToolStripMenuItemLanguage.Text = "语言";

            Text1_Connect = ConnectText1[0];
            Text2_Connect = ConnectText2[0];
            Text1_window = WindowText1[0];
            Text2_window = WindowText2[0];
            Text1_SerialError = SerialErrorText1[0];
            Text1_Direction = Direction_Text[0];
            Text1_Speedgear = Speedgear_Text1[0];
            Text1_SubdivisionError = SubdivisionError_Text1[0];
            Text1_PulseError = PulseError_Text1[0];
            Text1_DataError = DataError_Text1[0];

            #endregion
        }


        private void SetEnglishUI()
        {
            #region English UI

            grpLinkSetings.Text = "Setting";
            grpReadParameters.Text = "Read parameters";
            grpPID.Text = "Set PID/ACC/Torque parameters";
            grpMotorContorl.Text = "Motor control";
            grpMotorStart.Text = "Control motor rotation";
            grpMotorPosition.Text = "Control motor position";
            grpSysSettings.Text = "Set system parameters";
            grpPIDSettings.Text = "PID parameters";
            grpAcceleration.Text = "Acceleration parameter";
            grpMaxT.Text = "Maximum torque";
            grpSetZeroParameters.Text = "Set auto zero";


            lblMStep.Text = "MStep";
            lblComName.Text = "Port";
            lblBaud.Text = "Baudrate";
            lblSpeedGear.Text = "Speed gear";
            lblSpeedGear2.Text = "Speed gear";
            lblPulseCounter.Text = "Pulses number";
            lblPulseCounterAlert.Text = "Tip: At 16 subdivision, 3200 pulses = 360°";
            lblSetEn.Text = "En";
            lblMotorAddr.Text = "Address";
            lblSpeedGearAlert.Text = "Tip: Speed gear range 0-127";
            lblMotorType.Text = "MotType";
            lblCtrMode.Text = "CtrMode";
            lblMa.Text = "Ma";
            lblSetDir.Text = "Dir";
            lblSetAutoSDD.Text = "AutoSDD";
            lblSetProtect.Text = "Protect";
            lblSetMPlyer.Text = "MPlyer";
            lblSetUartBaud.Text = "UartBaud";
            lblSetUartAddr.Text = "UartAddr";
            label20.Text = "Note: Improper setting of parameters here may damage the motherboard,please set it carefully and don't modify it if you are not sure.";
            lblSetKP.Text = "Kp";
            lblSetKI.Text = "Ki";
            lblSetKD.Text = "Kd";
            label24.Text = "ACC";
            lblSetMaxT.Text = "Torque";
            lblZeroMode.Text = "0_Mode";
            lblSetZeroPosition.Text = "Please manually turn the motor shaft to the zero position to be set, and then click OK.";
            lblZeroSpeed.Text = "0_Speed";
            lblZeroDir.Text = "0_Dir";
            lblRestore.Text = "Note: After clicking 'Factory reset', you need to power on again.";
            lblMStepAlert.Text = "Tip: MStep range 0-127";
            lblMStep2.Text = "MStep";


            btnOpenCom.Text = "Connect";
            btnSetMStep.Text = "Verify";
            btnEncoderVal.Text = "Encoder value";
            btnTotalPulseCounter.Text = "Cumulative pulse number";
            btnMotorPosition.Text = "Motor position";
            btnAngleError.Text = "Position angle error";
            btnBoardStatus.Text = "Driver board enable state";
            btnLockedFlag.Text = "Blocked";
            btnDisenableBorad.Text = "Disable enable";
            btnEnableBorad.Text = "Enable driver board";
            btnStart.Text = "Start";
            btnStop.Text = "Stop";
            btnPowerOnRun.Text = "Turn on automatic operation after power-on";
            btnPowerOnStop.Text = "Turn off automatic operation after power-on";
            btnStart2.Text = "Start";
            btnStop2.Text = "Stop";
            btnScanCom.Text = "Scan";
            btnCloseCom.Text = "Disconnect";
            btnCal.Text = "Calibrate";
            btnSetMotType.Text = "Verify";
            btnSetCtrMode.Text = "Verify";
            btnSetMa.Text = "Verify";
            btnSetEn.Text = "Verify";
            btnSetDir.Text = "Verify";
            btnSetAutoSDD.Text = "Verify";
            btnSetProtect.Text = "Verify";
            btnSetMPlyer.Text = "Verify";
            btnSetUartBaud.Text = "Verify";
            btnSetUartAddr.Text = "Verify";
            btnSetKP.Text = "Verify";
            btnSetKI.Text = "Verify";
            btnSetKD.Text = "Verify";
            btnSetACC.Text = "Verify";
            btnSetMaxT.Text = "Verify";
            btnEnableZeroMode.Text = "Enable";
            btnDisableZeroMode.Text = "Disable";
            btnSetZeroPos.Text = "OK";
            btnSetZeroSpeed.Text = "Verify";
            btnSetZeroDir.Text = "Verify";
            buttonGotoZeroPos.Text = "Return to zero";
            btnRestore.Text = "Factory reset";
            btnMStep2.Text = "Verify";
            btnClearDisplay.Text = "Clear";

            rdoForward.Text = "Forward";
            rdoReversal.Text = "Reverse";
            rdoForward2.Text = "Forward";
            rdoReversal2.Text = "Reverse";
            rdoHex.Text = "Hex";
            rdoDec.Text = "Decimal";
            rdoDirMode.Text = "DirMode";
            rdoNearMode.Text = "NearMode";
            rdoZeroReversal.Text = "Reverse";
            rdoZeroForward.Text = "Forward";


            ToolStripMenuItemLanguage.Text = "Language";

            Text1_Connect = ConnectText1[1];
            Text1_window = WindowText1[1];
            Text2_window = WindowText2[1];
            Text2_Connect = ConnectText2[1];
            Text1_SerialError = SerialErrorText1[1];
            Text1_Direction = Direction_Text[1];
            Text1_Speedgear = Speedgear_Text1[1];
            Text1_SubdivisionError = SubdivisionError_Text1[1];
            Text1_PulseError = PulseError_Text1[1];
            Text1_DataError = DataError_Text1[1];

            #endregion
        }

        #region 语言切换               

        string[] ConnectText1 = { "断开失败，请再次尝试", "Disconnect failed, please try again" };
        string Text1_Connect;

        string[] WindowText1 = { "错误", "error" };
        string Text1_window;

        string[] WindowText2 = { "警告", "Warning" };
        string Text2_window;

        string[] ConnectText2 = { "连接失败，请检查串口。", "Connection failed, please check the serial port" };
        string Text2_Connect;

        string[] SerialErrorText1 = { "串口数据发送出错，请检查。", "Serial data transmission error, please check." };
        string Text1_SerialError;

        string[] Direction_Text = { "警告：没有选择正反转，将默认正转。", "Warning: if forward and reverse is not selected, the default will be forward." };
        string Text1_Direction;

        string[] Speedgear_Text1 = { "错误：速度档位应为 0-127。", "Error: The speed gear should be 0-127." };
        string Text1_Speedgear;

        string[] SubdivisionError_Text1 = { "错误：任意细分范围应在 1-256。", "Error: Any subdivision range should be 1-256." };
        string Text1_SubdivisionError;

        string[] PulseError_Text1 = { "错误：脉冲数为 32 位正整数，即 0-4,294,967,295", "Error: number of pulses is 32 bits, 0-4,294,967,295" };
        string Text1_PulseError;

        string[] DataError_Text1 = { "警告：请选择数据类型", "Warning: Please select the data type." };
        string Text1_DataError;



        #endregion

        /// <summary>
        /// get motor address
        /// </summary>
        /// <returns></returns>
        private byte GetMotorAddr()
        {
            byte addr = Convert.ToByte(cmbMotorAddr.Text, 16);
            return addr;
        }


        /// <summary>
        /// stop motor
        /// </summary>
        private void MotorStop()
        {
            var command = BuildCmd(MotorCmd.Stop);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetMStep2_Click(object sender, EventArgs e)
        {
            byte mstep = Convert.ToByte(cmbMStep2.Text);
            var command = BuildCmd(MotorCmd.MStep, mstep);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// Enable the driver board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnableBorad_Click(object sender, EventArgs e)
        {
            byte enable = 1;
            var command = BuildCmd(MotorCmd.SetBoardFlag, enable);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// Disable the driver board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisenableBorad_Click(object sender, EventArgs e)
        {
            byte disable = 0;
            var command = BuildCmd(MotorCmd.SetBoardFlag, disable);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// Start the motor at the specified speed         
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            byte speed = SerialPortHelper.Speed(cmbSpeedGear.Text, rdoForward.Checked);
            var command = BuildCmd(MotorCmd.Start, speed);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 电机停止运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            MotorStop();
        }


        /// <summary>
        /// 读取编码器值          
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncoderVal_Click(object sender, EventArgs e)
        {
            var command = BuildCmd(MotorCmd.ReadEncoderVal);
            // 发送给串口命令的编号，串口返回数据处理时使用
            cmdFlag = MotorCmdFlag.ReadEncoderVal;
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 读取输入累计脉冲数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTotalPulseCounter_Click(object sender, EventArgs e)
        {
            var command = BuildCmd(MotorCmd.ReadTotalPulse);
            cmdFlag = MotorCmdFlag.ReadTotalPulse;
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 读取电机的实时位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMotorPosition_Click(object sender, EventArgs e)
        {
            var command = BuildCmd(MotorCmd.ReadPosition);
            cmdFlag = MotorCmdFlag.ReadPosition;
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 读取位置角度误差
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAngleError_Click(object sender, EventArgs e)
        {
            var command = BuildCmd(MotorCmd.ReadAngleError);
            cmdFlag = MotorCmdFlag.ReadAngleError;
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 读取驱动板的使能状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBoardStatus_Click(object sender, EventArgs e)
        {
            var command = BuildCmd(MotorCmd.ReadBoardFlag);
            cmdFlag = MotorCmdFlag.ReadBoardFlag;
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 读取堵转标志位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLockedFlag_Click(object sender, EventArgs e)
        {
            var command = BuildCmd(MotorCmd.ReadBlockFlag);
            cmdFlag = MotorCmdFlag.ReadBlockFlag;
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mySerialPort != null)
            {
                mySerialPort.Close();
            }
        }


        /// <summary>
        /// 设置自动回零的模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnableZeroMode_Click(object sender, EventArgs e)
        {
            // 读取回零模式设置
            byte mode;
            if (rdoDirMode.Checked)
            {
                mode = 1; // 方向模式
            }
            else if (rdoNearMode.Checked)
            {
                mode = 2; // 就近模式
            }
            else
            {
                MessageBox.Show("Zero mode error!");
                return;
            }

            var command = BuildCmd(MotorCmd.O_Mode, mode);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 关闭自动回零
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisableZeroMode_Click(object sender, EventArgs e)
        {
            var command = BuildCmd(MotorCmd.O_Mode, 0); // 关闭自动回零
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 设置自动回零的零点 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetZeroPos_Click(object sender, EventArgs e)
        {
            var command = BuildCmd(MotorCmd.Set_O, 0);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 设置自动回零的速度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetZeroSpeed_Click(object sender, EventArgs e)
        {
            // 读取界面上回零速度
            byte speed = Convert.ToByte(cmbZeroSpeed.Text);
            var command = BuildCmd(MotorCmd.O_Speed, speed);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 设置自动回零的方向 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetZeroDir_Click(object sender, EventArgs e)
        {
            // 读取方向设置
            byte dir;
            if (rdoZeroForward.Checked)
            {
                dir = 0;  // 对应顺时针方向 CW
            }
            else if (rdoZeroReversal.Checked)
            {
                dir = 1; // 对应逆时针方向 CCW
            }
            else
            {
                MessageBox.Show("Zero dir error!");
                return;
            }

            var command = BuildCmd(MotorCmd.O_Dir, dir);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 返回零点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGotoZeroPos_Click(object sender, EventArgs e)
        {
            var command = BuildCmd(MotorCmd.Goto_O, 0);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 电机停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop2_Click(object sender, EventArgs e)
        {
            MotorStop();
        }


        /// <summary>
        /// 指定脉冲个数，指定速度，启动电机运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart2_Click(object sender, EventArgs e)
        {
            // 获取速度
            var speed = SerialPortHelper.Speed(cmbSpeedGear2.Text, rdoForward2.Checked);
            var pulse = Convert.ToUInt32(txtPulseCounter.Text);
            var command = BuildCmd(MotorCmd.Rotate, speed, pulse);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 恢复默认参数，恢复出厂设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestore_Click(object sender, EventArgs e)
        {
            var command = BuildCmd(MotorCmd.Restore);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 校准编码器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCal_Click(object sender, EventArgs e)
        {
            var command = BuildCmd(MotorCmd.Cal, 0);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 设置电流档位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetMa_Click(object sender, EventArgs e)
        {
            if (cmbSetMa.SelectedIndex == -1)
            {
                MessageBox.Show("请设置电流档位！");
                return;
            }

            // 获取电流档位           
            byte ma = Convert.ToByte(cmbSetMa.SelectedIndex);
            var command = BuildCmd(MotorCmd.Ma, ma);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 设置工作模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetCtrMode_Click(object sender, EventArgs e)
        {
            if (cmbSetCtrMode.SelectedIndex == -1)
            {
                MessageBox.Show("请设置工作模式！");
                return;
            }

            // 获取电机类型
            // ctrMode = 0 开环模式
            // ctrMode = 1 闭环模式(STP/DIR 接口)            
            // ctrMode = 2 串口控制模式 (UART 接口)，也是闭环模式
            byte ctrMode = Convert.ToByte(cmbSetEn.SelectedIndex);

            var command = BuildCmd(MotorCmd.CtrMode, ctrMode);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 设置电机类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetMotType_Click(object sender, EventArgs e)
        {
            if (cmbSetMotType.SelectedIndex == -1)
            {
                MessageBox.Show("请设置电机类型！");
                return;
            }

            // 获取电机类型
            // motorType = 0: 0.9° 电机
            // motorType = 1: 1.8° 电机
            byte motorType = Convert.ToByte(cmbSetMotType.SelectedIndex);

            //
            var command = BuildCmd(MotorCmd.MotorType, motorType);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            //SendCmdToSerialPort(command);

        }


        /// <summary>
        /// 设置细分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetMStep_Click(object sender, EventArgs e)
        {
            if (cmbSetMStep.SelectedIndex == -1)
            {
                MessageBox.Show("请设置细分！（步进电机的细分）");
                return;
            }

            // 获取 MStep (步进电机的细分)
            byte mstep = Convert.ToByte(cmbSetMa.Text);
            //
            var command = BuildCmd(MotorCmd.MStep, mstep);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            //SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 设置 En 引脚有效电平
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetEn_Click(object sender, EventArgs e)
        {
            if (cmbSetEn.SelectedIndex == -1)
            {
                MessageBox.Show("请设置 En 引脚有效电平！");
                return;
            }

            // en = 0 对应低电平使能（L）
            // en = 1 对应高电平使能（H）           
            // en = 2 对应一直使能（Hold）
            byte en = Convert.ToByte(cmbSetEn.SelectedIndex);

            //
            var command = BuildCmd(MotorCmd.En, en);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            //SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 设置电机旋转正方向
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetDir_Click(object sender, EventArgs e)
        {
            if (cmbSetDir.SelectedIndex == -1)
            {
                MessageBox.Show("请设置电机旋转正方向！");
                return;
            }

            // 获取电机旋转正方向
            // dir = 0： 对应顺时针旋转 CW
            // dir = 1： 对应逆时针旋转 CCW
            byte dir = Convert.ToByte(cmbSetDir.SelectedIndex);

            //
            var command = BuildCmd(MotorCmd.Dir, dir);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            //SendCmdToSerialPort(command);

        }


        /// <summary>
        /// 设置自动熄屏功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetAutoSDD_Click(object sender, EventArgs e)
        {
            if (cmbSetAutoSDD.SelectedIndex == -1)
            {
                MessageBox.Show("请设置自动熄屏功能！");
                return;
            }

            // autoSDD = 0： Disable 关闭自动熄屏功能
            // autoSDD = 1： Enable 开启自动熄屏
            byte autoSDD = Convert.ToByte(cmbSetAutoSDD.SelectedIndex);

            //
            var command = BuildCmd(MotorCmd.AutoSDD, autoSDD);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            //SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 设置堵转保护功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetProtect_Click(object sender, EventArgs e)
        {
            // protect = 0： Disable 关闭堵转保护功能
            // protect = 1： Enable 开启堵转保护
            byte protect = Convert.ToByte(cmbSetProtect.SelectedIndex);

            //
            var command = BuildCmd(MotorCmd.Protect, protect);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 设置细分插补功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetMPlyer_Click(object sender, EventArgs e)
        {
            // mplyer = 0： Disable 关闭内部的 256 细分插补功能
            // mplyer = 1： Enable 开启内部的 256 细分插补功能
            byte mplyer = Convert.ToByte(cmbSetMPlyer.SelectedIndex);

            //
            var command = BuildCmd(MotorCmd.MPlyer, mplyer);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 设置串口波特率 (UartBaud)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetUartBaud_Click(object sender, EventArgs e)
        {
            if (cmbSetUartBaud.SelectedIndex == -1)
            {
                MessageBox.Show("请设置串口波特率！");
                return;
            }

            // 获取串口波特率
            // uartBuad = 0: 0
            // uartBuad = 1: 9600            
            // uartBuad = 2: 19200
            // uartBuad = 3: 25000
            // uartBuad = 4: 38400
            // uartBuad = 5: 57600
            // uartBuad = 6: 115200
            byte uartBuad = Convert.ToByte(cmbSetUartBaud.SelectedIndex);

            //
            var command = BuildCmd(MotorCmd.UartBuad, uartBuad);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            //SendCmdToSerialPort(command);

        }


        /// <summary>
        /// 设置串口地址 (UartAddr)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetUartAddr_Click(object sender, EventArgs e)
        {
            if (cmbSetUartAddr.SelectedIndex == -1)
            {
                MessageBox.Show("请设置串口地址！");
                return;
            }

            // 获取设置串口地址
            // uartAddr = 0: E0
            // uartAddr = 1: E1
            // uartAddr = 2: E2
            // uartAddr = 3: E3
            // uartAddr = 4: E4
            // uartAddr = 5: E5
            // uartAddr = 6: E6
            // uartAddr = 7: E7
            // uartAddr = 8: E8
            // uartAddr = 9: E9            
            byte uartAddr = Convert.ToByte(cmbSetUartAddr.SelectedIndex);

            //
            var command = BuildCmd(MotorCmd.UartAddr, uartAddr);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            //SendCmdToSerialPort(command);
        }


        private void btnPowerOnRun_Click(object sender, EventArgs e)
        {
            // 保存上面(2)中所设置的正/反转速度
            var command = BuildCmd(MotorCmd.Save, 0xC8); // 0xC8 保存
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            //SendCmdToSerialPort(command);
        }


        private void btnPowerOnStop_Click(object sender, EventArgs e)
        {
            // 清除已保存的正/反转速度；
            var command = BuildCmd(MotorCmd.Save, 0xCA); // 0xCA 清除
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            //SendCmdToSerialPort(command);
        }


        private void btnSetKP_Click(object sender, EventArgs e)
        {
            /*
             * 注意：PID 参数设置不当，电机可能震动，请谨慎设置参数！！！               
             */

            //设置位置 Kp 参数。(Kp 默认值为 0x650)            
            var command = BuildCmd(MotorCmd.PID_Kp, 0x650);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            //SendCmdToSerialPort(command);
        }


        private void btnSetKI_Click(object sender, EventArgs e)
        {
            /*
            * 注意：PID 参数设置不当，电机可能震动，请谨慎设置参数！！！
            */

            // 设置位置 Ki 参数。(Ki 默认值为 1)         
            var command = BuildCmd(MotorCmd.PID_Ki, (ushort)0x1);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            //SendCmdToSerialPort(command);
        }


        private void btnSetKD_Click(object sender, EventArgs e)
        {
            /*
             * 注意：PID 参数设置不当，电机可能震动，请谨慎设置参数！！！
             */

            // 设置位置 Kd 参数。(Kd 默认值为 0x650)   
            var command = BuildCmd(MotorCmd.PID_Kd, 0x650);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            //SendCmdToSerialPort(command);
        }


        private void btnSetACC_Click(object sender, EventArgs e)
        {
            /*
             * 注意： ACC 设置过大，可能损坏驱动板，请谨慎设置参数！！！ 
             */

            //设置 ACC 参数。(ACC 默认值为 0x11E)            
            var command = BuildCmd(MotorCmd.ACC, 0x11E);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            //SendCmdToSerialPort(command);
        }


        private void btnSetMaxT_Click(object sender, EventArgs e)
        {
            /*
             * 注意： MaxT 设置过大，可能损坏驱动板，请谨慎设置参数！！！ 
             */

            // 设置最大扭矩 MaxT。(MaxT 默认值为 0x4B0), MaxT 取值范围（0 ~ 0x4B0）        
            var command = BuildCmd(MotorCmd.ACC, 0x4B0);
            Debug.WriteLine("Send Command: " + SerialPortHelper.BytesToHexStr(command));
            //SendCmdToSerialPort(command);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="motorCmd"></param>
        /// <returns></returns>
        private byte[] BuildCmd(byte motorCmd)
        {
            return SerialPortHelper.BuildTwoBytesCmd(GetMotorAddr(), motorCmd);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="motorCmd"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        private byte[] BuildCmd(byte motorCmd, byte param)
        {
            return SerialPortHelper.BuildThreeBytesCmd(GetMotorAddr(), motorCmd, param);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="motorCmd"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        private byte[] BuildCmd(byte motorCmd, UInt16 param)
        {
            return SerialPortHelper.BuildFourBytesCmd(GetMotorAddr(), motorCmd, param);
        }


        private byte[] BuildCmd(byte motorCmd, byte speed, UInt32 pulse)
        {
            return SerialPortHelper.BuildSevenBytesCmd(GetMotorAddr(), motorCmd, speed, pulse);
        }


        private void btnClearDisplay_Click(object sender, EventArgs e)
        {
            rtxCmdDisplay.Text = "";
        }


        private void cmbMotorAddr_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEncodeVal.Text = String.Empty;
            txtTotalPulse.Text = String.Empty;
            txtMotorPosition.Text = String.Empty;
            txtAngleError.Text = String.Empty;
            txtBoardStatus.Text = String.Empty;
            txtLockedFlag.Text = String.Empty;
        }


        int StopFlag = 0;

        private void btnSwing_Click(object sender, EventArgs e)
        {
            StopFlag = 1;

            Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    if (StopFlag == 2)
                    {
                        return;
                    }

                    // 获取速度
                    var speed = Convert.ToByte(10);
                    var reverse = SerialPortHelper.Speed(speed, false);
                    var pulse = Convert.ToUInt32(1800);
                    var command = SerialPortHelper.BuildSevenBytesCmd(Convert.ToByte("E3", 16), MotorCmd.Rotate, speed, pulse);
                    SendCmdToSerialPort(command);
                    Thread.Sleep(1500);

                    command = BuildCmd(MotorCmd.Rotate, reverse, pulse);
                    SendCmdToSerialPort(command);
                    Thread.Sleep(1500);
                }
            });
        }


        private void btnStopSWing_Click(object sender, EventArgs e)
        {
            StopFlag = 2;
        }
    }
}

