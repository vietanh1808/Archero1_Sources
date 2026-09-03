namespace GooglePay
{
	public class PurchaseResult
	{
		public class Order
		{
			public string OrderId;

			public string Token;

			public long Time;

			public string ProductId;

			public string UserId;

			public int State;

			public string ISOCode;

			public new string ToString()
			{
				return null;
			}
		}

		public int Code;

		public Order[] Orders;

		public new string ToString()
		{
			return null;
		}
	}
}
