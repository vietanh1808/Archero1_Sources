using HabbySdk.HabbyStore;

public class HabbyStoreInitManager
{
	private static bool _isInitialized;

	private static IHabbyStoreManager _storeManager;

	private static void InitLogViewer()
	{
	}

	public static void Init()
	{
	}

	public static bool IsInitialized()
	{
		return false;
	}

	private static void OnPaymentSuccess(PaymentSuccessInfo paymentInfo)
	{
	}

	private static void OnPaymentFailure(PaymentFailureInfo paymentInfo)
	{
	}

	private static void RefreshMailAfterPayment(PaymentSuccessInfo paymentInfo)
	{
	}

	private static void HandlePaymentFailure(PaymentFailureInfo paymentInfo)
	{
	}

	public static void Cleanup()
	{
	}
}
