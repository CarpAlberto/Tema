using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2.controllers
{
    class UserManager
    {
        static UserManager _refInstance = null;
        static AbstractUser _loggedInUser = null;
        private UserManager() { }
        public static UserManager getInstance()
        {
            if (_refInstance == null)
                _refInstance = new UserManager();
            return _refInstance;
        }
        public void setLoggedIn(string Username, string Password, Permisiuni permisiuni)
        {
            _loggedInUser = new AbstractUser
            {
                Password = Password,
                Username = Username,
                Permisiuni = permisiuni
            };
        }
        public void addNewAccount(string Username, string Password, Permisiuni permisiuni)
        {
            using (var db = new DatabaseContext())
            {
                db.Utilizatoris.Add(new Utilizatori
                {

                    Parola = Password,
                    Username = Username,
                    ID_Permisiune = (int)permisiuni,
                    Activ = false
                });
            }
        }
        public bool Login(string Username, string Password)
        {
            using (var db = new DatabaseContext())
            {
                var user = getUserbyName(Username);
                if (user == null)
                {
                    throw new Exception("The username " + Username + " doesn't exists into the database");
                }
                else
                {
                    if (Password == user.Password)
                    {
                        _loggedInUser = user;
                        return true;
                    }
                    else
                    {
                        throw new Exception("The username and password doesn't match");
                    }
                }
            }
        }
        public AbstractUser getUserbyName(string username)
        {
            using (var db = new DatabaseContext())
            {
                var user = from b in db.Utilizatoris
                           where b.Username == username
                           select b;
                if (user != null)
                {
                    return new AbstractUser()
                    {
                        Username = user.AsEnumerable().ToArray()[0].Username,
                        Password = user.AsEnumerable().ToArray()[0].Parola,
                        Permisiuni = (Permisiuni)user.AsEnumerable().ToArray()[0].ID_Permisiune
                    };
                }
                else
                {
                    return null;
                }
            }
        }
        public List<string> LoadAllPermissions()
        {
            List<string> retList = new List<string>();
            using (var db = new DatabaseContext())
            {
                var user = from b in db.Permisiunis
                           select b;

                foreach (var perm in user)
                {
                    retList.Add(perm.Permisiune);
                }
            }
            return retList;
        }
        public List<string> GetAllUsers()
        {
            List<string> retLista = new List<string>();
            using (var db = new DatabaseContext())
            {
                var lista = from b in db.Utilizatoris
                           select b;
                foreach (Utilizatori user in lista)
                {
                    if (user.ID_Permisiune != 1 && user.Activ == true)
                    {
                        retLista.Add(user.ToString());
                    }

                }
                return retLista;
            }   
        }
        public List<string> GetAllPendingUsers()
        {
            List<string> retLista = new List<string>();
            using (var db = new DatabaseContext())
            {
                var lista = from b in db.Utilizatoris
                            select b;
                foreach (Utilizatori user in lista)
                {
                    if (user.ID_Permisiune != 1 && user.Activ == false)
                    {
                        retLista.Add(user.ToString() + "-" + user.Permisiuni);
                    }
                }
                return retLista;
            }
        }
        public AbstractUser Logged()
        {
            return _loggedInUser;
        }
    }
}
