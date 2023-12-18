using ControlWork.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWork
{
    public partial class MenuManager : Form
    {
        private Mall CurrentMall;
        public MenuManager()
        {
            InitializeComponent();
            CurrentMall = new Mall();
        }

        private void MenuManager_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Form_Authorization form_Authorization = new Form_Authorization();            
            form_Authorization.Show();
            this.Close();

        }

        private void buttonShowTC_Click(object sender, EventArgs e)
        {
            ShoppingMalls shoppingMalls = new ShoppingMalls(CurrentMall);
            shoppingMalls.Show();
            this.Hide();
        }
    }
}
