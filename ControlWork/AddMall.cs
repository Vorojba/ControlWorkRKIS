using ControlWork.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWork
{
    public partial class AddMall : Form
    {
        private List<Mall> malls = ShoppingMalls.db.Mall.ToList();
        public static ModelEF db = new ModelEF();
        private Mall CurrentMall;
        public int currentId;
        public AddMall()
        {
            CurrentMall = new Mall();
            InitializeComponent();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBoxFloor.Text);
            }
            catch(Exception) 
            {
                MessageBox.Show("В поле Floor могут быть только целочисленные данные!");
                return;
            }

            Mall NMall = new Mall();
            NMall.ID = Plus1();
            NMall.Name = textBoxName.Text;
            NMall.Status = textBoxStatus.Text;
            NMall.Town = textBoxTown.Text;
            NMall.Cost = Convert.ToDecimal(textBoxCost.Text);
            NMall.Floor = Convert.ToInt32(textBoxFloor.Text);

            try 
            {
                ShoppingMalls.db.Mall.Add(NMall);
                ShoppingMalls.db.SaveChanges();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Данные успешно добавлены!");
            ShoppingMalls shoppingMalls = new ShoppingMalls(CurrentMall);
            shoppingMalls.Show();
            this.Hide();

        }

        private int Plus1() 
        {
            int max = 0;
            foreach (Mall mall in malls) 
                if(max < mall.ID) max = mall.ID;
            return ++max;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ShoppingMalls shoppingMalls = new ShoppingMalls(CurrentMall);
            shoppingMalls.Show();
            this.Hide();
        }

        private void buttonReChange_Click(object sender, EventArgs e)
        {
            ShoppingMalls shoppingMalls = new ShoppingMalls(CurrentMall);
            Mall NMall = db.Mall.Find(currentId);
 //         CurrentMall.ID = shoppingMalls.CurrentMall.ID;
            NMall.Name = textBoxName.Text;
            NMall.Status = textBoxStatus.Text;
            NMall.Town = textBoxTown.Text;
            NMall.Cost = Convert.ToDecimal(textBoxCost.Text);
            NMall.Floor = Convert.ToInt32(textBoxFloor.Text);
            NMall.Coeff_cost = Convert.ToDouble(textBoxCoeffCost.Text);

            try
            {

                ShoppingMalls.db.Mall.AddOrUpdate(NMall);

                ShoppingMalls.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Данные успешно изменены!");
            shoppingMalls.Show();
            this.Hide();
        }
    }
}
