using UnityEngine;

namespace GooglePay
{
	public class GooglePayIapManager : MonoBehaviour
	{
		private const string Tag = "GooglePayIapManager";

		private GooglePayIapInterface m_listener;

		private AndroidJavaClass jc;

		private AndroidJavaObject act;

		private AndroidJavaObject bridge;

		public void Init(GooglePayIapInterface listener)
		{
		}

		public void ConnectServer()
		{
		}

		public void OnServiceConnection(string result)
		{
		}

		public void Resume()
		{
		}

		public void QuerySkuDetails(string[] inAppIds, string[] subsIds)
		{
		}

		public void OnQuerySkuDetails(string result)
		{
		}

		public void QueryPurchases()
		{
		}

		public void OnPurchaseResult(string s)
		{
		}

		public void Purchase(string productId)
		{
		}

		public static void Log(string msg)
		{
		}

		public static void LogError(string msg)
		{
		}

		private void Call(string methodName, params object[] args)
		{
		}
	}
}
