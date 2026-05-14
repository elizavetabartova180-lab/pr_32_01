using System.Collections.Generic;
using System.Windows.Controls;

namespace VinylRecordsApplication_Bartova.Pages.State
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public IEnumerable<Classes.State> AllState = Classes.State.AllState();
        public Main()
        {
            InitializeComponent();
            foreach (var State in AllState)
                stateParent.Children.Add(new Pages.State.Elements.State(State, this));
        }
    }
}
