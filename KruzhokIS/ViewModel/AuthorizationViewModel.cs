using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace KruzhokIS.ViewModel
{
    public interface IGettingPassword
    {
        string GetPassword();
    }

    class AuthorizationViewModel : ViewModelBase
    {
        public static Сотрудник1 Account { get; private set; }
        public string Login { get; set; }
        public AuthorizationViewModel()
        {
            Title = "Авторизация";
        }
        public IGettingPassword GettingPassword { private get; set; }
        private string Password
        {
            get => GettingPassword.GetPassword();
        }
        public bool LogIn()
        {
          try
            {
                Account = DataBase.GetContext().Сотрудник1.FirstOrDefault(p => p.login == Login && p.password == Password);
            }
            catch (Exception)
            {

            }
            return Account != null;
        }
    }
    
}
