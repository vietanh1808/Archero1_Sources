using UnityEngine;
using UnityEngine.UI;
using XLua;

public class FishingShopCurrencyItem : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private DxxText count;

	private FishingShopCurrencyItemData data;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(FishingShopCurrencyItemData data)
	{
	}
}
