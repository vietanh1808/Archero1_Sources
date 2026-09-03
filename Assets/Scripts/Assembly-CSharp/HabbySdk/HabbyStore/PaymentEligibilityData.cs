using System;

namespace HabbySdk.HabbyStore
{
	[Serializable]
	public class PaymentEligibilityData
	{
		public bool eligible;

		public string reason;
	}
}
