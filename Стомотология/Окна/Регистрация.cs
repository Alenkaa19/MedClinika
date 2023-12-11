using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Стомотология.БД;

namespace Стомотология
{
    public partial class Регистрация : Form
    {
        private Label ВходПользователя;
        private Label ВводныйТекст;
        private Button Очистить;
        private Button ЗарегистрироватьПользователя;
        private CheckBox ПоказатьПароль;
        private TextBox ВводПароля;
        private Label Пароль;
        private TextBox ВводЛогина;
        private Label Логин;
        private TextBox ВводПовторногоПароля;
        private Label ПовторныйПароль;
        private Label Зарегистрироваться;

        public Регистрация()
        {
            InitializeComponent();
        }

        private void ВводЛогина_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Регистрация));
            this.ВходПользователя = new System.Windows.Forms.Label();
            this.ВводныйТекст = new System.Windows.Forms.Label();
            this.Очистить = new System.Windows.Forms.Button();
            this.ЗарегистрироватьПользователя = new System.Windows.Forms.Button();
            this.ПоказатьПароль = new System.Windows.Forms.CheckBox();
            this.ВводПароля = new System.Windows.Forms.TextBox();
            this.Пароль = new System.Windows.Forms.Label();
            this.ВводЛогина = new System.Windows.Forms.TextBox();
            this.Логин = new System.Windows.Forms.Label();
            this.Зарегистрироваться = new System.Windows.Forms.Label();
            this.ВводПовторногоПароля = new System.Windows.Forms.TextBox();
            this.ПовторныйПароль = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ВходПользователя
            // 
            this.ВходПользователя.AutoSize = true;
            this.ВходПользователя.BackColor = System.Drawing.Color.Transparent;
            this.ВходПользователя.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ВходПользователя.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ВходПользователя.ForeColor = System.Drawing.Color.SteelBlue;
            this.ВходПользователя.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ВходПользователя.Location = new System.Drawing.Point(119, 519);
            this.ВходПользователя.Name = "ВходПользователя";
            this.ВходПользователя.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ВходПользователя.Size = new System.Drawing.Size(79, 26);
            this.ВходПользователя.TabIndex = 33;
            this.ВходПользователя.Text = "Войти";
            this.ВходПользователя.Click += new System.EventHandler(this.ВходПользователя_Click);
            // 
            // ВводныйТекст
            // 
            this.ВводныйТекст.AutoSize = true;
            this.ВводныйТекст.BackColor = System.Drawing.Color.Transparent;
            this.ВводныйТекст.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ВводныйТекст.ForeColor = System.Drawing.Color.SteelBlue;
            this.ВводныйТекст.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ВводныйТекст.Location = new System.Drawing.Point(66, 493);
            this.ВводныйТекст.Name = "ВводныйТекст";
            this.ВводныйТекст.Size = new System.Drawing.Size(218, 26);
            this.ВводныйТекст.TabIndex = 32;
            this.ВводныйТекст.Text = "Уже есть Аккаунт?";
            // 
            // Очистить
            // 
            this.Очистить.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Очистить.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Очистить.FlatAppearance.BorderSize = 0;
            this.Очистить.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Очистить.ForeColor = System.Drawing.Color.SteelBlue;
            this.Очистить.Image = ((System.Drawing.Image)(resources.GetObject("Очистить.Image")));
            this.Очистить.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Очистить.Location = new System.Drawing.Point(50, 447);
            this.Очистить.Name = "Очистить";
            this.Очистить.Size = new System.Drawing.Size(288, 43);
            this.Очистить.TabIndex = 31;
            this.Очистить.Text = "Очистить";
            this.Очистить.UseVisualStyleBackColor = true;
            this.Очистить.Click += new System.EventHandler(this.Очистить_Click);
            // 
            // ЗарегистрироватьПользователя
            // 
            this.ЗарегистрироватьПользователя.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ЗарегистрироватьПользователя.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.ЗарегистрироватьПользователя.FlatAppearance.BorderSize = 0;
            this.ЗарегистрироватьПользователя.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ЗарегистрироватьПользователя.ForeColor = System.Drawing.Color.SteelBlue;
            this.ЗарегистрироватьПользователя.Image = ((System.Drawing.Image)(resources.GetObject("ЗарегистрироватьПользователя.Image")));
            this.ЗарегистрироватьПользователя.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ЗарегистрироватьПользователя.Location = new System.Drawing.Point(50, 398);
            this.ЗарегистрироватьПользователя.Name = "ЗарегистрироватьПользователя";
            this.ЗарегистрироватьПользователя.Size = new System.Drawing.Size(288, 43);
            this.ЗарегистрироватьПользователя.TabIndex = 30;
            this.ЗарегистрироватьПользователя.Text = "Зарегистрироваться";
            this.ЗарегистрироватьПользователя.UseVisualStyleBackColor = true;
            this.ЗарегистрироватьПользователя.Click += new System.EventHandler(this.ЗарегистрироватьПользователя_Click);
            // 
            // ПоказатьПароль
            // 
            this.ПоказатьПароль.AutoSize = true;
            this.ПоказатьПароль.BackColor = System.Drawing.Color.Transparent;
            this.ПоказатьПароль.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ПоказатьПароль.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ПоказатьПароль.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ПоказатьПароль.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ПоказатьПароль.ForeColor = System.Drawing.Color.SteelBlue;
            this.ПоказатьПароль.Location = new System.Drawing.Point(36, 359);
            this.ПоказатьПароль.Name = "ПоказатьПароль";
            this.ПоказатьПароль.Size = new System.Drawing.Size(213, 30);
            this.ПоказатьПароль.TabIndex = 29;
            this.ПоказатьПароль.Text = "Показать пароль";
            this.ПоказатьПароль.UseVisualStyleBackColor = false;
            this.ПоказатьПароль.CheckedChanged += new System.EventHandler(this.ПоказатьПароль_CheckedChanged);
            // 
            // ВводПароля
            // 
            this.ВводПароля.BackColor = System.Drawing.SystemColors.Window;
            this.ВводПароля.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ВводПароля.ForeColor = System.Drawing.Color.SteelBlue;
            this.ВводПароля.Location = new System.Drawing.Point(38, 255);
            this.ВводПароля.Multiline = true;
            this.ВводПароля.Name = "ВводПароля";
            this.ВводПароля.PasswordChar = '•';
            this.ВводПароля.Size = new System.Drawing.Size(287, 34);
            this.ВводПароля.TabIndex = 28;
            // 
            // Пароль
            // 
            this.Пароль.AutoSize = true;
            this.Пароль.BackColor = System.Drawing.Color.Transparent;
            this.Пароль.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Пароль.ForeColor = System.Drawing.Color.SteelBlue;
            this.Пароль.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Пароль.Location = new System.Drawing.Point(35, 221);
            this.Пароль.Name = "Пароль";
            this.Пароль.Size = new System.Drawing.Size(107, 31);
            this.Пароль.TabIndex = 27;
            this.Пароль.Text = "Пароль";
            // 
            // ВводЛогина
            // 
            this.ВводЛогина.BackColor = System.Drawing.SystemColors.Window;
            this.ВводЛогина.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ВводЛогина.ForeColor = System.Drawing.Color.SteelBlue;
            this.ВводЛогина.Location = new System.Drawing.Point(38, 171);
            this.ВводЛогина.Multiline = true;
            this.ВводЛогина.Name = "ВводЛогина";
            this.ВводЛогина.Size = new System.Drawing.Size(287, 34);
            this.ВводЛогина.TabIndex = 26;
            // 
            // Логин
            // 
            this.Логин.AutoSize = true;
            this.Логин.BackColor = System.Drawing.Color.Transparent;
            this.Логин.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Логин.ForeColor = System.Drawing.Color.SteelBlue;
            this.Логин.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Логин.Location = new System.Drawing.Point(34, 137);
            this.Логин.Name = "Логин";
            this.Логин.Size = new System.Drawing.Size(91, 31);
            this.Логин.TabIndex = 25;
            this.Логин.Text = "Логин";
            // 
            // Зарегистрироваться
            // 
            this.Зарегистрироваться.AutoSize = true;
            this.Зарегистрироваться.BackColor = System.Drawing.Color.Transparent;
            this.Зарегистрироваться.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Зарегистрироваться.ForeColor = System.Drawing.Color.SteelBlue;
            this.Зарегистрироваться.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Зарегистрироваться.Location = new System.Drawing.Point(63, 72);
            this.Зарегистрироваться.Name = "Зарегистрироваться";
            this.Зарегистрироваться.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Зарегистрироваться.Size = new System.Drawing.Size(251, 45);
            this.Зарегистрироваться.TabIndex = 24;
            this.Зарегистрироваться.Text = "Регистрация";
            this.Зарегистрироваться.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ВводПовторногоПароля
            // 
            this.ВводПовторногоПароля.BackColor = System.Drawing.SystemColors.Window;
            this.ВводПовторногоПароля.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ВводПовторногоПароля.ForeColor = System.Drawing.Color.SteelBlue;
            this.ВводПовторногоПароля.Location = new System.Drawing.Point(36, 330);
            this.ВводПовторногоПароля.Multiline = true;
            this.ВводПовторногоПароля.Name = "ВводПовторногоПароля";
            this.ВводПовторногоПароля.PasswordChar = '•';
            this.ВводПовторногоПароля.Size = new System.Drawing.Size(287, 34);
            this.ВводПовторногоПароля.TabIndex = 35;
            // 
            // ПовторныйПароль
            // 
            this.ПовторныйПароль.AutoSize = true;
            this.ПовторныйПароль.BackColor = System.Drawing.Color.Transparent;
            this.ПовторныйПароль.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ПовторныйПароль.ForeColor = System.Drawing.Color.SteelBlue;
            this.ПовторныйПароль.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ПовторныйПароль.Location = new System.Drawing.Point(32, 296);
            this.ПовторныйПароль.Name = "ПовторныйПароль";
            this.ПовторныйПароль.Size = new System.Drawing.Size(238, 31);
            this.ПовторныйПароль.TabIndex = 34;
            this.ПовторныйПароль.Text = "Повторите пароль";
            // 
            // Регистрация
            // 
            this.BackgroundImage = global::Стомотология.Properties.Resources.winter_background_for_invitations_cards_journals_planners_weddings_199112_3023;
            this.ClientSize = new System.Drawing.Size(382, 605);
            this.Controls.Add(this.ВводПовторногоПароля);
            this.Controls.Add(this.ПовторныйПароль);
            this.Controls.Add(this.ВходПользователя);
            this.Controls.Add(this.ВводныйТекст);
            this.Controls.Add(this.Очистить);
            this.Controls.Add(this.ЗарегистрироватьПользователя);
            this.Controls.Add(this.ПоказатьПароль);
            this.Controls.Add(this.ВводПароля);
            this.Controls.Add(this.Пароль);
            this.Controls.Add(this.ВводЛогина);
            this.Controls.Add(this.Логин);
            this.Controls.Add(this.Зарегистрироваться);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Регистрация";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Регистрация_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        //Реализация кнопки зарегистрироваться
        private void ЗарегистрироватьПользователя_Click(object sender, EventArgs e)
        {
            if (ВводЛогина.Text == "" || ВводПароля.Text == "" || ВводПовторногоПароля.Text == "") //проверка на заполненине всех полей
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            if (ПоликлиникаEntities3.GetContext().Пользователь.ToList().Find(u => u.Логин == ВводЛогина.Text) != null) //проверка на  существующего пользователя
            {
                MessageBox.Show("Пользователь уже существует");
                return;
            }

            if (ВводПароля.Text != ВводПовторногоПароля.Text) //проверка совпадения паролей
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            
            else
            {
                //хеширование паролей
                var passwordHash = PasswordHash.CreatePasswordHash(ВводПароля.Text);
                Пользователь user = new Пользователь
                {
                    
                    Логин = ВводЛогина.Text,
                    Пароль = passwordHash,
                };
                ПоликлиникаEntities3.GetContext().Пользователь.Add(user); //добавление нового аккаунта в БД
                try
                {
                    ПоликлиникаEntities3.GetContext().SaveChanges();
                    MessageBox.Show("Успех");
                    Авторизация form = new Авторизация(); //переход на страницу авторизации
                    form.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    throw;
                }
            }
        }

        //реализация метода открытости пароля
        private void ПоказатьПароль_CheckedChanged(object sender, EventArgs e)
        {
            if(ПоказатьПароль.Checked)
            {
                ВводПароля.PasswordChar = '\0';
                ВводПовторногоПароля.PasswordChar = '\0';
            }
            else
            {
                ВводПароля.PasswordChar = '•';
                ВводПовторногоПароля.PasswordChar = '•';
            }
        }
        //реализация кнопки очистить
        private void Очистить_Click(object sender, EventArgs e)
        {
            ВводЛогина.Text = "";
            ВводПароля.Text = "";
            ВводПовторногоПароля.Text = "";
            ВводЛогина.Focus();

        }
        //реализация кнопки входа
        private void ВходПользователя_Click(object sender, EventArgs e)
        {
            new Авторизация().Show();
            this.Close();
        }

        private void Регистрация_Load(object sender, EventArgs e)
        {

        }
    }
}
