using Reamke.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Reamke.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool IsLoaded = false;
        public ICommand LoadedWindow { get; set; }
        public ICommand OrderWindow { get; set; }
        public ICommand CheckWindow { get; set; }
        public MainViewModel()
        {
            LoadedWindow = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                IsLoaded = true;
                if (p == null)
                {
                    return;
                }
                p.Hide();
                Login lg = new Login();
                lg.ShowDialog();
                if (lg.DataContext == null)
                {
                    return;
                }
                var loginVM = lg.DataContext as LoginViewModel;

                if (loginVM.IsLogin)
                {
                    p.Show();
                }
                else
                {
                    p.Close();
                }
            }
            );

            OrderWindow = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                IsLoaded = true;
                Sell sl = new Sell();
                sl.ShowDialog();
            }
            );

            CheckWindow = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                IsLoaded = true;
                Bill bl = new Bill();
                bl.Show();
            }
            );

        }
    }
}
