using Activity.Anniversary.Exchange.Data;
using UnityEngine;
using XLua;

public class AnniversaryExchangeProgress : MonoBehaviour
{
	[SerializeField]
	private RectTransform active;

	private static DelegateBridge __Hotfix0_get_ExchangeManager;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Stop;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge _c__Hotfix0_ctor;

	private ExchangeManager ExchangeManager => null;

	public void Init()
	{
	}

	public void Stop()
	{
	}

	public void PlayAni(int endIndex, float duration)
	{
	}
}
