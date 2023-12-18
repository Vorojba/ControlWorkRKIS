using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlWork.DataModel;

namespace ControlWork
{
    public partial class ShoppingMalls : Form
    {
        public static ModelEF db = new ModelEF();

        public Mall CurrentMall { get; set; }


        public ShoppingMalls(Mall currentMall)
        {
            InitializeComponent();
            CurrentMall = currentMall;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CurrentMall = db.Mall.Find((int)dataGridViewMall.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show($@"Вы действительно хотите удалить объект с ID - {CurrentMall.ID}", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                try
                {
                    db.Mall.Remove(CurrentMall);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally 
                {
                    dataGridViewMall.DataSource = db.Mall.ToList();
                }

            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            CurrentMall = db.Mall.Find((int)dataGridViewMall.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show($@"Вам нужно изменить объект с ID - {CurrentMall.ID}?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                AddMall addMall = new AddMall();
                addMall.currentId = CurrentMall.ID;
                addMall.label4.Text = "Изменение ТЦ";
                addMall.buttonAdd.Text = "Изменить";

                //MessageBox.Show(CurrentMall.ID.ToString());
                addMall.textBoxName.Text = CurrentMall.Name;
                addMall.textBoxStatus.Text = CurrentMall.Status;
                addMall.textBoxTown.Text = CurrentMall.Town;
                addMall.textBoxCost.Text = CurrentMall.Cost.ToString();
                addMall.textBoxCoeffCost.Text = CurrentMall.Coeff_cost.ToString();
                addMall.textBoxFloor.Text = CurrentMall.Floor.ToString();
                addMall.buttonAdd.Visible = false;
                addMall.buttonReChange.Visible = true;
                addMall.Show();
                this.Hide();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddMall addMall = new AddMall();
            addMall.buttonAdd.Visible = true;
            addMall.buttonReChange.Visible = false;
            addMall.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MenuManager menuManager = new MenuManager();
            menuManager.labelUserInfo.Text = $"Добро пожаловать\n{Form_Authorization.User.First_Name} {Form_Authorization.User.Second_Name} {Form_Authorization.User.Middle_Name}";
            menuManager.labelRole.Text = Form_Authorization.User.Role;
            menuManager.Show();
            this.Close();
        }

        private void ShoppingMalls_Load(object sender, EventArgs e)
        {
            dataGridViewMall.DataSource = db.Mall.ToList();
            if (db.Mall.ToList().Count == 0) return;
        }
    }
}
// открываю форму, подгрузка, сохранение, выход