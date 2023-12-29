using System;

namespace ClassDiagramCODScout
{
	public class Banka
	{
		private string _naziv;
		public string Naziv
		{
            get
			{
				{ return _naziv; }
            }
            set
			{
                { _naziv = value; }

            }
        }

		private string _swift;
		public string Swift
		{
            get
			{
				{ return _swift; }
            }
            set
			{
				{ _swift = value; }

            }
        }
	}
}
