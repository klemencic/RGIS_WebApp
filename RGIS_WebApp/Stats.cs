namespace RGIS_WebApp
{
    public class Stats
    {
        public int Kills { get; set; }  
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Matches { get; set; }
        public double KDRatio { get; set; } 

        public Stats(int kills, int deaths, int assists, int wins, int loses, int matches)
        {
            Kills = kills;
            Deaths = deaths;
            Assists = assists;
            Wins = wins;
            Loses = loses;
            Matches = matches;
            KDRatio = (double)Kills / Deaths;
        }
    }
}
