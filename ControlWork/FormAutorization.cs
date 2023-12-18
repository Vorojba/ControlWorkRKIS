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
    public partial class Form_Authorization : Form
    {
        public static Workers User;

        public Form_Authorization()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            User = null;
            ModelEF db = new ModelEF();

            User = db.Workers.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (User != null) 
            {
                switch (User.Role) 
                {
                    case "Администратор":
                        MenuAdmin menu = new MenuAdmin();
                        menu.labelUserInfo.Text = $"Добро пожаловать\n{User.First_Name} {User.Second_Name} {User.Middle_Name}";                       
                        menu.Show();
                        this.Hide();
                        break;
                    case "Менеджер А":
                        MenuManager menuManagerA = new MenuManager();
                        menuManagerA.labelRole.Text = User.Role;
                        menuManagerA.labelUserInfo.Text = $"Добро пожаловать\n{User.First_Name} {User.Second_Name} {User.Middle_Name}";
                        menuManagerA.Show();
                        this.Hide();
                        break;
                    case "Менеджер С":
                        MenuManager menuManagerC = new MenuManager();
                        menuManagerC.labelRole.Text = User.Role;
                        menuManagerC.labelUserInfo.Text = $"Добро пожаловать\n{User.First_Name} {User.Second_Name} {User.Middle_Name}";                       
                        menuManagerC.Show();
                        this.Hide();
                        break;
                    case "Удален":
                        MessageBox.Show("Пользователь Удален!");
                        break;
                    default: throw new Exception("Роль не найдена!");
                }
            }
            else MessageBox.Show("Введите верные данные");
        }

       
    }
}
