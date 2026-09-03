using System;

namespace HabbySdk.HabbyStore
{
	[Serializable]
	public class PaymentFailureInfo
	{
		public string orderId;

		public string goodsId;

		public string productName;

		public string amount;

		public string currency;

		public string paymentType;

		public string status;

		public string errorCode;

		public string errorMessage;

		public string timestamp;

		public string rawMessage;

		public override string ToString()
		{
			return null;
		}
	}
}
