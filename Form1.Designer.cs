namespace 임베디드_어플리케이션_구현_환경구축
{
    partial class Form1
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
            this.PortNumber = new System.Windows.Forms.ComboBox();
            this.연결 = new System.Windows.Forms.Button();
            this.L1ON = new System.Windows.Forms.Button();
            this.L1OFF = new System.Windows.Forms.Button();
            this.L2ON = new System.Windows.Forms.Button();
            this.L2OFF = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PortNumber
            // 
            this.PortNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortNumber.FormattingEnabled = true;
            this.PortNumber.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.PortNumber.Location = new System.Drawing.Point(32, 29);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(160, 26);
            this.PortNumber.TabIndex = 0;
            this.PortNumber.SelectedIndexChanged += new System.EventHandler(this.PortNumber_SelectedIndexChanged);
            // 
            // 연결
            // 
            this.연결.Location = new System.Drawing.Point(243, 29);
            this.연결.Name = "연결";
            this.연결.Size = new System.Drawing.Size(161, 36);
            this.연결.TabIndex = 1;
            this.연결.Text = "연결";
            this.연결.UseVisualStyleBackColor = true;
            this.연결.Click += new System.EventHandler(this.button1_Click);
            // 
            // L1ON
            // 
            this.L1ON.Location = new System.Drawing.Point(32, 117);
            this.L1ON.Name = "L1ON";
            this.L1ON.Size = new System.Drawing.Size(160, 90);
            this.L1ON.TabIndex = 2;
            this.L1ON.Text = "LED_01 ON";
            this.L1ON.UseVisualStyleBackColor = true;
            this.L1ON.Click += new System.EventHandler(this.button2_Click);
            // 
            // L1OFF
            // 
            this.L1OFF.Location = new System.Drawing.Point(243, 117);
            this.L1OFF.Name = "L1OFF";
            this.L1OFF.Size = new System.Drawing.Size(161, 90);
            this.L1OFF.TabIndex = 3;
            this.L1OFF.Text = "LED_01 OFF";
            this.L1OFF.UseVisualStyleBackColor = true;
            this.L1OFF.Click += new System.EventHandler(this.button3_Click);
            // 
            // L2ON
            // 
            this.L2ON.Location = new System.Drawing.Point(32, 262);
            this.L2ON.Name = "L2ON";
            this.L2ON.Size = new System.Drawing.Size(160, 85);
            this.L2ON.TabIndex = 4;
            this.L2ON.Text = "LED_02 ON";
            this.L2ON.UseVisualStyleBackColor = true;
            this.L2ON.Click += new System.EventHandler(this.button4_Click);
            // 
            // L2OFF
            // 
            this.L2OFF.Location = new System.Drawing.Point(243, 262);
            this.L2OFF.Name = "L2OFF";
            this.L2OFF.Size = new System.Drawing.Size(161, 85);
            this.L2OFF.TabIndex = 5;
            this.L2OFF.Text = "LED_02 OFF";
            this.L2OFF.UseVisualStyleBackColor = true;
            this.L2OFF.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(32, 438);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(372, 28);
            this.txtArea.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Message :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.L2OFF);
            this.Controls.Add(this.L2ON);
            this.Controls.Add(this.L1OFF);
            this.Controls.Add(this.L1ON);
            this.Controls.Add(this.연결);
            this.Controls.Add(this.PortNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion




        private System.Windows.Forms.ComboBox PortNumber;
        private System.Windows.Forms.Button 연결;
        private System.Windows.Forms.Button L1ON;
        private System.Windows.Forms.Button L1OFF;
        private System.Windows.Forms.Button L2ON;
        private System.Windows.Forms.Button L2OFF;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label1;
    }
}

