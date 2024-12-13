using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Login
    {
        private string _email;

        private string _password;
        public string Email 
        {
            get 
            {
                return _email.ToLower();
            }
            set { 
            if (value is null) return;// PLus tard remplacer par une exception
                value = value.Trim();
             if (value.Length > 320) return; //Plus tard remplacer par une exception

             if (value.IndexOf('@') < 1 && value.IndexOf('@') > value.Length-1) return;//Plus tard remplacer par une exception
             _email = value;
            }
        }



        public string Password
        {
            private get // getter en privé pour avoir encore un controle de la variable
            {
                return _password;
            }

            set //seulement un setter pas de controle de sortie.
            {
                _password = value;
            }

        }

        public void SetPassword(string password)
        {
            _password = password;
        }

        public bool CheckIdentity(string email, string password) { 
        return Email == email && Password == password;
        }

        public string EmailDomain 
        {
            get 
            { 
                return _email.ToLower().Substring(_email.IndexOf('@')+1);  
            }
        }
        

    }
}
