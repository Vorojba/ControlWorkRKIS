using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlWork.DataModel;

namespace ControlWork
{
    public partial class TenantsForm : Form
    {
        private ModelEF db = new ModelEF();
        public TenantsForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.labelUserInfo.Text = $"Добро пожаловать\n{Form_Authorization.User.First_Name} {Form_Authorization.User.Second_Name} {Form_Authorization.User.Middle_Name}";
            menuAdmin.Show();
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не сделано");
        }

        private void TenantsForm_Load(object sender, EventArgs e)
        {
            dataGridViewTenants.DataSource = db.Tenants.ToList();
            if (db.Tenants.ToList().Count == 0) return;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не сделано");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не сделано");
        }
    }
}
