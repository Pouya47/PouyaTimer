namespace Pouya_Timer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.checkBox_OnTop = new System.Windows.Forms.CheckBox();
            this.checkBoxHideBorder = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(12, 81);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(131, 81);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Time.ForeColor = System.Drawing.Color.Red;
            this.lbl_Time.Location = new System.Drawing.Point(12, 9);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(170, 73);
            this.lbl_Time.TabIndex = 2;
            this.lbl_Time.Text = "0:0:0";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_OnTop
            // 
            this.checkBox_OnTop.AutoSize = true;
            this.checkBox_OnTop.Location = new System.Drawing.Point(0, 0);
            this.checkBox_OnTop.Name = "checkBox_OnTop";
            this.checkBox_OnTop.Size = new System.Drawing.Size(62, 17);
            this.checkBox_OnTop.TabIndex = 3;
            this.checkBox_OnTop.Text = "On Top";
            this.checkBox_OnTop.UseVisualStyleBackColor = true;
            this.checkBox_OnTop.CheckedChanged += new System.EventHandler(this.checkBox_OnTop_CheckedChanged);
            // 
            // checkBoxHideBorder
            // 
            this.checkBoxHideBorder.AutoSize = true;
            this.checkBoxHideBorder.Location = new System.Drawing.Point(125, 3);
            this.checkBoxHideBorder.Name = "checkBoxHideBorder";
            this.checkBoxHideBorder.Size = new System.Drawing.Size(87, 17);
            this.checkBoxHideBorder.TabIndex = 4;
            this.checkBoxHideBorder.Text = "Hide Borders";
            this.checkBoxHideBorder.UseVisualStyleBackColor = true;
            this.checkBoxHideBorder.CheckedChanged += new System.EventHandler(this.checkBoxHideBorder_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(211, 109);
            this.Controls.Add(this.checkBoxHideBorder);
            this.Controls.Add(this.checkBox_OnTop);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pouya Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.CheckBox checkBox_OnTop;
        private System.Windows.Forms.CheckBox checkBoxHideBorder;
    }
}

