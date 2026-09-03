using System;

namespace HabbySdk.HabbyStore
{
	public static class HabbyStoreSDK
	{
		private static IHabbyStoreManager _manager;

		private static IHabbyStoreManager Manager => null;

		public static bool IsStoreVisible => false;

		public static bool IsInitialized => false;

		public static event Action OnStoreOpened
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action OnStoreClosed
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<string> OnPaymentStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<bool, string> OnPaymentCompleted
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<HabbyStoreError> OnError
		{
			add
			{
			}
			remove
			{
			}
		}

		public static void Initialize(HabbyStoreConfig config, Action<bool, string> onInitialized = null)
		{
		}

		public static void SetUserDataProvider(IHabbyStoreUserDataProvider provider)
		{
		}

		public static void SetStoreUrl(string url)
		{
		}

		public static void ShowStore(Action<bool, string> onResult = null)
		{
		}

		public static void HideStore()
		{
		}

		public static void DestroyStore()
		{
		}

		public static void TriggerHabbyIdLogin(Action<bool> onComplete)
		{
		}

		public static void RefreshUserToken()
		{
		}

		public static string GetVersion()
		{
			return null;
		}
	}
}
