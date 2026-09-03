using System;

namespace HabbySdk.HabbyStore
{
	[Serializable]
	public class PaymentEligibilityResponse
	{
		public int code;

		public string message;

		public PaymentEligibilityData data;
	}
}
