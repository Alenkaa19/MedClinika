using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Стомотология.Окна;

namespace Стомотология
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Window
    {
        public PageMain()
        {
            InitializeComponent();
        }

        //Реализация гиперссылки сменить пользователя
        private void СменитьПользователя(object sender, RoutedEventArgs e)
        {
            Авторизация form = new Авторизация();
            form.Show();
            this.Content=null;
            
        }
        //Переадресациия на страницу СписокДиагнозов
        private void Диагноз(object sender, RoutedEventArgs e)
        {
            СписокДиагнозов window= new СписокДиагнозов();
            window.Show();
            this.Content = null;

        }
        //Переадресациия на страницу ДанныеОПриемах
        private void Прием(object sender, RoutedEventArgs e)
        {
            ДанныеОПриемах window = new ДанныеОПриемах();
            window.Show();
            this.Content = null;

        }
        //Переадресациия на страницу СписокПациентов
        private void Пациент(object sender, RoutedEventArgs e)
        {
            СписокПациентов window = new СписокПациентов();
            window.Show();
            this.Content = null;

        }
        //Переадресациия на страницу СписокВрачей
        private void Врач(object sender, RoutedEventArgs e)
        {
            СписокВрачей window = new СписокВрачей();
            window.Show();
            this.Content = null;

        }
        //Переадресациия на страницу СписокТалонов
        private void Талон(object sender, RoutedEventArgs e)
        {
            СписокТалонов_admin_ window = new СписокТалонов_admin_();
            window.Show();
            this.Content = null;

        }
    }
}
