using UnityEngine;

namespace OneStore
{
	public class Onestore_IapCallManager
	{
		private static AndroidJavaObject iapRequestAdapter;

		private static AndroidJavaClass jc;

		private static bool isServiceCreated;

		private const int IAP_API_VERSION = 5;

		private static void setServiceAvailable()
		{
		}

		public static void checkServiceAvailable()
		{
		}

		static Onestore_IapCallManager()
		{
		}

		~Onestore_IapCallManager()
		{
		}

		public static void connectService(string publicKey)
		{
		}

		public static void isBillingSupported()
		{
		}

		public static void getPurchases()
		{
		}

		public static void getProductDetails(string[] products, string productType)
		{
		}

		public static void buyProduct(string productId, string productType, string payload)
		{
		}

		public static void consume(string inapp_json)
		{
		}

		public static void manageRecurringAuto(string auto_json, string command)
		{
		}

		public static void login()
		{
		}

		public static void destroy()
		{
		}
	}
}
