namespace ControlWork
{
    partial class MenuAdmin
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
            this.labelRole = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.buttonShowTenants = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRole
            // 
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelRole.ForeColor = System.Drawing.Color.Teal;
            this.labelRole.Location = new System.Drawing.Point(356, 42);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(153, 23);
            this.labelRole.TabIndex = 0;
            this.labelRole.Text = "Администратор";
            this.labelRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(0, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "Меню";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelUserInfo.ForeColor = System.Drawing.Color.Teal;
            this.labelUserInfo.Location = new System.Drawing.Point(1, 42);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(289, 67);
            this.labelUserInfo.TabIndex = 7;
            this.labelUserInfo.Text = "label1";
            // 
            // buttonShowTenants
            // 
            this.buttonShowTenants.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonShowTenants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowTenants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonShowTenants.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonShowTenants.Location = new System.Drawing.Point(190, 118);
            this.buttonShowTenants.Name = "buttonShowTenants";
            this.buttonShowTenants.Size = new System.Drawing.Size(127, 65);
            this.buttonShowTenants.TabIndex = 8;
            this.buttonShowTenants.Text = "Показать Арендаторов";
            this.buttonShowTenants.UseVisualStyleBackColor = false;
            this.buttonShowTenants.Click += new System.EventHandler(this.buttonShowTenants_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(5, 10);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 274);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShowTenants);
            this.Controls.Add(this.labelUserInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonShowTenants;
        private System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.Label labelUserInfo;
    }
}