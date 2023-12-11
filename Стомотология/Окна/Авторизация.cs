using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.MessageBox;
using Стомотология;
using Стомотология.Roles;
using Стомотология.БД;
using Стомотология.Окна;

namespace Стомотология
{
    public partial class Авторизация : Form
    {
        public int tries { get; private set; }

        public Авторизация()
        {
            InitializeComponent();
        }

        //Метод с помощью которого отображается пароль
        private void ПоказатьПароль_CheckedChanged(object sender, EventArgs e)
        {

            if (ПоказатьПароль.Checked)
            {
                ВводПароля.PasswordChar = '\0';            
            }
            else
            {
                ВводПароля.PasswordChar = '•';
            }
        }
        //Окно регистрации
        private void РегистрацияПользователя_Click(object sender, EventArgs e)
        {
            new Регистрация().Show();
            this.Close();
        }
        //Проверка на заполнение всех полей
        private void Войти_Click(object sender, EventArgs e)
        {
            if (ВводЛогина.Text == "" && ВводПароля.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if (ВводЛогина.Text == null) //Проверка на присутствие логина
            {
                MessageBox.Show("Введите логин!"); 
                return;
            }
            if (ВводПароля.Text == null) //Проверка на присутствие пароля
            {
                MessageBox.Show("Введите пароль!");
                return;
            }
            //Блокировка кнопки войти на окне авторизации
            Пользователь userData = new Пользователь();
            userData= ПоликлиникаEntities3.GetContext().Пользователь.ToList().Find(u=> u.Логин == ВводЛогина.Text);
            if (tries >= 3 && (userData == null || !PasswordHash.VerifyPassword(ВводПароля.Text, userData?.Пароль)))
            {
                var timer = new Timer { Interval = 10000 };
                MessageBox.Show("Вы ввели направельнные данные болле трёх раз.Система заблокирована на 10 секунд");
                timer.Tick += (o, args) =>
                {
                    // разблокируем кнопку
                    Войти.Enabled = true;
                    timer.Stop();
                };
                timer.Start();
                // блокируем кнопку на время
                Войти.Enabled = false;
            }
            else if (userData == null || !PasswordHash.VerifyPassword(ВводПароля.Text, userData?.Пароль))
            {
                MessageBox.Show("Данные введенны неверно, или пользователь не существует");
                tries++;
                return;
            }
            else if (userData == null) //Проверка сущесвует ли такой пользователь в бд
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }
            else if (PasswordHash.VerifyPassword(ВводПароля.Text, userData.Пароль)) 
            {
                if (ВводЛогина.Text == "admin") //если логин админ то осуществляется переход на окно администратора
                {
                    UserRole.пользователь = userData;
                    MessageBox.Show(UserRole.GetRole());
                    PageMain window = new PageMain();
                    window.Show();
                    this.Close();
                }
                if (ВводЛогина.Text == "vrach") //если логин врач то осуществляется переход на окно диагнозов
                {
                    UserRole.пользователь = userData;
                    MessageBox.Show(UserRole.GetRole());
                    БолезниПациентов window = new БолезниПациентов();
                    window.Show();
                    this.Close();
                }
                else //если не первые два пунка происходит вход в систему для пользователя
                {
                    UserRole.пользователь = userData;
                    MessageBox.Show(UserRole.GetRole());
                    ЗаписьНаПрием forms = new ЗаписьНаПрием();
                    forms.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        //работоспососбность кнопки очистить
        private void Очистить_Click(object sender, EventArgs e)
        {
            ВводЛогина.Text = "";
            ВводПароля.Text = "";
            ВводЛогина.Focus();
        }
        //Метод для ввода логина
        private void ВводЛогина_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
