using System;

namespace ClassDiagramCODScout {
	public class Moderator : Uporabnik
	{
		private int moderator_id;
		public int Moderator_id
		{
            get
			{
                return moderator_id;
            }
            set
			{
                moderator_id = value;
            }
        }

		public Moderator(string username, string email, string geslo, int modid) : base(username, email, geslo)
		{
			Moderator_id = modid;


        }

		public Moderator() { }
	}

}
