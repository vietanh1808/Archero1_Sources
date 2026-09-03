using System;

namespace OneStore
{
	[Serializable]
	public class ProductDetail
	{
		public string productId;

		public string type;

		public string price;

		public string title;

		public new string ToString()
		{
			return null;
		}
	}
}
