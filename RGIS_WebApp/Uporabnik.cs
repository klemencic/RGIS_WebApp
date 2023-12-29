using RGIS_WebApp;
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
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists  { get; set; }

        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Matches { get; set; }
        public double KDR { get; set; }

		public Uporabnik(string username,  string email, string geslo, bool isPremium, bool isModerator, int kills, int deaths, int assists, int wins, int losses, int matches, double kDR)
        {

            Username = username;
            Email = email;
            Geslo = geslo;
            IsPremium = isPremium;
            IsModerator = isModerator;
            Kills = kills;
            Deaths = deaths;
            Assists = assists;
            Wins = wins;
            Losses = losses;
            Matches = matches;
            KDR = kDR;
        }

        public Uporabnik() { }
        

       
	}

	
}
