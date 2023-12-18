namespace ControlWork
{
    partial class TenantsForm
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewTenants = new System.Windows.Forms.DataGridView();
            this.tenantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(578, 296);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 44);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Location = new System.Drawing.Point(294, 296);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(119, 44);
            this.buttonChange.TabIndex = 21;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(13, 296);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 44);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewTenants
            // 
            this.dataGridViewTenants.AutoGenerateColumns = false;
            this.dataGridViewTenants.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridViewTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTenants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.dataGridViewTenants.DataSource = this.tenantsBindingSource;
            this.dataGridViewTenants.Location = new System.Drawing.Point(8, 55);
            this.dataGridViewTenants.Name = "dataGridViewTenants";
            this.dataGridViewTenants.Size = new System.Drawing.Size(693, 215);
            this.dataGridViewTenants.TabIndex = 19;
            // 
            // tenantsBindingSource
            // 
            this.tenantsBindingSource.DataSource = typeof(ControlWork.DataModel.Tenants);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(8, 11);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(-1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(710, 43);
            this.label3.TabIndex = 17;
            this.label3.Text = "Арендаторы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // TenantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(708, 351);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewTenants);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TenantsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TenantsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewTenants;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tenantsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
    }
}