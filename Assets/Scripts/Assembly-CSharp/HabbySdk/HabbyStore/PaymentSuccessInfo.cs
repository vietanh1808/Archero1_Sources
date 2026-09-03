using System;

namespace HabbySdk.HabbyStore
{
	[Serializable]
	public class PaymentSuccessInfo
	{
		public string orderId;

		public string goodsId;

		public string productName;

		public string amount;

		public string currency;

		public string paymentType;

		public string paymentBrand;

		public string status;

		public string timestamp;

		public string quantity;

		public string baseCoinNum;

		public string extraCoinNum;

		public string rawMessage;

		public override string ToString()
		{
			return null;
		}
	}
}
