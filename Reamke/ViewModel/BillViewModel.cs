using Reamke.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reamke.ViewModel
{
    public class BillViewModel : BaseViewModel
    {
        private ObservableCollection<HoaDon> _ListHD;
        public ObservableCollection<HoaDon> ListHD { get => _ListHD; set { _ListHD = value; OnPropertyChanged(); } }

        private HoaDon _SelectDate;
        public HoaDon SelectDate { get => _SelectDate; set { _SelectDate = value; OnPropertyChanged(); } }

        private HoaDon _Date;
        public HoaDon Date { get => _Date; set { _Date = value; OnPropertyChanged(); } }
        public BillViewModel()
        {
            ListHD = new ObservableCollection<HoaDon>(DataProvider.Ins.DB.HoaDons);
            int Count = 0;
            Count = DataProvider.Ins.DB.HoaDons.Count();
        }
    }
}
