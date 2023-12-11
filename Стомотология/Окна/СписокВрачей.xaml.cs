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
using Стомотология.БД;

namespace Стомотология
{
    /// <summary>
    /// Логика взаимодействия для СписокВрачей.xaml
    /// </summary>
    public partial class СписокВрачей : Window
    {
        //Привязка Бд и страниц
        public static ПоликлиникаEntities3 DataEntitiesВрач { get; set; }
        public ObservableCollection<Врач> ListВрач { get; set; }
        private bool isDirty = true;

        public СписокВрачей()
        {
            InitializeComponent();
            DataEntitiesВрач = new ПоликлиникаEntities3();
            ListВрач = new ObservableCollection<Врач>();
            Poo.ItemsSource = ПоликлиникаEntities3.GetContext().Врач.ToList();
            Po.ItemsSource = ПоликлиникаEntities3.GetContext().Врач.ToList();
            ComboBoxTitle.ItemsSource = ПоликлиникаEntities3.GetContext().Врач.ToList();
        }
        //Метод получения данных из БД
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var Врач = DataEntitiesВрач.Врач; //связываем нужную таблицу в БД 
            var queryСписокВрачей = from СписокВрачей in Врач
                                       orderby СписокВрачей.Фамилия //Определяем по чему связываем
                                    select СписокВрачей;
            foreach (Врач pac in queryСписокВрачей)
            {
                ListВрач.Add(pac);
            }
            DataGridBol.ItemsSource = ListВрач; //выводим полученные данные

        }
        //Метод получения данных из БД
        private void GetСписокВрачей()
        {
            var СписокВрачей = DataEntitiesВрач.Врач; //связываем нужную таблицу в БД 
            var queryСписокВрачей = from Врач in СписокВрачей
                                       orderby Врач.КодВрача //Определяем по чему связываем
                                    select Врач;
            foreach (Врач pac in queryСписокВрачей)
            {
                ListВрач.Add(pac);
            }
            DataGridBol.ItemsSource = ListВрач; //выводим полученные данные
        }
        // Перепесование данных из бд в WPF
        private void RewriteСписокВрачей()
        {
            DataEntitiesВрач = new ПоликлиникаEntities3();
            ListВрач.Clear();
            GetСписокВрачей();
        }
        //Реализация команды удалить
        private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Врач список = DataGridBol.SelectedItem as Врач;
            if (список != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные ", "Предупреждение", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    DataEntitiesВрач.Врач.Remove(список);
                    DataGridBol.SelectedIndex = DataGridBol.SelectedIndex == 0 ? 1 : DataGridBol.SelectedIndex - 1;
                    ListВрач.Remove(список);
                    DataEntitiesВрач.SaveChanges();
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
        //Реализация команды редактировать
        private void EditCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;

        }
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
                DataEntitiesВрач.SaveChanges();
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
            RewriteСписокВрачей();
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
            var СписокВрачей = new Врач();
            СписокВрачей.Фамилия = "не задано";
            СписокВрачей.Имя = "не задано";
            СписокВрачей.Отчество = "не задано";
            СписокВрачей.Категория = "не задано";
            СписокВрачей.Специальность = "не задано";
            СписокВрачей.Расписание = "не задано";
            try
            {
                DataGridBol.IsReadOnly = false;
                DataGridBol.BeginEdit();
                DataEntitiesВрач.Врач.Add(СписокВрачей);
                ListВрач.Add(СписокВрачей);
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
            RewriteСписокВрачей();
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
            DataEntitiesВрач = new ПоликлиникаEntities3();
            ListВрач.Clear();
            var СписокВрачей = DataEntitiesВрач.Врач;
            var queryСписокВрачей = from Врач in СписокВрачей
                                       where Врач.Фамилия == surname
                                       select Врач;
            foreach (Врач pac in queryСписокВрачей)
            {
                ListВрач.Add(pac);
            }
            if (ListВрач.Count > 0)
            {
                DataGridBol.ItemsSource = ListВрач;
                ButtonFindSurname.IsEnabled = true;
                ButtonFindTitle.IsEnabled = false;
            }
            else
                MessageBox.Show("Врач с фамилией \n" + surname + "\n не найден", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        //реализация кнопки поиска
        private void ComboBoxTitle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonFindTitle.IsEnabled = true;
            ButtonFindSurname.IsEnabled = false;
            TextBoxSurname.Text = "";
        }
        //реализация поиска по специальности
        private void ButtonFindTitle_Click(object sender, RoutedEventArgs e)
        {
            string title = ComboBoxTitle.Text;
            DataEntitiesВрач = new ПоликлиникаEntities3();
            ListВрач.Clear();
            //Врач title = ComboBoxTitle.SelectedItem as Врач;
            var СписокВрачей = DataEntitiesВрач.Врач;
            var queryСписокВрачей = from Врач in СписокВрачей
                                       where Врач.Специальность == title
                                       select Врач;
            foreach (Врач emp in queryСписокВрачей)
            {
                ListВрач.Add(emp);
            }
            DataGridBol.ItemsSource = ListВрач;
            if (ListВрач.Count < 0)
            {
                DataGridBol.ItemsSource = ListВрач;
                ButtonFindSurname.IsEnabled = false;
                ButtonFindTitle.IsEnabled = true;
                MessageBox.Show("Врач  \n" + title + "\n не найден", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {

            }
        }

        private void DataGridBol_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
