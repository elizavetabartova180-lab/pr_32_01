using System.Collections.Generic;
using System.Windows.Controls;

namespace VinylRecordsApplication_Bartova.Pages.Manufacturer
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public IEnumerable<Classes.Manufacturer> AllManufacturers = Classes.Manufacturer.AllManufacturers();
        public Main()
        {
            InitializeComponent();
            foreach(Classes.Manufacturer manufacturer in AllManufacturers)
                manufacterParent.Children.Add(new Manufacturer.Elements.Manufacturer(manufacturer, this));
        }
    }
}
