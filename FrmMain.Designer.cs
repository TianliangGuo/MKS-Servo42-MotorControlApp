
namespace MKS_SERVO42C_CONTROL
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblComName = new System.Windows.Forms.Label();
            this.lblBaud = new System.Windows.Forms.Label();
            this.grpLinkSetings = new System.Windows.Forms.GroupBox();
            this.btnCloseCom = new System.Windows.Forms.Button();
            this.cmbMotorAddr = new System.Windows.Forms.ComboBox();
            this.lblMotorAddr = new System.Windows.Forms.Label();
            this.btnScanCom = new System.Windows.Forms.Button();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.cmbComName = new System.Windows.Forms.ComboBox();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.grpReadParameters = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoDec = new System.Windows.Forms.RadioButton();
            this.rdoHex = new System.Windows.Forms.RadioButton();
            this.txtLockedFlag = new System.Windows.Forms.TextBox();
            this.txtBoardStatus = new System.Windows.Forms.TextBox();
            this.txtAngleError = new System.Windows.Forms.TextBox();
            this.btnLockedFlag = new System.Windows.Forms.Button();
            this.txtMotorPosition = new System.Windows.Forms.TextBox();
            this.txtTotalPulse = new System.Windows.Forms.TextBox();
            this.txtEncodeVal = new System.Windows.Forms.TextBox();
            this.btnBoardStatus = new System.Windows.Forms.Button();
            this.btnAngleError = new System.Windows.Forms.Button();
            this.btnMotorPosition = new System.Windows.Forms.Button();
            this.btnTotalPulseCounter = new System.Windows.Forms.Button();
            this.btnEncoderVal = new System.Windows.Forms.Button();
            this.btnSetMStep = new System.Windows.Forms.Button();
            this.lblMStep = new System.Windows.Forms.Label();
            this.grpMotorContorl = new System.Windows.Forms.GroupBox();
            this.grpMotorPosition = new System.Windows.Forms.GroupBox();
            this.cmbMStep2 = new System.Windows.Forms.ComboBox();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnMStep2 = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.lblMStepAlert = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoReversal2 = new System.Windows.Forms.RadioButton();
            this.rdoForward2 = new System.Windows.Forms.RadioButton();
            this.lblMStep2 = new System.Windows.Forms.Label();
            this.lblPulseCounterAlert = new System.Windows.Forms.Label();
            this.txtPulseCounter = new System.Windows.Forms.TextBox();
            this.lblPulseCounter = new System.Windows.Forms.Label();
            this.lblSpeedGear2 = new System.Windows.Forms.Label();
            this.cmbSpeedGear2 = new System.Windows.Forms.ComboBox();
            this.btnEnableBorad = new System.Windows.Forms.Button();
            this.btnDisenableBorad = new System.Windows.Forms.Button();
            this.grpMotorStart = new System.Windows.Forms.GroupBox();
            this.lblSpeedGearAlert = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoReversal = new System.Windows.Forms.RadioButton();
            this.rdoForward = new System.Windows.Forms.RadioButton();
            this.btnPowerOnStop = new System.Windows.Forms.Button();
            this.btnPowerOnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbSpeedGear = new System.Windows.Forms.ComboBox();
            this.lblSpeedGear = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSysSettings = new System.Windows.Forms.GroupBox();
            this.cmbSetMStep = new System.Windows.Forms.ComboBox();
            this.btnSetUartAddr = new System.Windows.Forms.Button();
            this.btnSetUartBaud = new System.Windows.Forms.Button();
            this.btnSetMPlyer = new System.Windows.Forms.Button();
            this.btnSetProtect = new System.Windows.Forms.Button();
            this.btnSetAutoSDD = new System.Windows.Forms.Button();
            this.btnSetDir = new System.Windows.Forms.Button();
            this.btnSetEn = new System.Windows.Forms.Button();
            this.btnSetMa = new System.Windows.Forms.Button();
            this.btnSetCtrMode = new System.Windows.Forms.Button();
            this.btnSetMotType = new System.Windows.Forms.Button();
            this.cmbSetUartAddr = new System.Windows.Forms.ComboBox();
            this.lblSetUartAddr = new System.Windows.Forms.Label();
            this.cmbSetUartBaud = new System.Windows.Forms.ComboBox();
            this.lblSetUartBaud = new System.Windows.Forms.Label();
            this.cmbSetMPlyer = new System.Windows.Forms.ComboBox();
            this.lblSetMPlyer = new System.Windows.Forms.Label();
            this.cmbSetProtect = new System.Windows.Forms.ComboBox();
            this.lblSetProtect = new System.Windows.Forms.Label();
            this.cmbSetAutoSDD = new System.Windows.Forms.ComboBox();
            this.lblSetAutoSDD = new System.Windows.Forms.Label();
            this.cmbSetDir = new System.Windows.Forms.ComboBox();
            this.lblSetDir = new System.Windows.Forms.Label();
            this.cmbSetEn = new System.Windows.Forms.ComboBox();
            this.lblSetEn = new System.Windows.Forms.Label();
            this.cmbSetMa = new System.Windows.Forms.ComboBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.cmbSetCtrMode = new System.Windows.Forms.ComboBox();
            this.lblCtrMode = new System.Windows.Forms.Label();
            this.cmbSetMotType = new System.Windows.Forms.ComboBox();
            this.lblMotorType = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.grpPID = new System.Windows.Forms.GroupBox();
            this.grpMaxT = new System.Windows.Forms.GroupBox();
            this.btnSetMaxT = new System.Windows.Forms.Button();
            this.cmbSetMaxT = new System.Windows.Forms.ComboBox();
            this.lblSetMaxT = new System.Windows.Forms.Label();
            this.grpAcceleration = new System.Windows.Forms.GroupBox();
            this.btnSetACC = new System.Windows.Forms.Button();
            this.cmbSetACC = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.grpPIDSettings = new System.Windows.Forms.GroupBox();
            this.btnSetKD = new System.Windows.Forms.Button();
            this.btnSetKI = new System.Windows.Forms.Button();
            this.btnSetKP = new System.Windows.Forms.Button();
            this.lblSetKP = new System.Windows.Forms.Label();
            this.cmbSetKD = new System.Windows.Forms.ComboBox();
            this.lblSetKI = new System.Windows.Forms.Label();
            this.cmbSetKI = new System.Windows.Forms.ComboBox();
            this.lblSetKD = new System.Windows.Forms.Label();
            this.cmbSetKP = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.grpSetZeroParameters = new System.Windows.Forms.GroupBox();
            this.buttonGotoZeroPos = new System.Windows.Forms.Button();
            this.btnSetZeroDir = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdoZeroReversal = new System.Windows.Forms.RadioButton();
            this.rdoZeroForward = new System.Windows.Forms.RadioButton();
            this.lblZeroDir = new System.Windows.Forms.Label();
            this.btnSetZeroSpeed = new System.Windows.Forms.Button();
            this.cmbZeroSpeed = new System.Windows.Forms.ComboBox();
            this.lblZeroSpeed = new System.Windows.Forms.Label();
            this.btnSetZeroPos = new System.Windows.Forms.Button();
            this.lblSetZeroPosition = new System.Windows.Forms.Label();
            this.btnDisableZeroMode = new System.Windows.Forms.Button();
            this.btnEnableZeroMode = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdoNearMode = new System.Windows.Forms.RadioButton();
            this.rdoDirMode = new System.Windows.Forms.RadioButton();
            this.lblZeroMode = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblRestore = new System.Windows.Forms.Label();
            this.rtxCmdDisplay = new System.Windows.Forms.RichTextBox();
            this.btnClearDisplay = new System.Windows.Forms.Button();
            this.btnSwing = new System.Windows.Forms.Button();
            this.btnStopSWing = new System.Windows.Forms.Button();
            this.grpLinkSetings.SuspendLayout();
            this.grpReadParameters.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpMotorContorl.SuspendLayout();
            this.grpMotorPosition.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpMotorStart.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpSysSettings.SuspendLayout();
            this.grpPID.SuspendLayout();
            this.grpMaxT.SuspendLayout();
            this.grpAcceleration.SuspendLayout();
            this.grpPIDSettings.SuspendLayout();
            this.grpSetZeroParameters.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.Font = new System.Drawing.Font("SimSun", 10F);
            this.lblComName.Location = new System.Drawing.Point(6, 28);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(49, 14);
            this.lblComName.TabIndex = 2;
            this.lblComName.Text = "串  口";
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Font = new System.Drawing.Font("SimSun", 10F);
            this.lblBaud.Location = new System.Drawing.Point(6, 59);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(49, 14);
            this.lblBaud.TabIndex = 3;
            this.lblBaud.Text = "波特率";
            // 
            // grpLinkSetings
            // 
            this.grpLinkSetings.BackColor = System.Drawing.SystemColors.Control;
            this.grpLinkSetings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpLinkSetings.Controls.Add(this.btnCloseCom);
            this.grpLinkSetings.Controls.Add(this.cmbMotorAddr);
            this.grpLinkSetings.Controls.Add(this.lblMotorAddr);
            this.grpLinkSetings.Controls.Add(this.btnScanCom);
            this.grpLinkSetings.Controls.Add(this.cmbBaud);
            this.grpLinkSetings.Controls.Add(this.cmbComName);
            this.grpLinkSetings.Controls.Add(this.btnOpenCom);
            this.grpLinkSetings.Controls.Add(this.lblBaud);
            this.grpLinkSetings.Controls.Add(this.lblComName);
            this.grpLinkSetings.Font = new System.Drawing.Font("SimSun", 11F);
            this.grpLinkSetings.Location = new System.Drawing.Point(12, 35);
            this.grpLinkSetings.Name = "grpLinkSetings";
            this.grpLinkSetings.Size = new System.Drawing.Size(236, 163);
            this.grpLinkSetings.TabIndex = 4;
            this.grpLinkSetings.TabStop = false;
            this.grpLinkSetings.Text = "连接设置";
            // 
            // btnCloseCom
            // 
            this.btnCloseCom.Location = new System.Drawing.Point(120, 121);
            this.btnCloseCom.Name = "btnCloseCom";
            this.btnCloseCom.Size = new System.Drawing.Size(102, 30);
            this.btnCloseCom.TabIndex = 11;
            this.btnCloseCom.Text = "关闭串口";
            this.btnCloseCom.UseVisualStyleBackColor = true;
            this.btnCloseCom.Click += new System.EventHandler(this.btnCloseCom_Click);
            // 
            // cmbMotorAddr
            // 
            this.cmbMotorAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotorAddr.FormattingEnabled = true;
            this.cmbMotorAddr.Location = new System.Drawing.Point(75, 88);
            this.cmbMotorAddr.Name = "cmbMotorAddr";
            this.cmbMotorAddr.Size = new System.Drawing.Size(97, 23);
            this.cmbMotorAddr.TabIndex = 10;
            this.cmbMotorAddr.SelectedIndexChanged += new System.EventHandler(this.cmbMotorAddr_SelectedIndexChanged);
            // 
            // lblMotorAddr
            // 
            this.lblMotorAddr.AutoSize = true;
            this.lblMotorAddr.Location = new System.Drawing.Point(6, 90);
            this.lblMotorAddr.Name = "lblMotorAddr";
            this.lblMotorAddr.Size = new System.Drawing.Size(67, 15);
            this.lblMotorAddr.TabIndex = 9;
            this.lblMotorAddr.Text = "通讯地址";
            // 
            // btnScanCom
            // 
            this.btnScanCom.Location = new System.Drawing.Point(174, 26);
            this.btnScanCom.Name = "btnScanCom";
            this.btnScanCom.Size = new System.Drawing.Size(52, 24);
            this.btnScanCom.TabIndex = 8;
            this.btnScanCom.Text = "扫描";
            this.btnScanCom.UseVisualStyleBackColor = true;
            this.btnScanCom.Click += new System.EventHandler(this.btnScanCom_Click);
            // 
            // cmbBaud
            // 
            this.cmbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Location = new System.Drawing.Point(75, 56);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(97, 23);
            this.cmbBaud.TabIndex = 7;
            // 
            // cmbComName
            // 
            this.cmbComName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComName.FormattingEnabled = true;
            this.cmbComName.Location = new System.Drawing.Point(75, 26);
            this.cmbComName.Name = "cmbComName";
            this.cmbComName.Size = new System.Drawing.Size(97, 23);
            this.cmbComName.TabIndex = 6;
            // 
            // btnOpenCom
            // 
            this.btnOpenCom.Location = new System.Drawing.Point(6, 121);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(102, 30);
            this.btnOpenCom.TabIndex = 4;
            this.btnOpenCom.Text = "连接串口";
            this.btnOpenCom.UseVisualStyleBackColor = true;
            this.btnOpenCom.Click += new System.EventHandler(this.btnOpenCom_Click);
            // 
            // grpReadParameters
            // 
            this.grpReadParameters.BackColor = System.Drawing.SystemColors.Control;
            this.grpReadParameters.Controls.Add(this.panel3);
            this.grpReadParameters.Controls.Add(this.txtLockedFlag);
            this.grpReadParameters.Controls.Add(this.txtBoardStatus);
            this.grpReadParameters.Controls.Add(this.txtAngleError);
            this.grpReadParameters.Controls.Add(this.btnLockedFlag);
            this.grpReadParameters.Controls.Add(this.txtMotorPosition);
            this.grpReadParameters.Controls.Add(this.txtTotalPulse);
            this.grpReadParameters.Controls.Add(this.txtEncodeVal);
            this.grpReadParameters.Controls.Add(this.btnBoardStatus);
            this.grpReadParameters.Controls.Add(this.btnAngleError);
            this.grpReadParameters.Controls.Add(this.btnMotorPosition);
            this.grpReadParameters.Controls.Add(this.btnTotalPulseCounter);
            this.grpReadParameters.Controls.Add(this.btnEncoderVal);
            this.grpReadParameters.Font = new System.Drawing.Font("SimSun", 11F);
            this.grpReadParameters.Location = new System.Drawing.Point(12, 216);
            this.grpReadParameters.Name = "grpReadParameters";
            this.grpReadParameters.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpReadParameters.Size = new System.Drawing.Size(218, 444);
            this.grpReadParameters.TabIndex = 5;
            this.grpReadParameters.TabStop = false;
            this.grpReadParameters.Text = "读取参数";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdoDec);
            this.panel3.Controls.Add(this.rdoHex);
            this.panel3.Location = new System.Drawing.Point(10, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 29);
            this.panel3.TabIndex = 12;
            // 
            // rdoDec
            // 
            this.rdoDec.AutoSize = true;
            this.rdoDec.Location = new System.Drawing.Point(127, 7);
            this.rdoDec.Name = "rdoDec";
            this.rdoDec.Size = new System.Drawing.Size(70, 19);
            this.rdoDec.TabIndex = 1;
            this.rdoDec.Text = "十进制";
            this.rdoDec.UseVisualStyleBackColor = true;
            // 
            // rdoHex
            // 
            this.rdoHex.AutoSize = true;
            this.rdoHex.Checked = true;
            this.rdoHex.Location = new System.Drawing.Point(3, 7);
            this.rdoHex.Name = "rdoHex";
            this.rdoHex.Size = new System.Drawing.Size(85, 19);
            this.rdoHex.TabIndex = 0;
            this.rdoHex.TabStop = true;
            this.rdoHex.Text = "十六进制";
            this.rdoHex.UseVisualStyleBackColor = true;
            // 
            // txtLockedFlag
            // 
            this.txtLockedFlag.BackColor = System.Drawing.SystemColors.Menu;
            this.txtLockedFlag.Location = new System.Drawing.Point(10, 408);
            this.txtLockedFlag.Name = "txtLockedFlag";
            this.txtLockedFlag.Size = new System.Drawing.Size(203, 24);
            this.txtLockedFlag.TabIndex = 11;
            // 
            // txtBoardStatus
            // 
            this.txtBoardStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoardStatus.Location = new System.Drawing.Point(10, 344);
            this.txtBoardStatus.Name = "txtBoardStatus";
            this.txtBoardStatus.Size = new System.Drawing.Size(203, 24);
            this.txtBoardStatus.TabIndex = 10;
            // 
            // txtAngleError
            // 
            this.txtAngleError.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAngleError.Location = new System.Drawing.Point(10, 282);
            this.txtAngleError.Name = "txtAngleError";
            this.txtAngleError.Size = new System.Drawing.Size(203, 24);
            this.txtAngleError.TabIndex = 9;
            // 
            // btnLockedFlag
            // 
            this.btnLockedFlag.Font = new System.Drawing.Font("SimSun", 10F);
            this.btnLockedFlag.Location = new System.Drawing.Point(10, 379);
            this.btnLockedFlag.Name = "btnLockedFlag";
            this.btnLockedFlag.Size = new System.Drawing.Size(135, 24);
            this.btnLockedFlag.TabIndex = 5;
            this.btnLockedFlag.Tag = "";
            this.btnLockedFlag.Text = "堵转标志位";
            this.btnLockedFlag.UseVisualStyleBackColor = true;
            this.btnLockedFlag.Click += new System.EventHandler(this.btnLockedFlag_Click);
            // 
            // txtMotorPosition
            // 
            this.txtMotorPosition.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMotorPosition.Location = new System.Drawing.Point(10, 217);
            this.txtMotorPosition.Name = "txtMotorPosition";
            this.txtMotorPosition.Size = new System.Drawing.Size(203, 24);
            this.txtMotorPosition.TabIndex = 8;
            // 
            // txtTotalPulse
            // 
            this.txtTotalPulse.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTotalPulse.Location = new System.Drawing.Point(10, 151);
            this.txtTotalPulse.Name = "txtTotalPulse";
            this.txtTotalPulse.Size = new System.Drawing.Size(203, 24);
            this.txtTotalPulse.TabIndex = 7;
            // 
            // txtEncodeVal
            // 
            this.txtEncodeVal.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEncodeVal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEncodeVal.Location = new System.Drawing.Point(10, 88);
            this.txtEncodeVal.Name = "txtEncodeVal";
            this.txtEncodeVal.Size = new System.Drawing.Size(203, 24);
            this.txtEncodeVal.TabIndex = 6;
            // 
            // btnBoardStatus
            // 
            this.btnBoardStatus.Font = new System.Drawing.Font("SimSun", 10F);
            this.btnBoardStatus.Location = new System.Drawing.Point(10, 315);
            this.btnBoardStatus.Name = "btnBoardStatus";
            this.btnBoardStatus.Size = new System.Drawing.Size(135, 24);
            this.btnBoardStatus.TabIndex = 4;
            this.btnBoardStatus.Tag = "";
            this.btnBoardStatus.Text = "驱动板使能状态";
            this.btnBoardStatus.UseVisualStyleBackColor = true;
            this.btnBoardStatus.Click += new System.EventHandler(this.btnBoardStatus_Click);
            // 
            // btnAngleError
            // 
            this.btnAngleError.Font = new System.Drawing.Font("SimSun", 10F);
            this.btnAngleError.Location = new System.Drawing.Point(10, 253);
            this.btnAngleError.Name = "btnAngleError";
            this.btnAngleError.Size = new System.Drawing.Size(135, 24);
            this.btnAngleError.TabIndex = 3;
            this.btnAngleError.Tag = "";
            this.btnAngleError.Text = "位置角度误差";
            this.btnAngleError.UseVisualStyleBackColor = true;
            this.btnAngleError.Click += new System.EventHandler(this.btnAngleError_Click);
            // 
            // btnMotorPosition
            // 
            this.btnMotorPosition.Font = new System.Drawing.Font("SimSun", 10F);
            this.btnMotorPosition.Location = new System.Drawing.Point(10, 188);
            this.btnMotorPosition.Name = "btnMotorPosition";
            this.btnMotorPosition.Size = new System.Drawing.Size(135, 24);
            this.btnMotorPosition.TabIndex = 2;
            this.btnMotorPosition.Tag = "";
            this.btnMotorPosition.Text = "电机位置";
            this.btnMotorPosition.UseVisualStyleBackColor = true;
            this.btnMotorPosition.Click += new System.EventHandler(this.btnMotorPosition_Click);
            // 
            // btnTotalPulseCounter
            // 
            this.btnTotalPulseCounter.Font = new System.Drawing.Font("SimSun", 10F);
            this.btnTotalPulseCounter.Location = new System.Drawing.Point(10, 122);
            this.btnTotalPulseCounter.Name = "btnTotalPulseCounter";
            this.btnTotalPulseCounter.Size = new System.Drawing.Size(135, 24);
            this.btnTotalPulseCounter.TabIndex = 1;
            this.btnTotalPulseCounter.Tag = "";
            this.btnTotalPulseCounter.Text = "输入累计脉冲数";
            this.btnTotalPulseCounter.UseVisualStyleBackColor = true;
            this.btnTotalPulseCounter.Click += new System.EventHandler(this.btnTotalPulseCounter_Click);
            // 
            // btnEncoderVal
            // 
            this.btnEncoderVal.Font = new System.Drawing.Font("SimSun", 10F);
            this.btnEncoderVal.Location = new System.Drawing.Point(10, 59);
            this.btnEncoderVal.Name = "btnEncoderVal";
            this.btnEncoderVal.Size = new System.Drawing.Size(135, 24);
            this.btnEncoderVal.TabIndex = 0;
            this.btnEncoderVal.Tag = "";
            this.btnEncoderVal.Text = "编码器值";
            this.btnEncoderVal.UseVisualStyleBackColor = true;
            this.btnEncoderVal.Click += new System.EventHandler(this.btnEncoderVal_Click);
            // 
            // btnSetMStep
            // 
            this.btnSetMStep.Location = new System.Drawing.Point(233, 166);
            this.btnSetMStep.Name = "btnSetMStep";
            this.btnSetMStep.Size = new System.Drawing.Size(75, 24);
            this.btnSetMStep.TabIndex = 3;
            this.btnSetMStep.Tag = "";
            this.btnSetMStep.Text = "确认";
            this.btnSetMStep.UseVisualStyleBackColor = true;
            this.btnSetMStep.Click += new System.EventHandler(this.btnSetMStep_Click);
            // 
            // lblMStep
            // 
            this.lblMStep.AutoSize = true;
            this.lblMStep.Font = new System.Drawing.Font("SimSun", 10F);
            this.lblMStep.Location = new System.Drawing.Point(15, 171);
            this.lblMStep.Name = "lblMStep";
            this.lblMStep.Size = new System.Drawing.Size(63, 14);
            this.lblMStep.TabIndex = 0;
            this.lblMStep.Text = "细分设置";
            // 
            // grpMotorContorl
            // 
            this.grpMotorContorl.BackColor = System.Drawing.SystemColors.Control;
            this.grpMotorContorl.Controls.Add(this.grpMotorPosition);
            this.grpMotorContorl.Controls.Add(this.btnEnableBorad);
            this.grpMotorContorl.Controls.Add(this.btnDisenableBorad);
            this.grpMotorContorl.Controls.Add(this.grpMotorStart);
            this.grpMotorContorl.Font = new System.Drawing.Font("SimSun", 11F);
            this.grpMotorContorl.Location = new System.Drawing.Point(923, 314);
            this.grpMotorContorl.Name = "grpMotorContorl";
            this.grpMotorContorl.Size = new System.Drawing.Size(515, 346);
            this.grpMotorContorl.TabIndex = 7;
            this.grpMotorContorl.TabStop = false;
            this.grpMotorContorl.Text = "电机控制";
            // 
            // grpMotorPosition
            // 
            this.grpMotorPosition.Controls.Add(this.cmbMStep2);
            this.grpMotorPosition.Controls.Add(this.btnStop2);
            this.grpMotorPosition.Controls.Add(this.btnMStep2);
            this.grpMotorPosition.Controls.Add(this.btnStart2);
            this.grpMotorPosition.Controls.Add(this.lblMStepAlert);
            this.grpMotorPosition.Controls.Add(this.panel2);
            this.grpMotorPosition.Controls.Add(this.lblMStep2);
            this.grpMotorPosition.Controls.Add(this.lblPulseCounterAlert);
            this.grpMotorPosition.Controls.Add(this.txtPulseCounter);
            this.grpMotorPosition.Controls.Add(this.lblPulseCounter);
            this.grpMotorPosition.Controls.Add(this.lblSpeedGear2);
            this.grpMotorPosition.Controls.Add(this.cmbSpeedGear2);
            this.grpMotorPosition.Location = new System.Drawing.Point(256, 68);
            this.grpMotorPosition.Name = "grpMotorPosition";
            this.grpMotorPosition.Size = new System.Drawing.Size(244, 263);
            this.grpMotorPosition.TabIndex = 3;
            this.grpMotorPosition.TabStop = false;
            this.grpMotorPosition.Text = "控制电机位置";
            // 
            // cmbMStep2
            // 
            this.cmbMStep2.FormattingEnabled = true;
            this.cmbMStep2.Location = new System.Drawing.Point(90, 29);
            this.cmbMStep2.Name = "cmbMStep2";
            this.cmbMStep2.Size = new System.Drawing.Size(70, 23);
            this.cmbMStep2.TabIndex = 10;
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(142, 224);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(75, 24);
            this.btnStop2.TabIndex = 9;
            this.btnStop2.Tag = "";
            this.btnStop2.Text = "停止";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnMStep2
            // 
            this.btnMStep2.Location = new System.Drawing.Point(162, 26);
            this.btnMStep2.Name = "btnMStep2";
            this.btnMStep2.Size = new System.Drawing.Size(75, 24);
            this.btnMStep2.TabIndex = 3;
            this.btnMStep2.Tag = "";
            this.btnMStep2.Text = "确认";
            this.btnMStep2.UseVisualStyleBackColor = true;
            this.btnMStep2.Click += new System.EventHandler(this.btnSetMStep2_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Location = new System.Drawing.Point(22, 224);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(75, 24);
            this.btnStart2.TabIndex = 9;
            this.btnStart2.Tag = "";
            this.btnStart2.Text = "开始";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // lblMStepAlert
            // 
            this.lblMStepAlert.Font = new System.Drawing.Font("SimSun", 9F);
            this.lblMStepAlert.Location = new System.Drawing.Point(18, 56);
            this.lblMStepAlert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMStepAlert.Name = "lblMStepAlert";
            this.lblMStepAlert.Size = new System.Drawing.Size(174, 18);
            this.lblMStepAlert.TabIndex = 2;
            this.lblMStepAlert.Text = "提示：细分范围 1-256";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoReversal2);
            this.panel2.Controls.Add(this.rdoForward2);
            this.panel2.Location = new System.Drawing.Point(22, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 30);
            this.panel2.TabIndex = 7;
            // 
            // rdoReversal2
            // 
            this.rdoReversal2.AutoSize = true;
            this.rdoReversal2.Location = new System.Drawing.Point(101, 5);
            this.rdoReversal2.Name = "rdoReversal2";
            this.rdoReversal2.Size = new System.Drawing.Size(95, 19);
            this.rdoReversal2.TabIndex = 1;
            this.rdoReversal2.Tag = "";
            this.rdoReversal2.Text = "反转(CCW)";
            this.rdoReversal2.UseVisualStyleBackColor = true;
            // 
            // rdoForward2
            // 
            this.rdoForward2.AutoSize = true;
            this.rdoForward2.Checked = true;
            this.rdoForward2.Location = new System.Drawing.Point(12, 5);
            this.rdoForward2.Name = "rdoForward2";
            this.rdoForward2.Size = new System.Drawing.Size(87, 19);
            this.rdoForward2.TabIndex = 0;
            this.rdoForward2.TabStop = true;
            this.rdoForward2.Tag = "";
            this.rdoForward2.Text = "正转(CW)";
            this.rdoForward2.UseVisualStyleBackColor = true;
            // 
            // lblMStep2
            // 
            this.lblMStep2.AutoSize = true;
            this.lblMStep2.Font = new System.Drawing.Font("SimSun", 10F);
            this.lblMStep2.Location = new System.Drawing.Point(16, 32);
            this.lblMStep2.Name = "lblMStep2";
            this.lblMStep2.Size = new System.Drawing.Size(63, 14);
            this.lblMStep2.TabIndex = 0;
            this.lblMStep2.Text = "细分设置";
            // 
            // lblPulseCounterAlert
            // 
            this.lblPulseCounterAlert.Font = new System.Drawing.Font("SimSun", 9F);
            this.lblPulseCounterAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPulseCounterAlert.Location = new System.Drawing.Point(18, 196);
            this.lblPulseCounterAlert.Name = "lblPulseCounterAlert";
            this.lblPulseCounterAlert.Size = new System.Drawing.Size(209, 18);
            this.lblPulseCounterAlert.TabIndex = 6;
            this.lblPulseCounterAlert.Text = "提示：在16细分时，3200脉冲 = 360°";
            // 
            // txtPulseCounter
            // 
            this.txtPulseCounter.Location = new System.Drawing.Point(108, 166);
            this.txtPulseCounter.MaxLength = 65535;
            this.txtPulseCounter.Name = "txtPulseCounter";
            this.txtPulseCounter.Size = new System.Drawing.Size(106, 24);
            this.txtPulseCounter.TabIndex = 5;
            // 
            // lblPulseCounter
            // 
            this.lblPulseCounter.AutoSize = true;
            this.lblPulseCounter.Location = new System.Drawing.Point(16, 169);
            this.lblPulseCounter.Name = "lblPulseCounter";
            this.lblPulseCounter.Size = new System.Drawing.Size(52, 15);
            this.lblPulseCounter.TabIndex = 4;
            this.lblPulseCounter.Text = "脉冲数";
            // 
            // lblSpeedGear2
            // 
            this.lblSpeedGear2.AutoSize = true;
            this.lblSpeedGear2.Location = new System.Drawing.Point(16, 136);
            this.lblSpeedGear2.Name = "lblSpeedGear2";
            this.lblSpeedGear2.Size = new System.Drawing.Size(67, 15);
            this.lblSpeedGear2.TabIndex = 3;
            this.lblSpeedGear2.Text = "速度档位";
            // 
            // cmbSpeedGear2
            // 
            this.cmbSpeedGear2.FormattingEnabled = true;
            this.cmbSpeedGear2.Location = new System.Drawing.Point(108, 134);
            this.cmbSpeedGear2.Name = "cmbSpeedGear2";
            this.cmbSpeedGear2.Size = new System.Drawing.Size(106, 23);
            this.cmbSpeedGear2.TabIndex = 2;
            // 
            // btnEnableBorad
            // 
            this.btnEnableBorad.Location = new System.Drawing.Point(138, 21);
            this.btnEnableBorad.Name = "btnEnableBorad";
            this.btnEnableBorad.Size = new System.Drawing.Size(135, 27);
            this.btnEnableBorad.TabIndex = 1;
            this.btnEnableBorad.Tag = "";
            this.btnEnableBorad.Text = "激活驱动板";
            this.btnEnableBorad.UseVisualStyleBackColor = true;
            this.btnEnableBorad.Click += new System.EventHandler(this.btnEnableBorad_Click);
            // 
            // btnDisenableBorad
            // 
            this.btnDisenableBorad.Location = new System.Drawing.Point(282, 21);
            this.btnDisenableBorad.Name = "btnDisenableBorad";
            this.btnDisenableBorad.Size = new System.Drawing.Size(135, 27);
            this.btnDisenableBorad.TabIndex = 0;
            this.btnDisenableBorad.Tag = "";
            this.btnDisenableBorad.Text = "关闭驱动板";
            this.btnDisenableBorad.UseVisualStyleBackColor = true;
            this.btnDisenableBorad.Click += new System.EventHandler(this.btnDisenableBorad_Click);
            // 
            // grpMotorStart
            // 
            this.grpMotorStart.Controls.Add(this.lblSpeedGearAlert);
            this.grpMotorStart.Controls.Add(this.panel1);
            this.grpMotorStart.Controls.Add(this.btnPowerOnStop);
            this.grpMotorStart.Controls.Add(this.btnPowerOnRun);
            this.grpMotorStart.Controls.Add(this.btnStop);
            this.grpMotorStart.Controls.Add(this.btnStart);
            this.grpMotorStart.Controls.Add(this.cmbSpeedGear);
            this.grpMotorStart.Controls.Add(this.lblSpeedGear);
            this.grpMotorStart.Location = new System.Drawing.Point(15, 68);
            this.grpMotorStart.Name = "grpMotorStart";
            this.grpMotorStart.Size = new System.Drawing.Size(229, 263);
            this.grpMotorStart.TabIndex = 2;
            this.grpMotorStart.TabStop = false;
            this.grpMotorStart.Text = "控制电机正反转";
            // 
            // lblSpeedGearAlert
            // 
            this.lblSpeedGearAlert.AutoSize = true;
            this.lblSpeedGearAlert.Font = new System.Drawing.Font("SimSun", 9F);
            this.lblSpeedGearAlert.Location = new System.Drawing.Point(15, 102);
            this.lblSpeedGearAlert.Name = "lblSpeedGearAlert";
            this.lblSpeedGearAlert.Size = new System.Drawing.Size(149, 12);
            this.lblSpeedGearAlert.TabIndex = 9;
            this.lblSpeedGearAlert.Text = "提示：速度档位范围 0-127";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoReversal);
            this.panel1.Controls.Add(this.rdoForward);
            this.panel1.Location = new System.Drawing.Point(13, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 34);
            this.panel1.TabIndex = 8;
            // 
            // rdoReversal
            // 
            this.rdoReversal.AutoSize = true;
            this.rdoReversal.Location = new System.Drawing.Point(107, 7);
            this.rdoReversal.Name = "rdoReversal";
            this.rdoReversal.Size = new System.Drawing.Size(95, 19);
            this.rdoReversal.TabIndex = 1;
            this.rdoReversal.Tag = "";
            this.rdoReversal.Text = "反转(CCW)";
            this.rdoReversal.UseVisualStyleBackColor = true;
            // 
            // rdoForward
            // 
            this.rdoForward.AutoSize = true;
            this.rdoForward.Checked = true;
            this.rdoForward.Location = new System.Drawing.Point(13, 7);
            this.rdoForward.Name = "rdoForward";
            this.rdoForward.Size = new System.Drawing.Size(87, 19);
            this.rdoForward.TabIndex = 0;
            this.rdoForward.TabStop = true;
            this.rdoForward.Tag = "";
            this.rdoForward.Text = "正转(CW)";
            this.rdoForward.UseVisualStyleBackColor = true;
            // 
            // btnPowerOnStop
            // 
            this.btnPowerOnStop.Location = new System.Drawing.Point(19, 221);
            this.btnPowerOnStop.Name = "btnPowerOnStop";
            this.btnPowerOnStop.Size = new System.Drawing.Size(180, 27);
            this.btnPowerOnStop.TabIndex = 7;
            this.btnPowerOnStop.Tag = "";
            this.btnPowerOnStop.Text = "关闭上电自动运行";
            this.btnPowerOnStop.UseVisualStyleBackColor = true;
            this.btnPowerOnStop.Click += new System.EventHandler(this.btnPowerOnStop_Click);
            // 
            // btnPowerOnRun
            // 
            this.btnPowerOnRun.Location = new System.Drawing.Point(19, 184);
            this.btnPowerOnRun.Name = "btnPowerOnRun";
            this.btnPowerOnRun.Size = new System.Drawing.Size(180, 27);
            this.btnPowerOnRun.TabIndex = 6;
            this.btnPowerOnRun.Tag = "";
            this.btnPowerOnRun.Text = "开启上电自动运行";
            this.btnPowerOnRun.UseVisualStyleBackColor = true;
            this.btnPowerOnRun.Click += new System.EventHandler(this.btnPowerOnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(124, 133);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 24);
            this.btnStop.TabIndex = 5;
            this.btnStop.Tag = "";
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 133);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 24);
            this.btnStart.TabIndex = 4;
            this.btnStart.Tag = "";
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // cmbSpeedGear
            // 
            this.cmbSpeedGear.FormattingEnabled = true;
            this.cmbSpeedGear.Location = new System.Drawing.Point(112, 74);
            this.cmbSpeedGear.Name = "cmbSpeedGear";
            this.cmbSpeedGear.Size = new System.Drawing.Size(89, 23);
            this.cmbSpeedGear.TabIndex = 3;
            // 
            // lblSpeedGear
            // 
            this.lblSpeedGear.AutoSize = true;
            this.lblSpeedGear.Location = new System.Drawing.Point(13, 78);
            this.lblSpeedGear.Name = "lblSpeedGear";
            this.lblSpeedGear.Size = new System.Drawing.Size(67, 15);
            this.lblSpeedGear.TabIndex = 2;
            this.lblSpeedGear.Text = "速度档位";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(258, 35);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(600, 163);
            this.textBox9.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MKS_SERVO42C_CONTROL.Properties.Resources.Negative_side;
            this.pictureBox2.Location = new System.Drawing.Point(491, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MKS_SERVO42C_CONTROL.Properties.Resources._42C_positive_side;
            this.pictureBox1.Location = new System.Drawing.Point(698, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MKS_SERVO42C_CONTROL.Properties.Resources._42C_MOTOR;
            this.pictureBox3.Location = new System.Drawing.Point(284, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 134);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLanguage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1454, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemLanguage
            // 
            this.ToolStripMenuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.中文ToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.ToolStripMenuItemLanguage.Name = "ToolStripMenuItemLanguage";
            this.ToolStripMenuItemLanguage.Size = new System.Drawing.Size(44, 22);
            this.ToolStripMenuItemLanguage.Text = "语言";
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.中文ToolStripMenuItem.Text = "中文";
            this.中文ToolStripMenuItem.Click += new System.EventHandler(this.ChineseToolStripMenuItem_Click_1);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
            // 
            // grpSysSettings
            // 
            this.grpSysSettings.Controls.Add(this.cmbSetMStep);
            this.grpSysSettings.Controls.Add(this.btnSetUartAddr);
            this.grpSysSettings.Controls.Add(this.btnSetUartBaud);
            this.grpSysSettings.Controls.Add(this.btnSetMPlyer);
            this.grpSysSettings.Controls.Add(this.btnSetProtect);
            this.grpSysSettings.Controls.Add(this.btnSetAutoSDD);
            this.grpSysSettings.Controls.Add(this.btnSetDir);
            this.grpSysSettings.Controls.Add(this.btnSetEn);
            this.grpSysSettings.Controls.Add(this.btnSetMa);
            this.grpSysSettings.Controls.Add(this.btnSetCtrMode);
            this.grpSysSettings.Controls.Add(this.btnSetMotType);
            this.grpSysSettings.Controls.Add(this.cmbSetUartAddr);
            this.grpSysSettings.Controls.Add(this.lblSetUartAddr);
            this.grpSysSettings.Controls.Add(this.cmbSetUartBaud);
            this.grpSysSettings.Controls.Add(this.lblSetUartBaud);
            this.grpSysSettings.Controls.Add(this.cmbSetMPlyer);
            this.grpSysSettings.Controls.Add(this.lblSetMPlyer);
            this.grpSysSettings.Controls.Add(this.cmbSetProtect);
            this.grpSysSettings.Controls.Add(this.lblSetProtect);
            this.grpSysSettings.Controls.Add(this.cmbSetAutoSDD);
            this.grpSysSettings.Controls.Add(this.lblSetAutoSDD);
            this.grpSysSettings.Controls.Add(this.cmbSetDir);
            this.grpSysSettings.Controls.Add(this.lblSetDir);
            this.grpSysSettings.Controls.Add(this.cmbSetEn);
            this.grpSysSettings.Controls.Add(this.lblSetEn);
            this.grpSysSettings.Controls.Add(this.btnSetMStep);
            this.grpSysSettings.Controls.Add(this.cmbSetMa);
            this.grpSysSettings.Controls.Add(this.lblMa);
            this.grpSysSettings.Controls.Add(this.cmbSetCtrMode);
            this.grpSysSettings.Controls.Add(this.lblMStep);
            this.grpSysSettings.Controls.Add(this.lblCtrMode);
            this.grpSysSettings.Controls.Add(this.cmbSetMotType);
            this.grpSysSettings.Controls.Add(this.lblMotorType);
            this.grpSysSettings.Controls.Add(this.btnCal);
            this.grpSysSettings.Font = new System.Drawing.Font("SimSun", 11F);
            this.grpSysSettings.Location = new System.Drawing.Point(249, 216);
            this.grpSysSettings.Name = "grpSysSettings";
            this.grpSysSettings.Size = new System.Drawing.Size(311, 444);
            this.grpSysSettings.TabIndex = 14;
            this.grpSysSettings.TabStop = false;
            this.grpSysSettings.Text = "设置系统参数";
            // 
            // cmbSetMStep
            // 
            this.cmbSetMStep.FormattingEnabled = true;
            this.cmbSetMStep.Location = new System.Drawing.Point(104, 168);
            this.cmbSetMStep.Name = "cmbSetMStep";
            this.cmbSetMStep.Size = new System.Drawing.Size(121, 23);
            this.cmbSetMStep.TabIndex = 30;
            // 
            // btnSetUartAddr
            // 
            this.btnSetUartAddr.Location = new System.Drawing.Point(233, 414);
            this.btnSetUartAddr.Name = "btnSetUartAddr";
            this.btnSetUartAddr.Size = new System.Drawing.Size(75, 24);
            this.btnSetUartAddr.TabIndex = 17;
            this.btnSetUartAddr.Tag = "";
            this.btnSetUartAddr.Text = "确认";
            this.btnSetUartAddr.UseVisualStyleBackColor = true;
            this.btnSetUartAddr.Click += new System.EventHandler(this.btnSetUartAddr_Click);
            // 
            // btnSetUartBaud
            // 
            this.btnSetUartBaud.Location = new System.Drawing.Point(233, 378);
            this.btnSetUartBaud.Name = "btnSetUartBaud";
            this.btnSetUartBaud.Size = new System.Drawing.Size(75, 24);
            this.btnSetUartBaud.TabIndex = 29;
            this.btnSetUartBaud.Tag = "";
            this.btnSetUartBaud.Text = "确认";
            this.btnSetUartBaud.UseVisualStyleBackColor = true;
            this.btnSetUartBaud.Click += new System.EventHandler(this.btnSetUartBaud_Click);
            // 
            // btnSetMPlyer
            // 
            this.btnSetMPlyer.Location = new System.Drawing.Point(233, 342);
            this.btnSetMPlyer.Name = "btnSetMPlyer";
            this.btnSetMPlyer.Size = new System.Drawing.Size(75, 24);
            this.btnSetMPlyer.TabIndex = 28;
            this.btnSetMPlyer.Tag = "";
            this.btnSetMPlyer.Text = "确认";
            this.btnSetMPlyer.UseVisualStyleBackColor = true;
            this.btnSetMPlyer.Click += new System.EventHandler(this.btnSetMPlyer_Click);
            // 
            // btnSetProtect
            // 
            this.btnSetProtect.Location = new System.Drawing.Point(233, 307);
            this.btnSetProtect.Name = "btnSetProtect";
            this.btnSetProtect.Size = new System.Drawing.Size(75, 24);
            this.btnSetProtect.TabIndex = 27;
            this.btnSetProtect.Tag = "";
            this.btnSetProtect.Text = "确认";
            this.btnSetProtect.UseVisualStyleBackColor = true;
            this.btnSetProtect.Click += new System.EventHandler(this.btnSetProtect_Click);
            // 
            // btnSetAutoSDD
            // 
            this.btnSetAutoSDD.Location = new System.Drawing.Point(233, 272);
            this.btnSetAutoSDD.Name = "btnSetAutoSDD";
            this.btnSetAutoSDD.Size = new System.Drawing.Size(75, 24);
            this.btnSetAutoSDD.TabIndex = 26;
            this.btnSetAutoSDD.Tag = "";
            this.btnSetAutoSDD.Text = "确认";
            this.btnSetAutoSDD.UseVisualStyleBackColor = true;
            this.btnSetAutoSDD.Click += new System.EventHandler(this.btnSetAutoSDD_Click);
            // 
            // btnSetDir
            // 
            this.btnSetDir.Location = new System.Drawing.Point(233, 236);
            this.btnSetDir.Name = "btnSetDir";
            this.btnSetDir.Size = new System.Drawing.Size(75, 24);
            this.btnSetDir.TabIndex = 25;
            this.btnSetDir.Tag = "";
            this.btnSetDir.Text = "确认";
            this.btnSetDir.UseVisualStyleBackColor = true;
            this.btnSetDir.Click += new System.EventHandler(this.btnSetDir_Click);
            // 
            // btnSetEn
            // 
            this.btnSetEn.Location = new System.Drawing.Point(233, 200);
            this.btnSetEn.Name = "btnSetEn";
            this.btnSetEn.Size = new System.Drawing.Size(75, 24);
            this.btnSetEn.TabIndex = 24;
            this.btnSetEn.Tag = "";
            this.btnSetEn.Text = "确认";
            this.btnSetEn.UseVisualStyleBackColor = true;
            this.btnSetEn.Click += new System.EventHandler(this.btnSetEn_Click);
            // 
            // btnSetMa
            // 
            this.btnSetMa.Location = new System.Drawing.Point(233, 131);
            this.btnSetMa.Name = "btnSetMa";
            this.btnSetMa.Size = new System.Drawing.Size(75, 24);
            this.btnSetMa.TabIndex = 23;
            this.btnSetMa.Tag = "";
            this.btnSetMa.Text = "确认";
            this.btnSetMa.UseVisualStyleBackColor = true;
            this.btnSetMa.Click += new System.EventHandler(this.btnSetMa_Click);
            // 
            // btnSetCtrMode
            // 
            this.btnSetCtrMode.Location = new System.Drawing.Point(233, 96);
            this.btnSetCtrMode.Name = "btnSetCtrMode";
            this.btnSetCtrMode.Size = new System.Drawing.Size(75, 24);
            this.btnSetCtrMode.TabIndex = 22;
            this.btnSetCtrMode.Tag = "";
            this.btnSetCtrMode.Text = "确认";
            this.btnSetCtrMode.UseVisualStyleBackColor = true;
            this.btnSetCtrMode.Click += new System.EventHandler(this.btnSetCtrMode_Click);
            // 
            // btnSetMotType
            // 
            this.btnSetMotType.Location = new System.Drawing.Point(233, 60);
            this.btnSetMotType.Name = "btnSetMotType";
            this.btnSetMotType.Size = new System.Drawing.Size(75, 24);
            this.btnSetMotType.TabIndex = 21;
            this.btnSetMotType.Tag = "";
            this.btnSetMotType.Text = "确认";
            this.btnSetMotType.UseVisualStyleBackColor = true;
            this.btnSetMotType.Click += new System.EventHandler(this.btnSetMotType_Click);
            // 
            // cmbSetUartAddr
            // 
            this.cmbSetUartAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetUartAddr.FormattingEnabled = true;
            this.cmbSetUartAddr.Location = new System.Drawing.Point(104, 416);
            this.cmbSetUartAddr.Name = "cmbSetUartAddr";
            this.cmbSetUartAddr.Size = new System.Drawing.Size(121, 23);
            this.cmbSetUartAddr.TabIndex = 20;
            // 
            // lblSetUartAddr
            // 
            this.lblSetUartAddr.AutoSize = true;
            this.lblSetUartAddr.Location = new System.Drawing.Point(15, 418);
            this.lblSetUartAddr.Name = "lblSetUartAddr";
            this.lblSetUartAddr.Size = new System.Drawing.Size(67, 15);
            this.lblSetUartAddr.TabIndex = 19;
            this.lblSetUartAddr.Text = "通讯地址";
            // 
            // cmbSetUartBaud
            // 
            this.cmbSetUartBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetUartBaud.FormattingEnabled = true;
            this.cmbSetUartBaud.Location = new System.Drawing.Point(104, 381);
            this.cmbSetUartBaud.Name = "cmbSetUartBaud";
            this.cmbSetUartBaud.Size = new System.Drawing.Size(121, 23);
            this.cmbSetUartBaud.TabIndex = 18;
            // 
            // lblSetUartBaud
            // 
            this.lblSetUartBaud.AutoSize = true;
            this.lblSetUartBaud.Location = new System.Drawing.Point(15, 382);
            this.lblSetUartBaud.Name = "lblSetUartBaud";
            this.lblSetUartBaud.Size = new System.Drawing.Size(82, 15);
            this.lblSetUartBaud.TabIndex = 17;
            this.lblSetUartBaud.Text = "串口波特率";
            // 
            // cmbSetMPlyer
            // 
            this.cmbSetMPlyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetMPlyer.FormattingEnabled = true;
            this.cmbSetMPlyer.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.cmbSetMPlyer.Location = new System.Drawing.Point(104, 346);
            this.cmbSetMPlyer.Name = "cmbSetMPlyer";
            this.cmbSetMPlyer.Size = new System.Drawing.Size(121, 23);
            this.cmbSetMPlyer.TabIndex = 16;
            // 
            // lblSetMPlyer
            // 
            this.lblSetMPlyer.AutoSize = true;
            this.lblSetMPlyer.Location = new System.Drawing.Point(15, 347);
            this.lblSetMPlyer.Name = "lblSetMPlyer";
            this.lblSetMPlyer.Size = new System.Drawing.Size(67, 15);
            this.lblSetMPlyer.TabIndex = 15;
            this.lblSetMPlyer.Text = "细分插补";
            // 
            // cmbSetProtect
            // 
            this.cmbSetProtect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetProtect.FormattingEnabled = true;
            this.cmbSetProtect.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.cmbSetProtect.Location = new System.Drawing.Point(104, 310);
            this.cmbSetProtect.Name = "cmbSetProtect";
            this.cmbSetProtect.Size = new System.Drawing.Size(121, 23);
            this.cmbSetProtect.TabIndex = 14;
            // 
            // lblSetProtect
            // 
            this.lblSetProtect.AutoSize = true;
            this.lblSetProtect.Location = new System.Drawing.Point(15, 312);
            this.lblSetProtect.Name = "lblSetProtect";
            this.lblSetProtect.Size = new System.Drawing.Size(67, 15);
            this.lblSetProtect.TabIndex = 13;
            this.lblSetProtect.Text = "堵转保护";
            // 
            // cmbSetAutoSDD
            // 
            this.cmbSetAutoSDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetAutoSDD.FormattingEnabled = true;
            this.cmbSetAutoSDD.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.cmbSetAutoSDD.Location = new System.Drawing.Point(104, 274);
            this.cmbSetAutoSDD.Name = "cmbSetAutoSDD";
            this.cmbSetAutoSDD.Size = new System.Drawing.Size(121, 23);
            this.cmbSetAutoSDD.TabIndex = 12;
            // 
            // lblSetAutoSDD
            // 
            this.lblSetAutoSDD.AutoSize = true;
            this.lblSetAutoSDD.Location = new System.Drawing.Point(15, 276);
            this.lblSetAutoSDD.Name = "lblSetAutoSDD";
            this.lblSetAutoSDD.Size = new System.Drawing.Size(67, 15);
            this.lblSetAutoSDD.TabIndex = 11;
            this.lblSetAutoSDD.Text = "自动息屏";
            // 
            // cmbSetDir
            // 
            this.cmbSetDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetDir.FormattingEnabled = true;
            this.cmbSetDir.Items.AddRange(new object[] {
            "CW",
            "CCW"});
            this.cmbSetDir.Location = new System.Drawing.Point(104, 239);
            this.cmbSetDir.Name = "cmbSetDir";
            this.cmbSetDir.Size = new System.Drawing.Size(121, 23);
            this.cmbSetDir.TabIndex = 10;
            // 
            // lblSetDir
            // 
            this.lblSetDir.AutoSize = true;
            this.lblSetDir.Location = new System.Drawing.Point(15, 240);
            this.lblSetDir.Name = "lblSetDir";
            this.lblSetDir.Size = new System.Drawing.Size(67, 15);
            this.lblSetDir.TabIndex = 9;
            this.lblSetDir.Text = "电机方向";
            // 
            // cmbSetEn
            // 
            this.cmbSetEn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetEn.FormattingEnabled = true;
            this.cmbSetEn.Items.AddRange(new object[] {
            "L",
            "H",
            "Hold"});
            this.cmbSetEn.Location = new System.Drawing.Point(104, 204);
            this.cmbSetEn.Name = "cmbSetEn";
            this.cmbSetEn.Size = new System.Drawing.Size(121, 23);
            this.cmbSetEn.TabIndex = 8;
            // 
            // lblSetEn
            // 
            this.lblSetEn.AutoSize = true;
            this.lblSetEn.Location = new System.Drawing.Point(15, 205);
            this.lblSetEn.Name = "lblSetEn";
            this.lblSetEn.Size = new System.Drawing.Size(67, 15);
            this.lblSetEn.TabIndex = 7;
            this.lblSetEn.Text = "使能设置";
            // 
            // cmbSetMa
            // 
            this.cmbSetMa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetMa.FormattingEnabled = true;
            this.cmbSetMa.Location = new System.Drawing.Point(104, 134);
            this.cmbSetMa.Name = "cmbSetMa";
            this.cmbSetMa.Size = new System.Drawing.Size(121, 23);
            this.cmbSetMa.TabIndex = 6;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(15, 136);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(84, 15);
            this.lblMa.TabIndex = 5;
            this.lblMa.Text = "电流值(mA)";
            // 
            // cmbSetCtrMode
            // 
            this.cmbSetCtrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetCtrMode.FormattingEnabled = true;
            this.cmbSetCtrMode.Items.AddRange(new object[] {
            "CR_OPEN",
            "CR_vFOC",
            "CR_UART"});
            this.cmbSetCtrMode.Location = new System.Drawing.Point(104, 98);
            this.cmbSetCtrMode.Name = "cmbSetCtrMode";
            this.cmbSetCtrMode.Size = new System.Drawing.Size(121, 23);
            this.cmbSetCtrMode.TabIndex = 4;
            // 
            // lblCtrMode
            // 
            this.lblCtrMode.AutoSize = true;
            this.lblCtrMode.Location = new System.Drawing.Point(15, 100);
            this.lblCtrMode.Name = "lblCtrMode";
            this.lblCtrMode.Size = new System.Drawing.Size(67, 15);
            this.lblCtrMode.TabIndex = 3;
            this.lblCtrMode.Text = "工作模式";
            // 
            // cmbSetMotType
            // 
            this.cmbSetMotType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetMotType.FormattingEnabled = true;
            this.cmbSetMotType.Items.AddRange(new object[] {
            "0.9°",
            "1.8°"});
            this.cmbSetMotType.Location = new System.Drawing.Point(104, 63);
            this.cmbSetMotType.Name = "cmbSetMotType";
            this.cmbSetMotType.Size = new System.Drawing.Size(121, 23);
            this.cmbSetMotType.TabIndex = 2;
            // 
            // lblMotorType
            // 
            this.lblMotorType.AutoSize = true;
            this.lblMotorType.Location = new System.Drawing.Point(15, 64);
            this.lblMotorType.Name = "lblMotorType";
            this.lblMotorType.Size = new System.Drawing.Size(67, 15);
            this.lblMotorType.TabIndex = 1;
            this.lblMotorType.Text = "电机类型";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(96, 21);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(135, 30);
            this.btnCal.TabIndex = 0;
            this.btnCal.Tag = "";
            this.btnCal.Text = "校准";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // grpPID
            // 
            this.grpPID.Controls.Add(this.grpMaxT);
            this.grpPID.Controls.Add(this.grpAcceleration);
            this.grpPID.Controls.Add(this.grpPIDSettings);
            this.grpPID.Controls.Add(this.label20);
            this.grpPID.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpPID.ForeColor = System.Drawing.Color.Red;
            this.grpPID.Location = new System.Drawing.Point(581, 216);
            this.grpPID.Name = "grpPID";
            this.grpPID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpPID.Size = new System.Drawing.Size(312, 444);
            this.grpPID.TabIndex = 15;
            this.grpPID.TabStop = false;
            this.grpPID.Text = "设置PID/加速度/扭矩参数";
            // 
            // grpMaxT
            // 
            this.grpMaxT.Controls.Add(this.btnSetMaxT);
            this.grpMaxT.Controls.Add(this.cmbSetMaxT);
            this.grpMaxT.Controls.Add(this.lblSetMaxT);
            this.grpMaxT.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpMaxT.Location = new System.Drawing.Point(9, 340);
            this.grpMaxT.Name = "grpMaxT";
            this.grpMaxT.Size = new System.Drawing.Size(296, 72);
            this.grpMaxT.TabIndex = 9;
            this.grpMaxT.TabStop = false;
            this.grpMaxT.Text = "最大扭矩";
            // 
            // btnSetMaxT
            // 
            this.btnSetMaxT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetMaxT.Location = new System.Drawing.Point(214, 31);
            this.btnSetMaxT.Name = "btnSetMaxT";
            this.btnSetMaxT.Size = new System.Drawing.Size(75, 24);
            this.btnSetMaxT.TabIndex = 18;
            this.btnSetMaxT.Tag = "";
            this.btnSetMaxT.Text = "确认";
            this.btnSetMaxT.UseVisualStyleBackColor = true;
            this.btnSetMaxT.Click += new System.EventHandler(this.btnSetMaxT_Click);
            // 
            // cmbSetMaxT
            // 
            this.cmbSetMaxT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbSetMaxT.FormattingEnabled = true;
            this.cmbSetMaxT.Items.AddRange(new object[] {
            "1200"});
            this.cmbSetMaxT.Location = new System.Drawing.Point(87, 31);
            this.cmbSetMaxT.Name = "cmbSetMaxT";
            this.cmbSetMaxT.Size = new System.Drawing.Size(121, 23);
            this.cmbSetMaxT.TabIndex = 1;
            // 
            // lblSetMaxT
            // 
            this.lblSetMaxT.AutoSize = true;
            this.lblSetMaxT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSetMaxT.Location = new System.Drawing.Point(44, 33);
            this.lblSetMaxT.Name = "lblSetMaxT";
            this.lblSetMaxT.Size = new System.Drawing.Size(37, 15);
            this.lblSetMaxT.TabIndex = 0;
            this.lblSetMaxT.Text = "扭矩";
            // 
            // grpAcceleration
            // 
            this.grpAcceleration.Controls.Add(this.btnSetACC);
            this.grpAcceleration.Controls.Add(this.cmbSetACC);
            this.grpAcceleration.Controls.Add(this.label24);
            this.grpAcceleration.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpAcceleration.Location = new System.Drawing.Point(9, 243);
            this.grpAcceleration.Name = "grpAcceleration";
            this.grpAcceleration.Size = new System.Drawing.Size(296, 74);
            this.grpAcceleration.TabIndex = 8;
            this.grpAcceleration.TabStop = false;
            this.grpAcceleration.Text = "加速度参数";
            // 
            // btnSetACC
            // 
            this.btnSetACC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetACC.Location = new System.Drawing.Point(214, 34);
            this.btnSetACC.Name = "btnSetACC";
            this.btnSetACC.Size = new System.Drawing.Size(75, 24);
            this.btnSetACC.TabIndex = 18;
            this.btnSetACC.Tag = "";
            this.btnSetACC.Text = "确认";
            this.btnSetACC.UseVisualStyleBackColor = true;
            this.btnSetACC.Click += new System.EventHandler(this.btnSetACC_Click);
            // 
            // cmbSetACC
            // 
            this.cmbSetACC.FormattingEnabled = true;
            this.cmbSetACC.Items.AddRange(new object[] {
            "286"});
            this.cmbSetACC.Location = new System.Drawing.Point(87, 34);
            this.cmbSetACC.Name = "cmbSetACC";
            this.cmbSetACC.Size = new System.Drawing.Size(121, 23);
            this.cmbSetACC.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(28, 36);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 15);
            this.label24.TabIndex = 0;
            this.label24.Text = "加速度";
            // 
            // grpPIDSettings
            // 
            this.grpPIDSettings.Controls.Add(this.btnSetKD);
            this.grpPIDSettings.Controls.Add(this.btnSetKI);
            this.grpPIDSettings.Controls.Add(this.btnSetKP);
            this.grpPIDSettings.Controls.Add(this.lblSetKP);
            this.grpPIDSettings.Controls.Add(this.cmbSetKD);
            this.grpPIDSettings.Controls.Add(this.lblSetKI);
            this.grpPIDSettings.Controls.Add(this.cmbSetKI);
            this.grpPIDSettings.Controls.Add(this.lblSetKD);
            this.grpPIDSettings.Controls.Add(this.cmbSetKP);
            this.grpPIDSettings.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpPIDSettings.Location = new System.Drawing.Point(9, 88);
            this.grpPIDSettings.Name = "grpPIDSettings";
            this.grpPIDSettings.Size = new System.Drawing.Size(296, 135);
            this.grpPIDSettings.TabIndex = 7;
            this.grpPIDSettings.TabStop = false;
            this.grpPIDSettings.Text = "PID参数";
            // 
            // btnSetKD
            // 
            this.btnSetKD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetKD.Location = new System.Drawing.Point(214, 98);
            this.btnSetKD.Name = "btnSetKD";
            this.btnSetKD.Size = new System.Drawing.Size(75, 24);
            this.btnSetKD.TabIndex = 19;
            this.btnSetKD.Tag = "";
            this.btnSetKD.Text = "确认";
            this.btnSetKD.UseVisualStyleBackColor = true;
            this.btnSetKD.Click += new System.EventHandler(this.btnSetKD_Click);
            // 
            // btnSetKI
            // 
            this.btnSetKI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetKI.Location = new System.Drawing.Point(214, 63);
            this.btnSetKI.Name = "btnSetKI";
            this.btnSetKI.Size = new System.Drawing.Size(75, 24);
            this.btnSetKI.TabIndex = 18;
            this.btnSetKI.Tag = "";
            this.btnSetKI.Text = "确认";
            this.btnSetKI.UseVisualStyleBackColor = true;
            this.btnSetKI.Click += new System.EventHandler(this.btnSetKI_Click);
            // 
            // btnSetKP
            // 
            this.btnSetKP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetKP.Location = new System.Drawing.Point(214, 28);
            this.btnSetKP.Name = "btnSetKP";
            this.btnSetKP.Size = new System.Drawing.Size(75, 24);
            this.btnSetKP.TabIndex = 17;
            this.btnSetKP.Tag = "";
            this.btnSetKP.Text = "确认";
            this.btnSetKP.UseVisualStyleBackColor = true;
            this.btnSetKP.Click += new System.EventHandler(this.btnSetKP_Click);
            // 
            // lblSetKP
            // 
            this.lblSetKP.AutoSize = true;
            this.lblSetKP.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSetKP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSetKP.Location = new System.Drawing.Point(28, 30);
            this.lblSetKP.Name = "lblSetKP";
            this.lblSetKP.Size = new System.Drawing.Size(53, 15);
            this.lblSetKP.TabIndex = 1;
            this.lblSetKP.Text = "位置Kp";
            // 
            // cmbSetKD
            // 
            this.cmbSetKD.FormattingEnabled = true;
            this.cmbSetKD.Items.AddRange(new object[] {
            "1616"});
            this.cmbSetKD.Location = new System.Drawing.Point(87, 98);
            this.cmbSetKD.Name = "cmbSetKD";
            this.cmbSetKD.Size = new System.Drawing.Size(121, 23);
            this.cmbSetKD.TabIndex = 6;
            // 
            // lblSetKI
            // 
            this.lblSetKI.AutoSize = true;
            this.lblSetKI.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSetKI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSetKI.Location = new System.Drawing.Point(28, 65);
            this.lblSetKI.Name = "lblSetKI";
            this.lblSetKI.Size = new System.Drawing.Size(53, 15);
            this.lblSetKI.TabIndex = 3;
            this.lblSetKI.Text = "位置Ki";
            // 
            // cmbSetKI
            // 
            this.cmbSetKI.FormattingEnabled = true;
            this.cmbSetKI.Items.AddRange(new object[] {
            "1"});
            this.cmbSetKI.Location = new System.Drawing.Point(87, 63);
            this.cmbSetKI.Name = "cmbSetKI";
            this.cmbSetKI.Size = new System.Drawing.Size(121, 23);
            this.cmbSetKI.TabIndex = 4;
            // 
            // lblSetKD
            // 
            this.lblSetKD.AutoSize = true;
            this.lblSetKD.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSetKD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSetKD.Location = new System.Drawing.Point(28, 100);
            this.lblSetKD.Name = "lblSetKD";
            this.lblSetKD.Size = new System.Drawing.Size(53, 15);
            this.lblSetKD.TabIndex = 5;
            this.lblSetKD.Text = "位置Kd";
            // 
            // cmbSetKP
            // 
            this.cmbSetKP.FormattingEnabled = true;
            this.cmbSetKP.Items.AddRange(new object[] {
            "1616"});
            this.cmbSetKP.Location = new System.Drawing.Point(87, 28);
            this.cmbSetKP.Name = "cmbSetKP";
            this.cmbSetKP.Size = new System.Drawing.Size(121, 23);
            this.cmbSetKP.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(18, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(280, 52);
            this.label20.TabIndex = 0;
            this.label20.Text = "注意:此处的参数设置不当，可能会损坏主板，请谨慎设置，如果不确定，请不要修改。\r\n";
            // 
            // grpSetZeroParameters
            // 
            this.grpSetZeroParameters.Controls.Add(this.buttonGotoZeroPos);
            this.grpSetZeroParameters.Controls.Add(this.btnSetZeroDir);
            this.grpSetZeroParameters.Controls.Add(this.panel5);
            this.grpSetZeroParameters.Controls.Add(this.lblZeroDir);
            this.grpSetZeroParameters.Controls.Add(this.btnSetZeroSpeed);
            this.grpSetZeroParameters.Controls.Add(this.cmbZeroSpeed);
            this.grpSetZeroParameters.Controls.Add(this.lblZeroSpeed);
            this.grpSetZeroParameters.Controls.Add(this.btnSetZeroPos);
            this.grpSetZeroParameters.Controls.Add(this.lblSetZeroPosition);
            this.grpSetZeroParameters.Controls.Add(this.btnDisableZeroMode);
            this.grpSetZeroParameters.Controls.Add(this.btnEnableZeroMode);
            this.grpSetZeroParameters.Controls.Add(this.panel4);
            this.grpSetZeroParameters.Controls.Add(this.lblZeroMode);
            this.grpSetZeroParameters.Font = new System.Drawing.Font("SimSun", 11F);
            this.grpSetZeroParameters.Location = new System.Drawing.Point(923, 88);
            this.grpSetZeroParameters.Name = "grpSetZeroParameters";
            this.grpSetZeroParameters.Size = new System.Drawing.Size(515, 214);
            this.grpSetZeroParameters.TabIndex = 16;
            this.grpSetZeroParameters.TabStop = false;
            this.grpSetZeroParameters.Text = "设置自动回零";
            // 
            // buttonGotoZeroPos
            // 
            this.buttonGotoZeroPos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGotoZeroPos.Location = new System.Drawing.Point(138, 178);
            this.buttonGotoZeroPos.Name = "buttonGotoZeroPos";
            this.buttonGotoZeroPos.Size = new System.Drawing.Size(135, 27);
            this.buttonGotoZeroPos.TabIndex = 28;
            this.buttonGotoZeroPos.Tag = "";
            this.buttonGotoZeroPos.Text = "返回零点";
            this.buttonGotoZeroPos.UseVisualStyleBackColor = true;
            this.buttonGotoZeroPos.Click += new System.EventHandler(this.buttonGotoZeroPos_Click);
            // 
            // btnSetZeroDir
            // 
            this.btnSetZeroDir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetZeroDir.Location = new System.Drawing.Point(322, 146);
            this.btnSetZeroDir.Name = "btnSetZeroDir";
            this.btnSetZeroDir.Size = new System.Drawing.Size(75, 24);
            this.btnSetZeroDir.TabIndex = 27;
            this.btnSetZeroDir.Tag = "";
            this.btnSetZeroDir.Text = "确认";
            this.btnSetZeroDir.UseVisualStyleBackColor = true;
            this.btnSetZeroDir.Click += new System.EventHandler(this.btnSetZeroDir_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rdoZeroReversal);
            this.panel5.Controls.Add(this.rdoZeroForward);
            this.panel5.Location = new System.Drawing.Point(97, 139);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 32);
            this.panel5.TabIndex = 26;
            // 
            // rdoZeroReversal
            // 
            this.rdoZeroReversal.AutoSize = true;
            this.rdoZeroReversal.Location = new System.Drawing.Point(100, 9);
            this.rdoZeroReversal.Name = "rdoZeroReversal";
            this.rdoZeroReversal.Size = new System.Drawing.Size(95, 19);
            this.rdoZeroReversal.TabIndex = 1;
            this.rdoZeroReversal.Tag = "";
            this.rdoZeroReversal.Text = "反转(CCW)";
            this.rdoZeroReversal.UseVisualStyleBackColor = true;
            // 
            // rdoZeroForward
            // 
            this.rdoZeroForward.AutoSize = true;
            this.rdoZeroForward.Checked = true;
            this.rdoZeroForward.Location = new System.Drawing.Point(4, 9);
            this.rdoZeroForward.Name = "rdoZeroForward";
            this.rdoZeroForward.Size = new System.Drawing.Size(87, 19);
            this.rdoZeroForward.TabIndex = 0;
            this.rdoZeroForward.TabStop = true;
            this.rdoZeroForward.Tag = "";
            this.rdoZeroForward.Text = "正转(CW)";
            this.rdoZeroForward.UseVisualStyleBackColor = true;
            // 
            // lblZeroDir
            // 
            this.lblZeroDir.AutoSize = true;
            this.lblZeroDir.Location = new System.Drawing.Point(10, 150);
            this.lblZeroDir.Name = "lblZeroDir";
            this.lblZeroDir.Size = new System.Drawing.Size(67, 15);
            this.lblZeroDir.TabIndex = 25;
            this.lblZeroDir.Text = "回零方向";
            // 
            // btnSetZeroSpeed
            // 
            this.btnSetZeroSpeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetZeroSpeed.Location = new System.Drawing.Point(322, 104);
            this.btnSetZeroSpeed.Name = "btnSetZeroSpeed";
            this.btnSetZeroSpeed.Size = new System.Drawing.Size(75, 24);
            this.btnSetZeroSpeed.TabIndex = 24;
            this.btnSetZeroSpeed.Tag = "";
            this.btnSetZeroSpeed.Text = "确认";
            this.btnSetZeroSpeed.UseVisualStyleBackColor = true;
            this.btnSetZeroSpeed.Click += new System.EventHandler(this.btnSetZeroSpeed_Click);
            // 
            // cmbZeroSpeed
            // 
            this.cmbZeroSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZeroSpeed.FormattingEnabled = true;
            this.cmbZeroSpeed.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbZeroSpeed.Location = new System.Drawing.Point(97, 107);
            this.cmbZeroSpeed.Name = "cmbZeroSpeed";
            this.cmbZeroSpeed.Size = new System.Drawing.Size(137, 23);
            this.cmbZeroSpeed.TabIndex = 23;
            // 
            // lblZeroSpeed
            // 
            this.lblZeroSpeed.AutoSize = true;
            this.lblZeroSpeed.Location = new System.Drawing.Point(10, 108);
            this.lblZeroSpeed.Name = "lblZeroSpeed";
            this.lblZeroSpeed.Size = new System.Drawing.Size(67, 15);
            this.lblZeroSpeed.TabIndex = 22;
            this.lblZeroSpeed.Text = "回零速度";
            // 
            // btnSetZeroPos
            // 
            this.btnSetZeroPos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetZeroPos.Location = new System.Drawing.Point(418, 71);
            this.btnSetZeroPos.Name = "btnSetZeroPos";
            this.btnSetZeroPos.Size = new System.Drawing.Size(75, 24);
            this.btnSetZeroPos.TabIndex = 21;
            this.btnSetZeroPos.Tag = "";
            this.btnSetZeroPos.Text = "确认";
            this.btnSetZeroPos.UseVisualStyleBackColor = true;
            this.btnSetZeroPos.Click += new System.EventHandler(this.btnSetZeroPos_Click);
            // 
            // lblSetZeroPosition
            // 
            this.lblSetZeroPosition.Location = new System.Drawing.Point(10, 66);
            this.lblSetZeroPosition.Name = "lblSetZeroPosition";
            this.lblSetZeroPosition.Size = new System.Drawing.Size(397, 31);
            this.lblSetZeroPosition.TabIndex = 20;
            this.lblSetZeroPosition.Text = "请手动将电机轴转至需要设置的零点位置，然后点击确认。";
            this.lblSetZeroPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDisableZeroMode
            // 
            this.btnDisableZeroMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDisableZeroMode.Location = new System.Drawing.Point(418, 28);
            this.btnDisableZeroMode.Name = "btnDisableZeroMode";
            this.btnDisableZeroMode.Size = new System.Drawing.Size(75, 24);
            this.btnDisableZeroMode.TabIndex = 19;
            this.btnDisableZeroMode.Tag = "";
            this.btnDisableZeroMode.Text = "关闭";
            this.btnDisableZeroMode.UseVisualStyleBackColor = true;
            this.btnDisableZeroMode.Click += new System.EventHandler(this.btnDisableZeroMode_Click);
            // 
            // btnEnableZeroMode
            // 
            this.btnEnableZeroMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnableZeroMode.Location = new System.Drawing.Point(322, 26);
            this.btnEnableZeroMode.Name = "btnEnableZeroMode";
            this.btnEnableZeroMode.Size = new System.Drawing.Size(75, 24);
            this.btnEnableZeroMode.TabIndex = 18;
            this.btnEnableZeroMode.Tag = "";
            this.btnEnableZeroMode.Text = "开启";
            this.btnEnableZeroMode.UseVisualStyleBackColor = true;
            this.btnEnableZeroMode.Click += new System.EventHandler(this.btnEnableZeroMode_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdoNearMode);
            this.panel4.Controls.Add(this.rdoDirMode);
            this.panel4.Location = new System.Drawing.Point(97, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 32);
            this.panel4.TabIndex = 2;
            // 
            // rdoNearMode
            // 
            this.rdoNearMode.AutoSize = true;
            this.rdoNearMode.Location = new System.Drawing.Point(100, 8);
            this.rdoNearMode.Name = "rdoNearMode";
            this.rdoNearMode.Size = new System.Drawing.Size(85, 19);
            this.rdoNearMode.TabIndex = 2;
            this.rdoNearMode.Text = "就近模式";
            this.rdoNearMode.UseVisualStyleBackColor = true;
            // 
            // rdoDirMode
            // 
            this.rdoDirMode.AutoSize = true;
            this.rdoDirMode.Checked = true;
            this.rdoDirMode.Location = new System.Drawing.Point(4, 8);
            this.rdoDirMode.Name = "rdoDirMode";
            this.rdoDirMode.Size = new System.Drawing.Size(85, 19);
            this.rdoDirMode.TabIndex = 1;
            this.rdoDirMode.TabStop = true;
            this.rdoDirMode.Text = "方向模式";
            this.rdoDirMode.UseVisualStyleBackColor = true;
            // 
            // lblZeroMode
            // 
            this.lblZeroMode.AutoSize = true;
            this.lblZeroMode.Location = new System.Drawing.Point(10, 31);
            this.lblZeroMode.Name = "lblZeroMode";
            this.lblZeroMode.Size = new System.Drawing.Size(67, 15);
            this.lblZeroMode.TabIndex = 0;
            this.lblZeroMode.Text = "回零模式";
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRestore.Location = new System.Drawing.Point(1020, 27);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(276, 30);
            this.btnRestore.TabIndex = 17;
            this.btnRestore.Tag = "";
            this.btnRestore.Text = "恢复出厂配置";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblRestore
            // 
            this.lblRestore.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRestore.Location = new System.Drawing.Point(923, 61);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(489, 22);
            this.lblRestore.TabIndex = 18;
            this.lblRestore.Text = "注意：点击“恢复出厂设置”后需要重新上电。";
            this.lblRestore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtxCmdDisplay
            // 
            this.rtxCmdDisplay.Location = new System.Drawing.Point(9, 670);
            this.rtxCmdDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.rtxCmdDisplay.Name = "rtxCmdDisplay";
            this.rtxCmdDisplay.ReadOnly = true;
            this.rtxCmdDisplay.Size = new System.Drawing.Size(1320, 150);
            this.rtxCmdDisplay.TabIndex = 19;
            this.rtxCmdDisplay.Text = "";
            // 
            // btnClearDisplay
            // 
            this.btnClearDisplay.Font = new System.Drawing.Font("SimSun", 11F);
            this.btnClearDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearDisplay.Location = new System.Drawing.Point(1341, 670);
            this.btnClearDisplay.Name = "btnClearDisplay";
            this.btnClearDisplay.Size = new System.Drawing.Size(82, 27);
            this.btnClearDisplay.TabIndex = 9;
            this.btnClearDisplay.Tag = "";
            this.btnClearDisplay.Text = "清除";
            this.btnClearDisplay.UseVisualStyleBackColor = true;
            this.btnClearDisplay.Click += new System.EventHandler(this.btnClearDisplay_Click);
            // 
            // btnSwing
            // 
            this.btnSwing.Font = new System.Drawing.Font("SimSun", 11F);
            this.btnSwing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSwing.Location = new System.Drawing.Point(1341, 703);
            this.btnSwing.Name = "btnSwing";
            this.btnSwing.Size = new System.Drawing.Size(82, 27);
            this.btnSwing.TabIndex = 20;
            this.btnSwing.Tag = "";
            this.btnSwing.Text = "震荡";
            this.btnSwing.UseVisualStyleBackColor = true;
            this.btnSwing.Click += new System.EventHandler(this.btnSwing_Click);
            // 
            // btnStopSWing
            // 
            this.btnStopSWing.Font = new System.Drawing.Font("SimSun", 11F);
            this.btnStopSWing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStopSWing.Location = new System.Drawing.Point(1341, 736);
            this.btnStopSWing.Name = "btnStopSWing";
            this.btnStopSWing.Size = new System.Drawing.Size(82, 27);
            this.btnStopSWing.TabIndex = 21;
            this.btnStopSWing.Tag = "";
            this.btnStopSWing.Text = "停止";
            this.btnStopSWing.UseVisualStyleBackColor = true;
            this.btnStopSWing.Click += new System.EventHandler(this.btnStopSWing_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1454, 831);
            this.Controls.Add(this.btnStopSWing);
            this.Controls.Add(this.btnSwing);
            this.Controls.Add(this.rtxCmdDisplay);
            this.Controls.Add(this.lblRestore);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnClearDisplay);
            this.Controls.Add(this.grpSetZeroParameters);
            this.Controls.Add(this.grpPID);
            this.Controls.Add(this.grpSysSettings);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.grpMotorContorl);
            this.Controls.Add(this.grpReadParameters);
            this.Controls.Add(this.grpLinkSetings);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "MKS SERVO42C CONTROL V1.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpLinkSetings.ResumeLayout(false);
            this.grpLinkSetings.PerformLayout();
            this.grpReadParameters.ResumeLayout(false);
            this.grpReadParameters.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpMotorContorl.ResumeLayout(false);
            this.grpMotorPosition.ResumeLayout(false);
            this.grpMotorPosition.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpMotorStart.ResumeLayout(false);
            this.grpMotorStart.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSysSettings.ResumeLayout(false);
            this.grpSysSettings.PerformLayout();
            this.grpPID.ResumeLayout(false);
            this.grpMaxT.ResumeLayout(false);
            this.grpMaxT.PerformLayout();
            this.grpAcceleration.ResumeLayout(false);
            this.grpAcceleration.PerformLayout();
            this.grpPIDSettings.ResumeLayout(false);
            this.grpPIDSettings.PerformLayout();
            this.grpSetZeroParameters.ResumeLayout(false);
            this.grpSetZeroParameters.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.GroupBox grpLinkSetings;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.ComboBox cmbComName;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.GroupBox grpReadParameters;
        private System.Windows.Forms.Button btnEncoderVal;
        private System.Windows.Forms.TextBox txtLockedFlag;
        private System.Windows.Forms.TextBox txtBoardStatus;
        private System.Windows.Forms.TextBox txtAngleError;
        private System.Windows.Forms.Button btnLockedFlag;
        private System.Windows.Forms.TextBox txtMotorPosition;
        private System.Windows.Forms.TextBox txtTotalPulse;
        private System.Windows.Forms.TextBox txtEncodeVal;
        private System.Windows.Forms.Button btnBoardStatus;
        private System.Windows.Forms.Button btnAngleError;
        private System.Windows.Forms.Button btnMotorPosition;
        private System.Windows.Forms.Button btnTotalPulseCounter;
        private System.Windows.Forms.Label lblMStep;
        private System.Windows.Forms.GroupBox grpMotorContorl;
        private System.Windows.Forms.GroupBox grpMotorStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbSpeedGear;
        private System.Windows.Forms.Label lblSpeedGear;
        private System.Windows.Forms.Button btnEnableBorad;
        private System.Windows.Forms.Button btnDisenableBorad;
        private System.Windows.Forms.Button btnPowerOnRun;
        private System.Windows.Forms.GroupBox grpMotorPosition;
        private System.Windows.Forms.Label lblPulseCounterAlert;
        private System.Windows.Forms.TextBox txtPulseCounter;
        private System.Windows.Forms.Label lblPulseCounter;
        private System.Windows.Forms.Label lblSpeedGear2;
        private System.Windows.Forms.ComboBox cmbSpeedGear2;
        private System.Windows.Forms.Button btnPowerOnStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoForward;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoReversal2;
        private System.Windows.Forms.RadioButton rdoForward2;
        private System.Windows.Forms.RadioButton rdoReversal;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.Button btnScanCom;
        private System.Windows.Forms.ComboBox cmbMotorAddr;
        private System.Windows.Forms.Label lblMotorAddr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSetMStep;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdoHex;
        private System.Windows.Forms.RadioButton rdoDec;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblSpeedGearAlert;
        private System.Windows.Forms.Button btnCloseCom;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLanguage;
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSysSettings;
        private System.Windows.Forms.Label lblMotorType;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.ComboBox cmbSetMotType;
        private System.Windows.Forms.ComboBox cmbSetCtrMode;
        private System.Windows.Forms.Label lblCtrMode;
        private System.Windows.Forms.ComboBox cmbSetMa;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.ComboBox cmbSetUartAddr;
        private System.Windows.Forms.Label lblSetUartAddr;
        private System.Windows.Forms.ComboBox cmbSetUartBaud;
        private System.Windows.Forms.Label lblSetUartBaud;
        private System.Windows.Forms.ComboBox cmbSetMPlyer;
        private System.Windows.Forms.Label lblSetMPlyer;
        private System.Windows.Forms.ComboBox cmbSetProtect;
        private System.Windows.Forms.Label lblSetProtect;
        private System.Windows.Forms.ComboBox cmbSetAutoSDD;
        private System.Windows.Forms.Label lblSetAutoSDD;
        private System.Windows.Forms.ComboBox cmbSetDir;
        private System.Windows.Forms.Label lblSetDir;
        private System.Windows.Forms.ComboBox cmbSetEn;
        private System.Windows.Forms.Label lblSetEn;
        private System.Windows.Forms.GroupBox grpPID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox grpMaxT;
        private System.Windows.Forms.Label lblSetMaxT;
        private System.Windows.Forms.GroupBox grpAcceleration;
        private System.Windows.Forms.ComboBox cmbSetACC;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox grpPIDSettings;
        private System.Windows.Forms.Label lblSetKP;
        private System.Windows.Forms.ComboBox cmbSetKD;
        private System.Windows.Forms.Label lblSetKI;
        private System.Windows.Forms.ComboBox cmbSetKI;
        private System.Windows.Forms.Label lblSetKD;
        private System.Windows.Forms.ComboBox cmbSetKP;
        private System.Windows.Forms.Button btnSetUartAddr;
        private System.Windows.Forms.Button btnSetUartBaud;
        private System.Windows.Forms.Button btnSetMPlyer;
        private System.Windows.Forms.Button btnSetProtect;
        private System.Windows.Forms.Button btnSetAutoSDD;
        private System.Windows.Forms.Button btnSetDir;
        private System.Windows.Forms.Button btnSetEn;
        private System.Windows.Forms.Button btnSetMa;
        private System.Windows.Forms.Button btnSetCtrMode;
        private System.Windows.Forms.Button btnSetMotType;
        private System.Windows.Forms.Button btnSetMaxT;
        private System.Windows.Forms.ComboBox cmbSetMaxT;
        private System.Windows.Forms.Button btnSetACC;
        private System.Windows.Forms.Button btnSetKD;
        private System.Windows.Forms.Button btnSetKI;
        private System.Windows.Forms.Button btnSetKP;
        private System.Windows.Forms.GroupBox grpSetZeroParameters;
        private System.Windows.Forms.Button buttonGotoZeroPos;
        private System.Windows.Forms.Button btnSetZeroDir;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdoZeroReversal;
        private System.Windows.Forms.RadioButton rdoZeroForward;
        private System.Windows.Forms.Label lblZeroDir;
        private System.Windows.Forms.Button btnSetZeroSpeed;
        private System.Windows.Forms.ComboBox cmbZeroSpeed;
        private System.Windows.Forms.Label lblZeroSpeed;
        private System.Windows.Forms.Button btnSetZeroPos;
        private System.Windows.Forms.Label lblSetZeroPosition;
        private System.Windows.Forms.Button btnDisableZeroMode;
        private System.Windows.Forms.Button btnEnableZeroMode;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdoNearMode;
        private System.Windows.Forms.RadioButton rdoDirMode;
        private System.Windows.Forms.Label lblZeroMode;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lblRestore;
        private System.Windows.Forms.ComboBox cmbSetMStep;
        private System.Windows.Forms.Button btnMStep2;
        private System.Windows.Forms.Label lblMStepAlert;
        private System.Windows.Forms.Label lblMStep2;
        private System.Windows.Forms.ComboBox cmbMStep2;
        private System.Windows.Forms.RichTextBox rtxCmdDisplay;
        private System.Windows.Forms.Button btnClearDisplay;
        private System.Windows.Forms.Button btnSwing;
        private System.Windows.Forms.Button btnStopSWing;
    }
}

