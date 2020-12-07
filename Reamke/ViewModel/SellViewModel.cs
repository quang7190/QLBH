using Reamke.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;

namespace Reamke.ViewModel
{
    public class SellViewModel : BaseViewModel
    {
        private ObservableCollection<GioHang> _ListGH;
        public ObservableCollection<GioHang> ListGH { get => _ListGH; set { _ListGH = value; OnPropertyChanged(); } }
        public ICommand CanhGa { get; set; }
        public ICommand DuiGa { get; set; }
        public ICommand UcGa { get; set; }
        public ICommand PhaoCau { get; set; }
        public ICommand NuaCon { get; set; }
        public ICommand NguyenCon { get; set; }
        public ICommand DauCanh { get; set; }
        public ICommand Dui14 { get; set; }
        public ICommand ChanGa { get; set; }

        public SellViewModel()
        {
            ListGH = new ObservableCollection<GioHang>(DataProvider.Ins.DB.GioHangs);

            CanhGa = new RelayCommand<object>((p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 1).FirstOrDefault();
                if (ga.SoLuong == 0)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 1).FirstOrDefault();
                var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham };
                var giohang = ga.GioHangs.Count();
                if (giohang == 0)
                {
                    DataProvider.Ins.DB.GioHangs.Add(sp);
                    DataProvider.Ins.DB.SaveChanges();
                    ListGH.Add(sp);
                }
                else
                {
                    var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 1).FirstOrDefault();
                    addsp.SoLuong++;
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
            );

            DuiGa = new RelayCommand<object>((p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 4).FirstOrDefault();
                if (ga.SoLuong == 0)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 4).FirstOrDefault();
                var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham };
                var giohang = ga.GioHangs.Count();
                if (giohang == 0)
                {
                    DataProvider.Ins.DB.GioHangs.Add(sp);
                    DataProvider.Ins.DB.SaveChanges();
                    ListGH.Add(sp);
                }
                else
                {
                    var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 4).FirstOrDefault();
                    addsp.SoLuong++;
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
           );

            UcGa = new RelayCommand<object>((p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 5).FirstOrDefault();
                if (ga.SoLuong == 0)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 5).FirstOrDefault();
                var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham };
                var giohang = ga.GioHangs.Count();
                if (giohang == 0)
                {
                    DataProvider.Ins.DB.GioHangs.Add(sp);
                    DataProvider.Ins.DB.SaveChanges();
                    ListGH.Add(sp);
                }
                else
                {
                    var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 5).FirstOrDefault();
                    addsp.SoLuong++;
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
           );

            PhaoCau = new RelayCommand<object>((p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 7).FirstOrDefault();
                if (ga.SoLuong == 0)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 7).FirstOrDefault();
                var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham };
                var giohang = ga.GioHangs.Count();
                if (giohang == 0)
                {
                    DataProvider.Ins.DB.GioHangs.Add(sp);
                    DataProvider.Ins.DB.SaveChanges();
                    ListGH.Add(sp);
                }
                else
                {
                    var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 7).FirstOrDefault();
                    addsp.SoLuong++;
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
           );

            Dui14 = new RelayCommand<object>((p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 8).FirstOrDefault();
                if (ga.SoLuong == 0)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 8).FirstOrDefault();
                var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham };
                var giohang = ga.GioHangs.Count();
                if (giohang == 0)
                {
                    DataProvider.Ins.DB.GioHangs.Add(sp);
                    DataProvider.Ins.DB.SaveChanges();
                    ListGH.Add(sp);
                }
                else
                {
                    var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 8).FirstOrDefault();
                    addsp.SoLuong++;
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
           );

            NuaCon = new RelayCommand<object>((p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 9).FirstOrDefault();
                if (ga.SoLuong == 0)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 9).FirstOrDefault();
                var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham };
                var giohang = ga.GioHangs.Count();
                if (giohang == 0)
                {
                    DataProvider.Ins.DB.GioHangs.Add(sp);
                    DataProvider.Ins.DB.SaveChanges();
                    ListGH.Add(sp);
                }
                else
                {
                    var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 9).FirstOrDefault();
                    addsp.SoLuong++;
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
           );

            NguyenCon = new RelayCommand<object>((p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 10).FirstOrDefault();
                if (ga.SoLuong == 0)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 10).FirstOrDefault();
                var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham };
                var giohang = ga.GioHangs.Count();
                if (giohang == 0)
                {
                    DataProvider.Ins.DB.GioHangs.Add(sp);
                    DataProvider.Ins.DB.SaveChanges();
                    ListGH.Add(sp);
                }
                else
                {
                    var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 10).FirstOrDefault();
                    addsp.SoLuong++;
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
           );

            DauCanh = new RelayCommand<object>((p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 11).FirstOrDefault();
                if (ga.SoLuong == 0)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 11).FirstOrDefault();
                var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham };
                var giohang = ga.GioHangs.Count();
                if (giohang == 0)
                {
                    DataProvider.Ins.DB.GioHangs.Add(sp);
                    DataProvider.Ins.DB.SaveChanges();
                    ListGH.Add(sp);
                }
                else
                {
                    var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 11).FirstOrDefault();
                    addsp.SoLuong++;
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
           );

            ChanGa = new RelayCommand<object>((p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 12).FirstOrDefault();
                if (ga.SoLuong == 0)
                    return false;
                return true;
            }, (p) =>
            {
                var ga = DataProvider.Ins.DB.SanPhams.Where(x => x.IDSanPham == 12).FirstOrDefault();
                var sp = new GioHang { IDSanPham = ga.IDSanPham, SoLuong = 1, DonGia = ga.DonGia, TenSanPham = ga.TenSanPham };
                var giohang = ga.GioHangs.Count();
                if (giohang == 0)
                {
                    DataProvider.Ins.DB.GioHangs.Add(sp);
                    DataProvider.Ins.DB.SaveChanges();
                    ListGH.Add(sp);
                }
                else
                {
                    var addsp = DataProvider.Ins.DB.GioHangs.Where(n => n.IDSanPham == 12).FirstOrDefault();
                    addsp.SoLuong++;
                    DataProvider.Ins.DB.SaveChanges();
                }
            }
           );
        }
    }
}
