namespace ControlWork
{
    partial class MenuManager
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonShowTC = new System.Windows.Forms.Button();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(6, 10);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonShowTC
            // 
            this.buttonShowTC.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonShowTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonShowTC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonShowTC.Location = new System.Drawing.Point(198, 118);
            this.buttonShowTC.Name = "buttonShowTC";
            this.buttonShowTC.Size = new System.Drawing.Size(114, 65);
            this.buttonShowTC.TabIndex = 15;
            this.buttonShowTC.Text = "Показать ТЦ";
            this.buttonShowTC.UseVisualStyleBackColor = false;
            this.buttonShowTC.Click += new System.EventHandler(this.buttonShowTC_Click);
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelUserInfo.ForeColor = System.Drawing.Color.Teal;
            this.labelUserInfo.Location = new System.Drawing.Point(2, 42);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(349, 73);
            this.labelUserInfo.TabIndex = 13;
            this.labelUserInfo.Text = "label1";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 43);
            this.label3.TabIndex = 12;
            this.label3.Text = "Меню";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRole
            // 
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRole.ForeColor = System.Drawing.Color.Teal;
            this.labelRole.Location = new System.Drawing.Point(357, 42);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(153, 23);
            this.labelRole.TabIndex = 11;
            this.labelRole.Text = "label1";
            this.labelRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 274);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShowTC);
            this.Controls.Add(this.labelUserInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MenuManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonShowTC;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelRole;
        public System.Windows.Forms.Label labelUserInfo;
    }
}