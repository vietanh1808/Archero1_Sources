using System;

namespace HabbySdk.HabbyStore
{
	public interface IHabbyStoreManager
	{
		bool IsStoreVisible { get; }

		bool IsInitialized { get; }

		event Action OnStoreOpened;

		event Action OnStoreClosed;

		event Action<string> OnPaymentStarted;

		event Action<bool, string> OnPaymentCompleted;

		event Action<HabbyStoreError> OnError;

		event Action OnLoginFlowStarted;

		event Action<bool> OnLoginFlowCompleted;

		event Action<PaymentSuccessInfo> OnPaySuccess;

		event Action<PaymentFailureInfo> OnPayFailure;

		void Initialize(HabbyStoreConfig config, Action<bool, string> onInitialized = null);

		void SetUserDataProvider(IHabbyStoreUserDataProvider provider);

		void SetLoadingProvider(IHabbyStoreLoadingProvider provider);

		void SetStoreUrl(string url);

		void ShowStore(Action<bool, string> onResult = null);

		void HideStore();

		void DestroyStore();

		void TriggerHabbyIdLogin(Action<bool> onComplete);

		void RefreshUserToken();

		string GetVersion();

		void CanShowStore(Action<bool, string> callback);

		string GetAppStoreCountryCode();
	}
}
