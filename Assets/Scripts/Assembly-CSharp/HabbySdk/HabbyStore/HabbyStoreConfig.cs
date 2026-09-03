using System;
using UnityEngine;

namespace HabbySdk.HabbyStore
{
	[Serializable]
	public class HabbyStoreConfig
	{
		[Header("基础配置")]
		public string gameId;

		public string habbyIdBaseUrl;

		public string storeUrl;

		[Header("日志配置")]
		public bool enableLogging;

		public bool enablePaymentLogging;

		[Header("平台配置")]
		public bool showIOSToolbar;

		public bool enableAndroidBackButton;

		[Header("超时配置")]
		public float paymentTimeout;

		public float paymentCooldown;
	}
}
