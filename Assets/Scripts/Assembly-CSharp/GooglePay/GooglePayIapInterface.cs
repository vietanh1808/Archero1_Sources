namespace GooglePay
{
	public interface GooglePayIapInterface
	{
		void OnConnectServerResult(ServiceConnectionResult result);

		void OnQuerySkuDetails(ProductDetail[] details);

		void OnPurchaseResult(PurchaseResult result);
	}
}
