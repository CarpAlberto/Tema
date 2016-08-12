using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2.views;
namespace Tema2.controllers
{
    class AbstractUser
    {
        private string _username;
        private string _password;
        private Permisiuni _permisiuni;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public Permisiuni Permisiuni
        {
            get
            {
                return _permisiuni;
            }
            set
            {
                _permisiuni = value;
            }
        }

       public  void Redirect()
        {
            switch(Permisiuni)
            {
                case Permisiuni.SUPERADMIN:
                    new SuperAdminView().ShowDialog();
                    break;
            }
        }
    }
}
