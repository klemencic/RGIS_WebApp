using System;

namespace ClassDiagramCODScout {
	public class Uporabnik {
		private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; }

        }
       
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }

        }
        private string _geslo;
        public string Geslo
        {
            get { return _geslo; }
            set { _geslo = value; }

        }

		public Uporabnik(string username, string email, string geslo)
		{
            Username = Username;
            Email = email;
            Geslo = geslo;
        }

        public Uporabnik() { }
        

       
	}

	
}
