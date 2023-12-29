using System;

namespace ClassDiagramCODScout
{
	public class Chatroom
	{
		private Uporabnik[] _udelezenci;
		public Uporabnik[] Udelezenci
		{
            get
			{
                return _udelezenci;
            }
            set
			{
				_udelezenci = value;
            }
        }

	}
}
