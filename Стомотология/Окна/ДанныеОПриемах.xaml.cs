using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
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
    /// Логика взаимодействия для ДанныеОПриемах.xaml
    /// </summary>
    public partial class ДанныеОПриемах : Window
    {
        //Привязка Бд и страниц
        public static ПоликлиникаEntities3 DataEntitiesПрием { get; set; }
        public ObservableCollection<Прием> ListПрием { get; set; }
        private bool isDirty = true;
        public ДанныеОПриемах()
        {
            InitializeComponent();
            DataEntitiesПрием = new ПоликлиникаEntities3();
            ListПрием = new ObservableCollection<Прием>();
            Po.ItemsSource = ПоликлиникаEntities3.GetContext().Прием.ToList();
        }
        //Метод получения данных из БД
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var Прием = DataEntitiesПрием.Прием; //связываем нужную таблицу в БД 
            var queryДанныеОПриемах = from ДанныеОПриемах in Прием
                                       orderby ДанныеОПриемах.КодПриема //Определяем по чему связываем
                                       select ДанныеОПриемах;
            foreach (Прием pac in queryДанныеОПриемах)
            {
                ListПрием.Add(pac);
            }
            DataGridBol.ItemsSource = ListПрием; //выводим полученные данные

        }
        //Метод получения данных из БД
        private void GetДанныеОПриемах()
        {
            var ДанныеОПриемах = DataEntitiesПрием.Прием;  //связываем нужную таблицу в БД 
            var queryДанныеОПриемах = from Прием in ДанныеОПриемах
                                      orderby Прием.Прием1 //Определяем по чему связываем
                                      select Прием;
            foreach (Прием pac in queryДанныеОПриемах)
            {
                ListПрием.Add(pac);
            }
            DataGridBol.ItemsSource = ListПрием; //выводим полученные данные
        }
        // Перепесование данных из бд в WPF
        private void RewriteДанныеОПриемах()
        {
            DataEntitiesПрием = new ПоликлиникаEntities3() ;
            ListПрием.Clear();
            GetДанныеОПриемах();
        }
        //Реализация команды удалить
        private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Прием список = DataGridBol.SelectedItem as Прием;
            if (список != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные ", "Предупреждение", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    DataEntitiesПрием.Прием.Remove(список);
                    DataGridBol.SelectedIndex = DataGridBol.SelectedIndex == 0 ? 1 : DataGridBol.SelectedIndex - 1;
                    ListПрием.Remove(список);
                    DataEntitiesПрием.SaveChanges();
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
                DataEntitiesПрием.SaveChanges();
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
            RewriteДанныеОПриемах();
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
            //описываем наши переменные
            var ДанныеОПриемах = new Прием();
            ДанныеОПриемах.ДатаПриема = DateTime.ParseExact("08.03.1998", "dd.MM.yyyy", null);
            ДанныеОПриемах.Прием1 = "не задано";
            ДанныеОПриемах.Стоимость =0;
            try
            {
                DataGridBol.IsReadOnly = false;
                DataGridBol.BeginEdit();
                DataEntitiesПрием.Прием.Add(ДанныеОПриемах);
                ListПрием.Add(ДанныеОПриемах);
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
            RewriteДанныеОПриемах();
            DataGridBol.IsReadOnly = false;
            isDirty = true;
            BorderFind.Visibility = Visibility.Hidden;
        }

        private void RewriteДанныеОПриеме()
        {
            throw new NotImplementedException();
        }
        //поиск по дате
        private void TextBoxSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            ButtonFindSurname.IsEnabled = true;
            ComboBoxTitle.SelectedIndex = -1;
        }
        //реализация поиска по дате
        private void ButtonFindSurname_Click(object sender, RoutedEventArgs e)
        {
            string surname = TextBoxSurname.Text;
            DataEntitiesПрием = new ПоликлиникаEntities3();
            ListПрием.Clear();
            var ДанныеОПриемах = DataEntitiesПрием.Прием;
            var queryДанныеОПриемах = from Прием in ДанныеОПриемах
                                       where Прием.ДатаПриема == DateTime.MinValue
                                       select Прием;
            foreach (Прием pac in queryДанныеОПриемах)
            {
                ListПрием.Add(pac);
            }
            if (ListПрием.Count > 0)
            {
                DataGridBol.ItemsSource = ListПрием;
                ButtonFindSurname.IsEnabled = true;
            }
            else
                MessageBox.Show("Прием \n" + surname + "\n не найден", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        //выпадающий список поиска
        private void ComboBoxTitle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonFindSurname.IsEnabled = false;
            TextBoxSurname.Text = "";
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

