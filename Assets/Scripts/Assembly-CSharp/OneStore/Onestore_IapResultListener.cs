using UnityEngine;

namespace OneStore
{
	public class Onestore_IapResultListener : MonoBehaviour
	{
		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void serviceConnectionResult(string result)
		{
		}

		private void isBillingSupportedResult(string result)
		{
		}

		private void getPurchaseSuccessResult(PurchaseData result)
		{
		}

		private void getPurchaseErrorResult(string result)
		{
		}

		private void queryProductsSuccessResult(ProductDetail result)
		{
		}

		private void queryProductsErrorResult(string result)
		{
		}

		private void getPurchaseIntentSuccessResult(PurchaseData result)
		{
		}

		private void getPurchaseIntentErrorResult(string result)
		{
		}

		private void consumeSuccessResult(PurchaseData result)
		{
		}

		private void consumeErrorResult(string result)
		{
		}

		private void manageRecurringSuccessResult(PurchaseData result)
		{
		}

		private void manageRecurringErrorResult(string result)
		{
		}

		private void getLoginIntentEvent(string result)
		{
		}
	}
}
