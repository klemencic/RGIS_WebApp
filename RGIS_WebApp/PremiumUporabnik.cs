using System;

namespace ClassDiagramCODScout {
	public class PremiumUporabnik : Uporabnik {

		private DateTime SubscriptionEndDate;
		public DateTime subscriptionEndDate
		{
            get { return SubscriptionEndDate; }
            set { SubscriptionEndDate = value; }
        }

		public PremiumUporabnik(string username, string email, string geslo, DateTime subscription) : base(username, email, geslo)
		{
			subscriptionEndDate = subscription;
        }

		public PremiumUporabnik() { }
	}

}
