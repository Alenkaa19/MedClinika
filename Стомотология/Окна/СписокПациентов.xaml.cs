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
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Objects;
using Стомотология;
using Стомотология.БД;

namespace Стомотология
{
    /// <summary>
    /// Логика взаимодействия для СписокПациентов.xaml
    /// </summary>
    public partial class СписокПациентов : Window
    {
        //Привязка Бд и страниц
        public static ПоликлиникаEntities3 DataEntitiesПациент { get; set; }
        public ObservableCollection<Пациент> ListПациент { get; set; }
        private bool isDirty = true;

        public СписокПациентов()
        {
            InitializeComponent();
            DataEntitiesПациент = new ПоликлиникаEntities3();
            ListПациент = new ObservableCollection<Пациент>();
            Poo.ItemsSource = ПоликлиникаEntities3.GetContext().Пациент.ToList();
            ComboBoxTitle.ItemsSource = ПоликлиникаEntities3.GetContext().Пациент.ToList();
        }
        //Метод получения данных из БД
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var Пациент = DataEntitiesПациент.Пациент; //связываем нужную таблицу в БД 
            var queryСписокПациентов = from  СписокПациентов in Пациент
                                       orderby СписокПациентов.Фамилия //Определяем по чему связываем
                                       select СписокПациентов;
            foreach (Пациент pac in queryСписокПациентов)
            {
                ListПациент.Add(pac);
            }
            DataGridBol.ItemsSource = ListПациент; //выводим полученные данные

        }
        //Метод получения данных из БД
        private void GetСписокПациентов()
        {
            var СписокПациентов = DataEntitiesПациент.Пациент; //связываем нужную таблицу в БД 
            var queryСписокПациентов = from Пациент in СписокПациентов
                                       orderby Пациент.НомерМедКарты //Определяем по чему связываем
                                       select Пациент;
            foreach (Пациент pac in queryСписокПациентов)
            {
                ListПациент.Add(pac);
            }
            DataGridBol.ItemsSource = ListПациент; //выводим полученные данные
        }
        // Перепесование данных из бд в WPF
        private void RewriteСписокПациентов()
        {
            DataEntitiesПациент = new ПоликлиникаEntities3();
            ListПациент.Clear();
            GetСписокПациентов();
        }
        //Реализация команды удалить
        private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Пациент список = DataGridBol.SelectedItem as Пациент;
            if (список != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные ", "Предупреждение", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    DataEntitiesПациент.Пациент.Remove(список);
                    DataGridBol.SelectedIndex = DataGridBol.SelectedIndex == 0 ? 1 : DataGridBol.SelectedIndex - 1;
                    ListПациент.Remove(список);
                    DataEntitiesПациент.SaveChanges();
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
                DataEntitiesПациент.SaveChanges();
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
            RewriteСписокПациентов();
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
            var СписокПациентов = new Пациент();
            СписокПациентов.НомерМедКарты = +1;
            СписокПациентов.Фамилия = "не задано";
            СписокПациентов.Имя = "не задано";
            СписокПациентов.Отчество = "не задано";
            СписокПациентов.ДатаРождения = DateTime.ParseExact("08.03.1998", "dd/MM/yyyy", null);
            СписокПациентов.Пол = "не задано";
            СписокПациентов.Почта = "не задано";
            try
            {
                DataGridBol.IsReadOnly = false;
                DataGridBol.BeginEdit();
                DataEntitiesПациент.Пациент.Add(СписокПациентов);
                ListПациент.Add(СписокПациентов);
                isDirty = false;
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
        private void FindCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }
        //Реализация поиска
        private void FindCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            BorderFind.Visibility = Visibility.Visible;
        }
        private void RefreshCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RewriteСписокПациентов();
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
        //реализация поиска по фамилии
        private void ButtonFindSurname_Click(object sender, RoutedEventArgs e)
        {
            string surname = TextBoxSurname.Text;
            DataEntitiesПациент = new ПоликлиникаEntities3();
            ListПациент.Clear();
            var СписокПациентов = DataEntitiesПациент.Пациент;
            var queryСписокПациентов = from Пациент in СписокПациентов
                                       where Пациент.Фамилия == surname
                                       select Пациент;
            foreach (Пациент pac in queryСписокПациентов)
            {
                ListПациент.Add(pac);
            }
            if (ListПациент.Count > 0)
            {
                DataGridBol.ItemsSource = ListПациент;
                ButtonFindSurname.IsEnabled = true;
                ButtonFindTitle.IsEnabled = false;
            }
            else
                MessageBox.Show("Пациент с фамилией \n" + surname + "\n не найден", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        //выпадающий список поиска
        private void ComboBoxTitle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonFindTitle.IsEnabled = true;
            ButtonFindSurname.IsEnabled = false;
            TextBoxSurname.Text = "";
        }
        //реализация поиска по месту регистрации
        private void ButtonFindTitle_Click(object sender, RoutedEventArgs e)
        {
            string title = ComboBoxTitle.Text;
            DataEntitiesПациент = new ПоликлиникаEntities3();
            ListПациент.Clear();
            //Пациент title = ComboBoxTitle.SelectedItem as Пациент;
            var СписокПациентов = DataEntitiesПациент.Пациент;
            var queryСписокПациентов = from Пациент in СписокПациентов
                                       where Пациент.МестоРегистрации == title
                                       select Пациент;
            foreach (Пациент emp in queryСписокПациентов)
            {
                ListПациент.Add(emp);
            }
            DataGridBol.ItemsSource = ListПациент;
            if (ListПациент.Count < 0)
            {
                DataGridBol.ItemsSource = ListПациент;
                ButtonFindSurname.IsEnabled = false;
                ButtonFindTitle.IsEnabled = true;
                
            }
            else
            {
                MessageBox.Show("Пациент из  \n" + title + "\n не найден", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
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
