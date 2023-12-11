using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Стомотология.Roles;
using Стомотология.БД;

namespace Стомотология.Окна
{
    /// <summary>
    /// Логика взаимодействия для СписокТалонов_admin_.xaml
    /// </summary>
    public partial class СписокТалонов_admin_ : Window
    {
        //Привязка Бд и страниц
        public static ПоликлиникаEntities3 DataEntitiesТалон { get; set; }
        public ObservableCollection<Талон> ListТалон { get; set; }
        private bool isDirty = true;

        public СписокТалонов_admin_()
        {
            InitializeComponent();
            DataEntitiesТалон = new ПоликлиникаEntities3();
            ListТалон = new ObservableCollection<Талон>();
        }
        //Метод получения данных из БД
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            var Талон = DataEntitiesТалон.Талон; //связываем нужную таблицу в БД 
            var queryСписокТалонов = from СписокТалонов in Талон
                                     orderby СписокТалонов.Дата //Определяем по чему связываем
                                     select СписокТалонов;
            foreach (Талон pac in queryСписокТалонов)
            {
                ListТалон.Add(pac);
            }
            DataGridBol.ItemsSource = ListТалон; //выводим полученные данные


        }

        private void GetСписокТалонов()
        {
            var СписокТалонов = DataEntitiesТалон.Талон; //связываем нужную таблицу в БД 

            var queryСписокТалонов = from Талон in СписокТалонов
                                     orderby Талон.КодТалона //Определяем по чему связываем
                                     select Талон;
            foreach (Талон pac in queryСписокТалонов)
            {
                ListТалон.Add(pac);
            }
            DataGridBol.ItemsSource = ListТалон; //выводим полученные данные
        }
        // Перепесование данных из бд в WPF
        private void RewriteСписокТалонов()
        {
            DataEntitiesТалон = new ПоликлиникаEntities3();
            ListТалон.Clear();
            GetСписокТалонов();
        }
        //Реализация команды удалить
        private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Талон список = DataGridBol.SelectedItem as Талон;
            if (список != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные ", "Предупреждение", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    DataEntitiesТалон.Талон.Remove(список);
                    DataGridBol.SelectedIndex = DataGridBol.SelectedIndex == 0 ? 1 : DataGridBol.SelectedIndex - 1;
                    ListТалон.Remove(список);
                    DataEntitiesТалон.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }
        private void DeleteCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;

        }

        private void EditCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;

        }
        //Реализация команды редактировать
        private void EditCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            DataGridBol.IsReadOnly = false;
            DataGridBol.BeginEdit();
            isDirty = false;
        }
        //Реализация команды сохранить
        private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                DataEntitiesТалон.SaveChanges();
                DataGridBol.IsReadOnly = true;
                isDirty = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void SaveCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }
        //Реализация команды обновить
        private void UndoCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RewriteСписокТалонов();
            DataGridBol.IsReadOnly = true;
            isDirty = true;
        }


        private void UndoCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }
        //Реализация команды создать новую запись
        private void NewCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var СписокТалонов = new Талон();
            СписокТалонов.Дата = DateTime.ParseExact("08.03.1998", "dd.MM.yyyy", null);
            СписокТалонов.Время = new TimeSpan();
            СписокТалонов.КодВрача = 0;

            try
            {
                DataGridBol.IsReadOnly = false;
                DataGridBol.BeginEdit();
                DataEntitiesТалон.Талон.Add(СписокТалонов);
                ListТалон.Add(СписокТалонов);
                isDirty = false;
                DataGridBol.ItemsSource = ListТалон;
            }
            catch
            {
                throw new ApplicationException("Ошибка добавления данных");
            }
        }

        private void NewCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }
        //Реализация поиска
        private void FindCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }
        private void FindCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            BorderFind.Visibility = Visibility.Visible;
        }
        private void RefreshCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RewriteСписокТалонов();
            DataGridBol.IsReadOnly = false;
            isDirty = true;
            BorderFind.Visibility = Visibility.Hidden;
        }
        //поиск по фамилии
        private void TextBoxSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            ButtonFindSurname.IsEnabled = true;
            ButtonFindTitle.IsEnabled = false;
            ComboBoxTitle.SelectedIndex = -1;
        }
        //реализация поиска по времени
        private void ButtonFindSurname_Click(object sender, RoutedEventArgs e)
        {
            string surname = TextBoxSurname.Text;
            DataEntitiesТалон = new ПоликлиникаEntities3();
            ListТалон.Clear();
            var СписокТалонов = DataEntitiesТалон.Талон;
            var queryСписокТалонов = from Талон in СписокТалонов
                                     where Талон.Время == TimeSpan.Zero
                                     select Талон;
            foreach (Талон pac in queryСписокТалонов)
            {
                ListТалон.Add(pac);
            }
            if (ListТалон.Count > 0)
            {
                DataGridBol.ItemsSource = ListТалон;
                ButtonFindSurname.IsEnabled = true;
                ButtonFindTitle.IsEnabled = false;
            }
            else
                MessageBox.Show("Талон на  \n" + surname + "\n не найден", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        //выпадающий список поиска
        private void ComboBoxTitle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonFindTitle.IsEnabled = true;
            ButtonFindSurname.IsEnabled = false;
            TextBoxSurname.Text = "";
        }
        //реализация поиска по дате
        private void ButtonFindTitle_Click(object sender, RoutedEventArgs e)
        {
            string title = ComboBoxTitle.Text;
            DataEntitiesТалон = new ПоликлиникаEntities3();
            ListТалон.Clear();
            //Врач title = ComboBoxTitle.SelectedItem as Врач;
            var СписокТалонов = DataEntitiesТалон.Талон;
            var queryСписокТалонов = from Талон in СписокТалонов
                                     where Талон.Дата == DateTime.Now
                                     select Талон;
            foreach (Талон emp in queryСписокТалонов)
            {
                ListТалон.Add(emp);
            }
            DataGridBol.ItemsSource = ListТалон;
            if (ListТалон.Count < 0)
            {
                DataGridBol.ItemsSource = ListТалон;
                ButtonFindSurname.IsEnabled = false;
                ButtonFindTitle.IsEnabled = true;
                MessageBox.Show("Талон на  \n" + title + "\n не найден", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {

            }
        }
        //реализация кнопки перехода на страницу PageMain
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageMain window = new PageMain();
            window.Show();
            this.Close();
        }
    }
}
