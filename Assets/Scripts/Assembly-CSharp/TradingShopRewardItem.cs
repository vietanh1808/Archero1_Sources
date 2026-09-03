using UnityEngine;

public class TradingShopRewardItem : MonoBehaviour
{
	public PropOneEquip prop;

	public ButtonCtrl btnClick;

	public DxxText textPrice;

	public DxxText textLimitBuy;

	public DxxImage currencyIcon;

	public GameObject go_Mask;

	private TradingShopItemData _crtData;

	public void Init(TradingShopItemData itemData)
	{
	}

	private void OnBtnClick()
	{
	}

	private bool checkCanExchange()
	{
		return false;
	}
}
