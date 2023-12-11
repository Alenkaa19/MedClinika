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
    /// Логика взаимодействия для СписокДиагнозов.xaml
    /// </summary>
    public partial class СписокДиагнозов : Window
    {
        //Привязка Бд и страниц
        public static ПоликлиникаEntities3 DataEntitiesДиагноз { get; set; }
        public ObservableCollection<Диагноз> ListДиагноз { get; set; }
        private bool isDirty = true;

        public СписокДиагнозов()
        {
            InitializeComponent();
            DataEntitiesДиагноз = new ПоликлиникаEntities3();
            ListДиагноз = new ObservableCollection<Диагноз>();
        }
        //Метод получения данных из БД
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var Диагноз = DataEntitiesДиагноз.Диагноз; //связываем нужную таблицу в БД 
            var queryСписокДиагнозов = from СписокДиагнозов in Диагноз
                                    orderby СписокДиагнозов.Наименование //Определяем по чему связываем
                                       select СписокДиагнозов;
            foreach (Диагноз pac in queryСписокДиагнозов)
            {
                ListДиагноз.Add(pac);
            }
            DataGridBol.ItemsSource = ListДиагноз; //выводим полученные данные

        }
        //Метод получения данных из БД
        private void GetСписокДиагнозов()
        {
            var СписокДиагнозов = DataEntitiesДиагноз.Диагноз; //связываем нужную таблицу в БД 
            var queryСписокДиагнозов = from Диагноз in СписокДиагнозов
                                    orderby Диагноз.КодДиагноза //Определяем по чему связываем
                                       select Диагноз;
            foreach (Диагноз pac in queryСписокДиагнозов)
            {
                ListДиагноз.Add(pac);
            }
            DataGridBol.ItemsSource = ListДиагноз; //выводим полученные данные
        }
        // Перепесование данных из бд в WPF
        private void RewriteСписокДиагнозов()
        {
            DataEntitiesДиагноз = new ПоликлиникаEntities3();
            ListДиагноз.Clear();
            GetСписокДиагнозов();
        }
        //Реализация команды удалить
        private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Диагноз список = DataGridBol.SelectedItem as Диагноз;
            if (список != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные ", "Предупреждение", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    DataEntitiesДиагноз.Диагноз.Remove(список);
                    DataGridBol.SelectedIndex = DataGridBol.SelectedIndex == 0 ? 1 : DataGridBol.SelectedIndex - 1;
                    ListДиагноз.Remove(список);
                    DataEntitiesДиагноз.SaveChanges();
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
                DataEntitiesДиагноз.SaveChanges();
                DataGridBol.IsReadOnly = true;
                isDirty = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Сохранено");
        }
        private void SaveCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }
        //Реализация команды обновить
        private void UndoCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            RewriteСписокДиагнозов();
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
            var СписокДиагнозов = new Диагноз();
            СписокДиагнозов.КодДиагноза = +1;
            СписокДиагнозов.Наименование = "не задано";
            try
            {
                DataGridBol.IsReadOnly = false;
                DataGridBol.BeginEdit();
                DataEntitiesДиагноз.Диагноз.Add(СписокДиагнозов);
                ListДиагноз.Add(СписокДиагнозов);
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
            RewriteСписокДиагнозов();
            DataGridBol.IsReadOnly = false;
            isDirty = true;
            BorderFind.Visibility = Visibility.Hidden;
        }
        //поиск по наименованию
        private void TextBoxSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            ButtonFindSurname.IsEnabled = true;
           
        }
        //реализация поиска по наименованию
        private void ButtonFindSurname_Click(object sender, RoutedEventArgs e)
        {
            string surname = TextBoxSurname.Text;
            DataEntitiesДиагноз = new ПоликлиникаEntities3();
            ListДиагноз.Clear();
            var СписокДиагнозов = DataEntitiesДиагноз.Диагноз;
            var queryСписокДиагнозов = from Диагноз in СписокДиагнозов
                                    where Диагноз.Наименование == surname
                                    select Диагноз;
            foreach (Диагноз pac in queryСписокДиагнозов)
            {
                ListДиагноз.Add(pac);
            }
            if (ListДиагноз.Count > 0)
            {
                DataGridBol.ItemsSource = ListДиагноз;
                ButtonFindSurname.IsEnabled = true;
               ;
            }
            else
                MessageBox.Show("Диагноз с \n" + surname + "\n не найден", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        //кнопка поиска
        private void ComboBoxTitle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonFindSurname.IsEnabled = false;
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
