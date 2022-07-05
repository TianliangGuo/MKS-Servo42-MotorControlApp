using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKS_SERVO42C_CONTROL
{
    public static class MotorCmd
    {
        // 读取参数命令
        public const byte ReadEncoderVal = 0x30; // 读取编码器值（ 经过线性化校准和插值后的值）
        public const byte ReadTotalPulse = 0x33; // 读取输入累计脉冲数
        public const byte ReadPosition = 0x36; // 读取闭环电机的实时位置
        public const byte ReadAngleError = 0x39; // 读取位置角度误差
        public const byte ReadBoardFlag = 0x3A; // 读取闭环驱动板的使能状态
        public const byte ReadBlockFlag = 0x3E; // 读取堵转标志位   堵转：返回 e0 01；没堵转：返回 e0 02； 错误指令：返回 e0 00

        // 串口直接控制命令
        public const byte SetBoardFlag = 0xF3;// 修改串口控制模式下驱动板的使能状态        
        public const byte Start = 0xF6;  // 让电机以一定的速度进行正/反转
        public const byte Stop = 0xF7;// 让电机停止正/反转
        public const byte Save = 0xFF;// 保存/清除保存上面(2)中所设置的正/反转速度                
        public const byte Rotate = 0xFD;  // 串口直接位置控制转动

        // 设置系统参数命令
        public const byte Cal = 0x80; // 校准编码器
        public const byte MotorType = 0x81; // 设置电机类型
        public const byte CtrMode = 0x82; // 设置工作模式。
        public const byte Ma = 0x83; // 设置电流档位
        public const byte MStep = 0x84; // 设置任意细分 （对应屏幕上的“MStep”选项）
        public const byte En = 0x85; // 设置 En 引脚有效电平
        public const byte Dir = 0x86; // 设置电机旋转正方向
        public const byte AutoSDD = 0x87; // 设置自动熄屏功能
        public const byte Protect = 0x88; // 设置堵转保护功能
        public const byte MPlyer = 0x89; // 设置细分插补功能
        public const byte UartBuad = 0x8A; // 设置串口波特率
        public const byte UartAddr = 0x8B; // 设置串口地址

        // 设置 PID/加速度/扭矩参数命令
        public const byte PID_Kp = 0xA1; // 设置位置 Kp 参数
        public const byte PID_Ki = 0xA2; // 设置位置 Ki 参数
        public const byte PID_Kd = 0xA3; // 设置位置 Kd 参数
        public const byte ACC = 0xA4; // 设置加速度 ACC 参数
        public const byte MaxT = 0xA5; // 设置最大扭矩 MaxT 参数

        // 自动回零相关命令
        public const byte O_Mode = 0x90; // 设置自动回零的--模式: 00 关闭自动回零 Disable; 01 方向模式 DirMode; 02 就近模式 NearMode
        public const byte Set_O = 0x91; // 设置自动回零的--设置零点 
        public const byte O_Speed = 0x92; // 设置自动回零的--回零速度 
        public const byte O_Dir = 0x93; // 设置自动回零的--回零方向
        public const byte Goto_O = 0x94; // 返回零点

        // 重置电机参数
        public const byte Restore = 0x3F;
    }

    public enum MotorCmdFlag
    {
        // 
        None,

        // 读取编码值
        ReadEncoderVal,

        // 读取总的脉冲数
        ReadTotalPulse,

        // 读取电机位置
        ReadPosition,

        // 读取角度误差
        ReadAngleError,

        // 读取主板激活状态
        ReadBoardFlag,

        // 读取电机是否堵转状态
        ReadBlockFlag
    }
}
