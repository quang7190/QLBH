using Reamke.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.ComponentModel;
using System.Timers;
using System.Windows;

namespace Reamke.ViewModel
{
    public class SellViewModel : BaseViewModel
    {
        private ObservableCollection<GioHang> _ListGH;
        public ObservableCollection<GioHang> ListGH { get => _ListGH; set { _ListGH = value; OnPropertyChanged(); } }
        private GioHang _SelectedItem;
        public GioHang SelectedItem { get => _SelectedItem; set { _SelectedItem = value; OnPropertyChanged(); } }
        private Nullable<double> _Total;
        public Nullable<double> Total { get => _Total; set { _Total = value; OnPropertyChanged(); } }
        private string _Number;
        public string Number { get => _Number; set { _Number = value; OnPropertyChanged(); } }
        public ICommand CanhGa { get; set; }
        public ICommand DuiGa { get; set; }
        public ICommand UcGa { get; set; }
        public ICommand PhaoCau { get; set; }
        public ICommand NuaCon { get; set; }
        public ICommand NguyenCon { get; set; }
        public ICommand DauCanh { get; set; }
        public ICommand Dui14 { get; set; }
        public ICommand ChanGa { get; set; }
        public ICommand ThanhToan { get; set; }
        public ICommand XoaGH { get; set; }
        public SellViewModel()
        {
            ListGH = new ObservableCollection<GioHang>(DataProvider.Ins.DB.GioHangs);

            CanhGa = new RelayCommand<object>((p) =>
            {
                var numberIP = Int64.Parse(Number);
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 1).FirstOrDefault();
                if (ga.SoLuong == 0 || (int?)numberIP > ga.SoLuong)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 1).FirstOrDefault();
                if (string.IsNullOrEmpty(Number))
                {
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * 1 };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong--;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 1).FirstOrDefault();
                        addsp.SoLuong++;
                        ga.SoLuong--;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
                else
                {
                    var numberIP = Int64.Parse(Number);
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = (int?)numberIP, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * (int?)numberIP };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 1).FirstOrDefault();
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        addsp.SoLuong = addsp.SoLuong + (int?)numberIP;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
            }
            );

            DuiGa = new RelayCommand<object>((p) =>
            {
                var numberIP = Int64.Parse(Number);
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 4).FirstOrDefault();
                if (ga.SoLuong == 0 || (int?)numberIP > ga.SoLuong)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 4).FirstOrDefault();
                if (string.IsNullOrEmpty(Number))
                {
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * 1 };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong--;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 4).FirstOrDefault();
                        addsp.SoLuong++;
                        ga.SoLuong--;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
                else
                {
                    var numberIP = Int64.Parse(Number);
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = (int?)numberIP, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * (int?)numberIP };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 4).FirstOrDefault();
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        addsp.SoLuong = addsp.SoLuong + (int?)numberIP;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
            }
            );

            UcGa = new RelayCommand<object>((p) =>
            {
                var numberIP = Int64.Parse(Number);
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 5).FirstOrDefault();
                if (ga.SoLuong == 0 || (int?)numberIP > ga.SoLuong)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 5).FirstOrDefault();
                if (string.IsNullOrEmpty(Number))
                {
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * 1 };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong--;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 5).FirstOrDefault();
                        addsp.SoLuong++;
                        ga.SoLuong--;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
                else
                {
                    var numberIP = Int64.Parse(Number);
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = (int?)numberIP, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * (int?)numberIP };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 5).FirstOrDefault();
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        addsp.SoLuong = addsp.SoLuong + (int?)numberIP;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
            }
            );

            PhaoCau = new RelayCommand<object>((p) =>
            {
                var numberIP = Int64.Parse(Number);
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 7).FirstOrDefault();
                if (ga.SoLuong == 0 || (int?)numberIP > ga.SoLuong)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 7).FirstOrDefault();
                if (string.IsNullOrEmpty(Number))
                {
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * 1 };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong--;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 7).FirstOrDefault();
                        addsp.SoLuong++;
                        ga.SoLuong--;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
                else
                {
                    var numberIP = Int64.Parse(Number);
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = (int?)numberIP, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * (int?)numberIP };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 7).FirstOrDefault();
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        addsp.SoLuong = addsp.SoLuong + (int?)numberIP;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
            }
            );

            Dui14 = new RelayCommand<object>((p) =>
            {
                var numberIP = Int64.Parse(Number);
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 8).FirstOrDefault();
                if (ga.SoLuong == 0 || (int?)numberIP > ga.SoLuong)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 8).FirstOrDefault();
                if (string.IsNullOrEmpty(Number))
                {
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * 1 };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong--;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 8).FirstOrDefault();
                        addsp.SoLuong++;
                        ga.SoLuong--;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
                else
                {
                    var numberIP = Int64.Parse(Number);
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = (int?)numberIP, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * (int?)numberIP };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 8).FirstOrDefault();
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        addsp.SoLuong = addsp.SoLuong + (int?)numberIP;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
            }
            );

            NuaCon = new RelayCommand<object>((p) =>
            {
                var numberIP = Int64.Parse(Number);
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 9).FirstOrDefault();
                if (ga.SoLuong == 0 || (int?)numberIP > ga.SoLuong)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 1).FirstOrDefault();
                if (string.IsNullOrEmpty(Number))
                {
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 9, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * 1 };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong--;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 9).FirstOrDefault();
                        addsp.SoLuong++;
                        ga.SoLuong--;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
                else
                {
                    var numberIP = Int64.Parse(Number);
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = (int?)numberIP, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * (int?)numberIP };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 9).FirstOrDefault();
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        addsp.SoLuong = addsp.SoLuong + (int?)numberIP;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
            }
            );

            NguyenCon = new RelayCommand<object>((p) =>
            {
                var numberIP = Int64.Parse(Number);
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 10).FirstOrDefault();
                if (ga.SoLuong == 0 || (int?)numberIP > ga.SoLuong)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 10).FirstOrDefault();
                if (string.IsNullOrEmpty(Number))
                {
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * 1 };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong--;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 10).FirstOrDefault();
                        addsp.SoLuong++;
                        ga.SoLuong--;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
                else
                {
                    var numberIP = Int64.Parse(Number);
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = (int?)numberIP, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * (int?)numberIP };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 10).FirstOrDefault();
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        addsp.SoLuong = addsp.SoLuong + (int?)numberIP;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
            }
            );

            DauCanh = new RelayCommand<object>((p) =>
            {
                var numberIP = Int64.Parse(Number);
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 11).FirstOrDefault();
                if (ga.SoLuong == 0 || (int?)numberIP > ga.SoLuong)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 11).FirstOrDefault();
                if (string.IsNullOrEmpty(Number))
                {
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * 1 };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong--;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 11).FirstOrDefault();
                        addsp.SoLuong++;
                        ga.SoLuong--;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
                else
                {
                    var numberIP = Int64.Parse(Number);
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = (int?)numberIP, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * (int?)numberIP };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 11).FirstOrDefault();
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        addsp.SoLuong = addsp.SoLuong + (int?)numberIP;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
            }
            );

            ChanGa = new RelayCommand<object>((p) =>
            {
                var numberIP = Int64.Parse(Number);
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 12).FirstOrDefault();
                if (ga.SoLuong == 0 || (int?)numberIP > ga.SoLuong)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 12).FirstOrDefault();
                if (string.IsNullOrEmpty(Number))
                {
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * 1 };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong--;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 12).FirstOrDefault();
                        addsp.SoLuong++;
                        ga.SoLuong--;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
                else
                {
                    var numberIP = Int64.Parse(Number);
                    var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = (int?)numberIP, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham, TongGia = ga.DonGia * (int?)numberIP };
                    var giohang = ga.GioHangs.Count();
                    if (giohang == 0)
                    {
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        DataProvider.Ins.DB.GioHangs.Add(sp);
                        DataProvider.Ins.DB.SaveChanges();
                        ListGH.Add(sp);
                    }
                    else
                    {
                        var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 12).FirstOrDefault();
                        ga.SoLuong = ga.SoLuong - (int?)numberIP;
                        addsp.SoLuong = addsp.SoLuong + (int?)numberIP;
                        addsp.TongGia = addsp.SoLuong * addsp.DonGia;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                }
            }
            );

            ThanhToan = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                {
                    return false;
                }
                return true;
            }, (p) =>
            {
                var totalQ = 0;
                var totalP = 0;
                foreach (var item in ListGH)
                {
                    totalQ += (int)item.SoLuong;
                    totalP += (int)item.TongGia;
                }
                var hd = new HoaDon { TongSoLuong = totalQ, TongTien = totalP, NgayLap = DateTime.Now };
                DataProvider.Ins.DB.HoaDons.Add(hd);
                DataProvider.Ins.DB.SaveChanges();
                foreach (var item in ListGH)
                {
                    var cthd = new ChiTietHD { IDHoaDon = hd.IDHoaDon, IDSanPham = item.IDSanPham, DonGia = item.DonGia, SoLuong = item.SoLuong };
                    DataProvider.Ins.DB.ChiTietHDs.Add(cthd);
                    DataProvider.Ins.DB.SaveChanges();
                }
                foreach (var item in ListGH)
                {
                    DataProvider.Ins.DB.GioHangs.Remove(item);
                }
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Đặt hàng thành công");
                ListGH.Clear();
            }
           );

            XoaGH = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                foreach (var item in ListGH)
                {
                    var remove = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == item.IDSanPham).FirstOrDefault();
                    remove.SoLuong = remove.SoLuong + item.SoLuong;;
                    DataProvider.Ins.DB.SaveChanges();
                    DataProvider.Ins.DB.GioHangs.Remove(item);
                }
                DataProvider.Ins.DB.SaveChanges();
                ListGH.Clear();

            }
           );


            Total = 0;
            foreach (var item in ListGH)
            {
                Total += item.TongGia;

            }


        }
    }

    public class Ticker : INotifyPropertyChanged
    {
        public Ticker()
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second updates
            timer.Elapsed += timer_Elapsed;
            timer.Start();
        }

        public DateTime Now
        {
            get { return DateTime.Now; }
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("Now"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

