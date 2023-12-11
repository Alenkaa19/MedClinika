using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Стомотология.БД;

namespace Стомотология
{
    /// <summary>
    /// Логика взаимодействия для ЗаписьНаПрием.xaml
    /// </summary>
    public partial class ЗаписьНаПрием : Window
    {
        //Присоединение БД
        public static ПоликлиникаEntities3 DataEntitiesУслуги { get; set; }
        public static ПоликлиникаEntities3 DataEntitiesВрач { get; set; }
        public ObservableCollection<Услуги> ListУслуги { get; set; }
        public ObservableCollection<Врач> ListВрач { get; set; }
        //private bool isDirty = true;


        //связь между БД и WPF
        public ЗаписьНаПрием()
        {
            InitializeComponent();
            DataEntitiesУслуги = new ПоликлиникаEntities3();
            DataEntitiesВрач = new ПоликлиникаEntities3();
            ListУслуги = new ObservableCollection<Услуги>();
            ListВрач = new ObservableCollection<Врач>();
            ПричинаПриема.ItemsSource = ПоликлиникаEntities3.GetContext().Услуги.ToList();
            Спициализация.ItemsSource = ПоликлиникаEntities3.GetContext().Врач.ToList();
        }
        //реализация выпадающего списка с услугами МедЦентра
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //isDirty = true;
            string title = ПричинаПриема.Text;
            DataEntitiesУслуги = new ПоликлиникаEntities3();
            ListУслуги.Clear();
            //Пациент title = ComboBoxTitle.SelectedItem as Пациент;
            var ЗаписьНаПрием = DataEntitiesУслуги.Услуги;
            var queryЗаписьНаПрием = from Услуги in ЗаписьНаПрием
                                     where Услуги.Услуга == title
                                     select Услуги;
            foreach (Услуги emp in queryЗаписьНаПрием)
            {
                ListУслуги.Add(emp);
            }
        }
        //реаализация кнопки записаться и осуществление перехода на страницу СписокТалонов
        private void КнопкаЗаписаться_Click(object sender, RoutedEventArgs e)
        {
            СписокТалонов form = new СписокТалонов();
            form.Show();
            this.Close();

        }
        //реализация выпадающего списка с специальностями врачей МедЦентра
        private void ComboBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            string title = Спициализация.Text;
            DataEntitiesВрач = new ПоликлиникаEntities3();
            ListВрач.Clear();
            //Пациент title = ComboBoxTitle.SelectedItem as Пациент;
            var ЗаписьНаПрием = DataEntitiesВрач.Врач;
            var queryЗаписьНаПрием = from Врач in ЗаписьНаПрием
                                     where Врач.Специальность == title
                                     select Врач;
            foreach (Врач em in queryЗаписьНаПрием)
            {
                ListВрач.Add(em);
            }
            
        }
    }
}
