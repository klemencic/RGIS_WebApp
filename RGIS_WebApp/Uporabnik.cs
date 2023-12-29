using System;

namespace ClassDiagramCODScout {
	public class Uporabnik {
        public int Id { get; set; }
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
        public bool IsPremium { get; set; }
        public bool IsModerator { get; set; }

		public Uporabnik(string username, string email, string geslo, bool isPremium, bool isModerator)
		{
            
            Username = username;
            Email = email;
            Geslo = geslo;
            IsPremium = isPremium;
            IsModerator = isModerator;
        }

        public Uporabnik() { }
        

       
	}

	
}
