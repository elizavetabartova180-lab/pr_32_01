using System;
using System.Windows;
using System.Windows.Controls;

namespace VinylRecordsApplication_Bartova.Pages.State
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        Classes.State changeState;

        public Add(Classes.State state = null)
        {
            InitializeComponent();
            if (state != null) { 
                this.changeState = state;
                this.tbName.Text = state.Name;
                this. tbSubname.Text = state.Subname;
                this.tbDescription.Text = state.Description;
                addBth.Content = "Изменить";
            }        
        }

        private void AddState(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(tbName.Text))
                if (!String.IsNullOrEmpty((tbSubname.Text)))
                {
                    if (this.changeState == null)
                    {
                        Classes.State newState = new Classes.State()
                        {
                            Name = tbName.Text,
                            Subname = tbSubname.Text,
                            Description = tbDescription.Text,
                        };
                        newState.Save();
                        MessageBox.Show($"Состояние{newState.Name} успешно добавлено.", "Уведомление");
                        MainWindow.mainWindow.OpenPage(new Pages.State.Add(newState));
                    }
                    else
                    {
                        changeState.Name = tbName.Text;
                        changeState.Subname = tbSubname.Text;
                        changeState.Description = tbDescription.Text;
                        changeState.Save(true);
                        MessageBox.Show($"Состояние{changeState.Name} успешно изменено.", "Уведомление");
                    }
                    
                }
                else
                        MessageBox.Show("Пожалуйста, укажите сокращённое наименование состояния", "Предупреждение");
            else
                MessageBox.Show("Пожалуйста, укажите сокращённое наименование состояния", "Предупреждение");
        }
    }
}
