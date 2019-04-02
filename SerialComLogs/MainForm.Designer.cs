namespace SerialComLogs
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCarriage2 = new System.Windows.Forms.CheckBox();
            this.chkCarriage1 = new System.Windows.Forms.CheckBox();
            this.lb_Port1_send = new System.Windows.Forms.Label();
            this.lb_Port1_rcv = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbINTERVAL = new System.Windows.Forms.TextBox();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.rbAUTO2 = new System.Windows.Forms.RadioButton();
            this.rbAUTO1 = new System.Windows.Forms.RadioButton();
            this.cbTXHEX2 = new System.Windows.Forms.ComboBox();
            this.tbSEND2 = new System.Windows.Forms.TextBox();
            this.btSEND2 = new System.Windows.Forms.Button();
            this.cbTXHEX1 = new System.Windows.Forms.ComboBox();
            this.tbSEND1 = new System.Windows.Forms.TextBox();
            this.btSEND1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbRXHEX = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSTOPBIT = new System.Windows.Forms.ComboBox();
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.cbPARITY = new System.Windows.Forms.ComboBox();
            this.btnOPEN = new System.Windows.Forms.Button();
            this.cbDATEBIT = new System.Windows.Forms.ComboBox();
            this.cbBITRATE = new System.Windows.Forms.ComboBox();
            this.cbCOMPORT = new System.Windows.Forms.ComboBox();
            this.btCLEAR = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReceive
            // 
            this.txtReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceive.Location = new System.Drawing.Point(0, 0);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceive.Size = new System.Drawing.Size(457, 255);
            this.txtReceive.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkCarriage2);
            this.panel1.Controls.Add(this.chkCarriage1);
            this.panel1.Controls.Add(this.lb_Port1_send);
            this.panel1.Controls.Add(this.lb_Port1_rcv);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.tbINTERVAL);
            this.panel1.Controls.Add(this.btnRepeat);
            this.panel1.Controls.Add(this.rbAUTO2);
            this.panel1.Controls.Add(this.rbAUTO1);
            this.panel1.Controls.Add(this.cbTXHEX2);
            this.panel1.Controls.Add(this.tbSEND2);
            this.panel1.Controls.Add(this.btSEND2);
            this.panel1.Controls.Add(this.cbTXHEX1);
            this.panel1.Controls.Add(this.tbSEND1);
            this.panel1.Controls.Add(this.btSEND1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 120);
            this.panel1.TabIndex = 3;
            // 
            // chkCarriage2
            // 
            this.chkCarriage2.AutoSize = true;
            this.chkCarriage2.Location = new System.Drawing.Point(495, 56);
            this.chkCarriage2.Name = "chkCarriage2";
            this.chkCarriage2.Size = new System.Drawing.Size(72, 16);
            this.chkCarriage2.TabIndex = 63;
            this.chkCarriage2.Text = "Carriage";
            this.chkCarriage2.UseVisualStyleBackColor = true;
            // 
            // chkCarriage1
            // 
            this.chkCarriage1.AutoSize = true;
            this.chkCarriage1.Location = new System.Drawing.Point(495, 30);
            this.chkCarriage1.Name = "chkCarriage1";
            this.chkCarriage1.Size = new System.Drawing.Size(72, 16);
            this.chkCarriage1.TabIndex = 62;
            this.chkCarriage1.Text = "Carriage";
            this.chkCarriage1.UseVisualStyleBackColor = true;
            // 
            // lb_Port1_send
            // 
            this.lb_Port1_send.Location = new System.Drawing.Point(296, 12);
            this.lb_Port1_send.Name = "lb_Port1_send";
            this.lb_Port1_send.Size = new System.Drawing.Size(50, 12);
            this.lb_Port1_send.TabIndex = 61;
            this.lb_Port1_send.Text = "0";
            this.lb_Port1_send.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Port1_rcv
            // 
            this.lb_Port1_rcv.Location = new System.Drawing.Point(83, 12);
            this.lb_Port1_rcv.Name = "lb_Port1_rcv";
            this.lb_Port1_rcv.Size = new System.Drawing.Size(50, 12);
            this.lb_Port1_rcv.TabIndex = 60;
            this.lb_Port1_rcv.Text = "0";
            this.lb_Port1_rcv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(348, 12);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(39, 12);
            this.label33.TabIndex = 59;
            this.label33.Text = "Chars";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(135, 12);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(39, 12);
            this.label34.TabIndex = 58;
            this.label34.Text = "Chars";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(246, 12);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(46, 12);
            this.label26.TabIndex = 57;
            this.label26.Text = "Send : ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(10, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 56;
            this.label25.Text = "Received :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(460, 89);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 55;
            this.label21.Text = "/ms";
            // 
            // tbINTERVAL
            // 
            this.tbINTERVAL.Location = new System.Drawing.Point(419, 84);
            this.tbINTERVAL.Name = "tbINTERVAL";
            this.tbINTERVAL.Size = new System.Drawing.Size(40, 21);
            this.tbINTERVAL.TabIndex = 54;
            this.tbINTERVAL.Text = "1000";
            this.tbINTERVAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRepeat
            // 
            this.btnRepeat.Location = new System.Drawing.Point(495, 84);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(67, 22);
            this.btnRepeat.TabIndex = 53;
            this.btnRepeat.Text = "Repeat";
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // rbAUTO2
            // 
            this.rbAUTO2.AutoSize = true;
            this.rbAUTO2.Location = new System.Drawing.Point(441, 57);
            this.rbAUTO2.Name = "rbAUTO2";
            this.rbAUTO2.Size = new System.Drawing.Size(48, 16);
            this.rbAUTO2.TabIndex = 52;
            this.rbAUTO2.Text = "Auto";
            this.rbAUTO2.UseVisualStyleBackColor = true;
            // 
            // rbAUTO1
            // 
            this.rbAUTO1.AutoSize = true;
            this.rbAUTO1.Checked = true;
            this.rbAUTO1.Location = new System.Drawing.Point(441, 30);
            this.rbAUTO1.Name = "rbAUTO1";
            this.rbAUTO1.Size = new System.Drawing.Size(48, 16);
            this.rbAUTO1.TabIndex = 51;
            this.rbAUTO1.TabStop = true;
            this.rbAUTO1.Text = "Auto";
            this.rbAUTO1.UseVisualStyleBackColor = true;
            // 
            // cbTXHEX2
            // 
            this.cbTXHEX2.FormattingEnabled = true;
            this.cbTXHEX2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbTXHEX2.Items.AddRange(new object[] {
            "ASCII",
            "HEX"});
            this.cbTXHEX2.Location = new System.Drawing.Point(266, 54);
            this.cbTXHEX2.Name = "cbTXHEX2";
            this.cbTXHEX2.Size = new System.Drawing.Size(79, 20);
            this.cbTXHEX2.TabIndex = 50;
            this.cbTXHEX2.Text = "ASCII";
            // 
            // tbSEND2
            // 
            this.tbSEND2.Location = new System.Drawing.Point(12, 54);
            this.tbSEND2.Name = "tbSEND2";
            this.tbSEND2.Size = new System.Drawing.Size(248, 21);
            this.tbSEND2.TabIndex = 48;
            // 
            // btSEND2
            // 
            this.btSEND2.Location = new System.Drawing.Point(351, 53);
            this.btSEND2.Name = "btSEND2";
            this.btSEND2.Size = new System.Drawing.Size(82, 22);
            this.btSEND2.TabIndex = 49;
            this.btSEND2.Text = "Send";
            this.btSEND2.UseVisualStyleBackColor = true;
            this.btSEND2.Click += new System.EventHandler(this.btSEND2_Click);
            // 
            // cbTXHEX1
            // 
            this.cbTXHEX1.FormattingEnabled = true;
            this.cbTXHEX1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbTXHEX1.Items.AddRange(new object[] {
            "ASCII",
            "HEX"});
            this.cbTXHEX1.Location = new System.Drawing.Point(266, 27);
            this.cbTXHEX1.Name = "cbTXHEX1";
            this.cbTXHEX1.Size = new System.Drawing.Size(79, 20);
            this.cbTXHEX1.TabIndex = 47;
            this.cbTXHEX1.Text = "ASCII";
            // 
            // tbSEND1
            // 
            this.tbSEND1.Location = new System.Drawing.Point(12, 27);
            this.tbSEND1.Name = "tbSEND1";
            this.tbSEND1.Size = new System.Drawing.Size(248, 21);
            this.tbSEND1.TabIndex = 45;
            // 
            // btSEND1
            // 
            this.btSEND1.Location = new System.Drawing.Point(351, 26);
            this.btSEND1.Name = "btSEND1";
            this.btSEND1.Size = new System.Drawing.Size(82, 22);
            this.btSEND1.TabIndex = 46;
            this.btSEND1.Text = "Send";
            this.btSEND1.UseVisualStyleBackColor = true;
            this.btSEND1.Click += new System.EventHandler(this.btSEND1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbRXHEX);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.btCLEAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(457, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 255);
            this.panel2.TabIndex = 4;
            // 
            // cbRXHEX
            // 
            this.cbRXHEX.FormattingEnabled = true;
            this.cbRXHEX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbRXHEX.Items.AddRange(new object[] {
            "ASCII",
            "HEX"});
            this.cbRXHEX.Location = new System.Drawing.Point(19, 206);
            this.cbRXHEX.Name = "cbRXHEX";
            this.cbRXHEX.Size = new System.Drawing.Size(70, 20);
            this.cbRXHEX.TabIndex = 23;
            this.cbRXHEX.Text = "ASCII";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.cbSTOPBIT);
            this.groupBox5.Controls.Add(this.btnCLOSE);
            this.groupBox5.Controls.Add(this.cbPARITY);
            this.groupBox5.Controls.Add(this.btnOPEN);
            this.groupBox5.Controls.Add(this.cbDATEBIT);
            this.groupBox5.Controls.Add(this.cbBITRATE);
            this.groupBox5.Controls.Add(this.cbCOMPORT);
            this.groupBox5.Location = new System.Drawing.Point(19, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(155, 178);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Setting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "StopBit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "DataBit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "bit/sec";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Com";
            // 
            // cbSTOPBIT
            // 
            this.cbSTOPBIT.FormattingEnabled = true;
            this.cbSTOPBIT.Items.AddRange(new object[] {
            "None",
            "1",
            "1.5",
            "2"});
            this.cbSTOPBIT.Location = new System.Drawing.Point(59, 118);
            this.cbSTOPBIT.Name = "cbSTOPBIT";
            this.cbSTOPBIT.Size = new System.Drawing.Size(85, 20);
            this.cbSTOPBIT.TabIndex = 4;
            this.cbSTOPBIT.Text = "1";
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Enabled = false;
            this.btnCLOSE.Location = new System.Drawing.Point(79, 148);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(67, 22);
            this.btnCLOSE.TabIndex = 1;
            this.btnCLOSE.Text = "Close";
            this.btnCLOSE.UseVisualStyleBackColor = true;
            this.btnCLOSE.Click += new System.EventHandler(this.btnCLOSE_Click);
            // 
            // cbPARITY
            // 
            this.cbPARITY.FormattingEnabled = true;
            this.cbPARITY.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None",
            "Odd",
            "Space"});
            this.cbPARITY.Location = new System.Drawing.Point(59, 92);
            this.cbPARITY.Name = "cbPARITY";
            this.cbPARITY.Size = new System.Drawing.Size(85, 20);
            this.cbPARITY.TabIndex = 3;
            this.cbPARITY.Text = "None";
            // 
            // btnOPEN
            // 
            this.btnOPEN.Location = new System.Drawing.Point(10, 148);
            this.btnOPEN.Name = "btnOPEN";
            this.btnOPEN.Size = new System.Drawing.Size(67, 22);
            this.btnOPEN.TabIndex = 0;
            this.btnOPEN.Text = "Open";
            this.btnOPEN.UseVisualStyleBackColor = true;
            this.btnOPEN.Click += new System.EventHandler(this.btnOPEN_Click);
            // 
            // cbDATEBIT
            // 
            this.cbDATEBIT.FormattingEnabled = true;
            this.cbDATEBIT.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDATEBIT.Location = new System.Drawing.Point(59, 66);
            this.cbDATEBIT.Name = "cbDATEBIT";
            this.cbDATEBIT.Size = new System.Drawing.Size(85, 20);
            this.cbDATEBIT.TabIndex = 2;
            this.cbDATEBIT.Text = "8";
            // 
            // cbBITRATE
            // 
            this.cbBITRATE.FormattingEnabled = true;
            this.cbBITRATE.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBITRATE.Location = new System.Drawing.Point(59, 40);
            this.cbBITRATE.Name = "cbBITRATE";
            this.cbBITRATE.Size = new System.Drawing.Size(85, 20);
            this.cbBITRATE.TabIndex = 1;
            this.cbBITRATE.Text = "115200";
            // 
            // cbCOMPORT
            // 
            this.cbCOMPORT.FormattingEnabled = true;
            this.cbCOMPORT.Location = new System.Drawing.Point(59, 14);
            this.cbCOMPORT.Name = "cbCOMPORT";
            this.cbCOMPORT.Size = new System.Drawing.Size(85, 20);
            this.cbCOMPORT.TabIndex = 0;
            // 
            // btCLEAR
            // 
            this.btCLEAR.Location = new System.Drawing.Point(98, 205);
            this.btCLEAR.Name = "btCLEAR";
            this.btCLEAR.Size = new System.Drawing.Size(76, 22);
            this.btCLEAR.TabIndex = 22;
            this.btCLEAR.Text = "Clear";
            this.btCLEAR.UseVisualStyleBackColor = true;
            this.btCLEAR.Click += new System.EventHandler(this.btCLEAR_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 375);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(666, 414);
            this.Name = "MainForm";
            this.Text = "SerialComLogs";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbRXHEX;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSTOPBIT;
        private System.Windows.Forms.Button btnCLOSE;
        private System.Windows.Forms.ComboBox cbPARITY;
        private System.Windows.Forms.Button btnOPEN;
        private System.Windows.Forms.ComboBox cbDATEBIT;
        private System.Windows.Forms.ComboBox cbBITRATE;
        private System.Windows.Forms.ComboBox cbCOMPORT;
        private System.Windows.Forms.Button btCLEAR;
        private System.Windows.Forms.CheckBox chkCarriage2;
        private System.Windows.Forms.CheckBox chkCarriage1;
        private System.Windows.Forms.Label lb_Port1_send;
        private System.Windows.Forms.Label lb_Port1_rcv;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbINTERVAL;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.RadioButton rbAUTO2;
        private System.Windows.Forms.RadioButton rbAUTO1;
        private System.Windows.Forms.ComboBox cbTXHEX2;
        private System.Windows.Forms.TextBox tbSEND2;
        private System.Windows.Forms.Button btSEND2;
        private System.Windows.Forms.ComboBox cbTXHEX1;
        private System.Windows.Forms.TextBox tbSEND1;
        private System.Windows.Forms.Button btSEND1;
    }
}

