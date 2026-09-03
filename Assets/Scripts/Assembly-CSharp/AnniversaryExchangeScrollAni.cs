using Activity.Anniversary.Exchange.Data;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class AnniversaryExchangeScrollAni : MonoBehaviour
{
	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private CanvasGroup canvasGroup;

	private static DelegateBridge __Hotfix0_get_ExchangeManager;

	private static DelegateBridge __Hotfix0_Stop;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge _c__Hotfix0_ctor;

	private ExchangeManager ExchangeManager => null;

	public void Stop()
	{
	}

	public void PlayAni(int endIndex, float duration)
	{
	}
}
