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
using VinylRecordsApplication_Bartova.Classes;

namespace VinylRecordsApplication_Bartova.Pages.Records
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public IEnumerable<Classes.State> AllState = Classes.State.AllState();
        public IEnumerable<Classes.Record> AllRecords = Classes.Record.AllRecords();
        public IEnumerable<Classes.Manufacturer> AllManufacturers = Classes.Manufacturer.AllManufacturers();
        private bool CreateUI = false;
        public List<Classes.Record> searchRecords;
        public Main()
        {
            InitializeComponent();
            searchRecords = AllRecords.ToList();
            CreateUI = true;
            LoadAllRecord(AllRecords.ToList());
            LoadAllManufacture();
            LoadAllState();
        }
        public void LoadRecord()
        {
            AllRecords = Classes.Record.AllRecords();
            LoadAllRecord(AllRecords.ToList());
        }
        public void LoadAllState()
        {
            tbState.Items.Clear();
            foreach(var state in AllState)
                tbState.Items.Add(state.Name);
            tbState.Items.Add("Выберите...");
            tbState.SelectedIndex = tbState.Items.Count - 1;
        }

        public void LoadAllManufacture()
        {
            tbManufacturer.Items.Clear();
            foreach(var manufscturer in AllManufacturers)
                tbManufacturer.Items.Add(manufscturer.Name);
            tbManufacturer.Items.Add("Выберите...");
            tbManufacturer.SelectedIndex = tbManufacturer.Items.Count - 1;
        }

        public void LoadAllRecord(List<Classes.Record> AllRecords)
        {
            recordsParent.Children.Clear();
            foreach(var record in AllRecords)
                recordsParent.Children.Add(new Pages.Records.Elements.Record(record, this));
        }
        public void RecordFilter()
        {
            List<Classes.Record> FilterRecords = new List<Classes.Record>();
            if (tbManufacturer.SelectedIndex != tbManufacturer.Items.Count -1)

        }
        private void FilterRecords(object sender, SelectionChangedEventArgs e)
        {
            if (CreateUI)
                RecordFilter();
        }
        private void SearchRecords(object sender, KeyEventArgs e) =>
            RecordFilter();



    }
}
