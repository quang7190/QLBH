using Reamke.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Reamke.ViewModel;
using System.Windows.Controls;
using System.Security.Cryptography;

namespace Reamke.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public bool IsLogin { get; set; }

        private string _Username;
        public string Username { get=>_Username; set { _Username = value; OnPropertyChanged(); } }
        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }
        public ICommand LoginWindow { get; set; }
        public ICommand CloseWindow { get; set; }
        public ICommand PasswordChanged { get; set; }
        public LoginViewModel()
        {
            IsLogin = false;
            LoginWindow = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                Login(p);
            }
            );

            PasswordChanged = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });

            CloseWindow = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                p.Close();
            }
            );
        }

        void Login(Window p)
        {
            if(p == null)
            {
                return;
            }
            
            if (Username != null & Password != null)
            {
                var passWord = Str_Encoder(Password);
                var user = DataProvider.Ins.DB.Users.SingleOrDefault(x => x.TenDangNhap == Username && x.MatKhau == passWord);

                if (user != null)
                {
                    IsLogin = true;
                    p.Close();
                }
                else
                {
                    IsLogin = false;
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu !!!!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
            }
        }
        public string Str_Encoder(string str)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            Byte[] hashBytes = encoding.GetBytes(str);
            // Compute the SHA-1 hash
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            Byte[] crypt_str = sha1.ComputeHash(hashBytes);
            return BitConverter.ToString(crypt_str);
        }
    }
}
