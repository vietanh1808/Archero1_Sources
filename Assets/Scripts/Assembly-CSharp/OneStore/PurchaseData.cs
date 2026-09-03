using System;

namespace OneStore
{
	[Serializable]
	public class PurchaseData
	{
		public string orderId;

		public string packageName;

		public string productId;

		public long purchaseTime;

		public string purchaseId;

		public string developerPayload;

		public int purchaseState;

		public int recurringState;

		public new string ToString()
		{
			return null;
		}
	}
}
