using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ShopItemThemeSupplyBox : MonoBehaviour
{
	public Text Title;

	public Text Description;

	public ButtonCtrl SelectHeroBtn;

	public ButtonCtrl BuyBtn;

	public Text PriceText;

	public PropOneEquip MainReward;

	public Image changeSelect;

	public RewardListCtrl SecondaryReward;

	public GuildBoxButton Button_GuidGift;

	public DxxText Text_GuidGift;

	private ThemeSupplyBox Data;

	private static DelegateBridge __Hotfix0_SetData;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_InitData;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge __Hotfix0_get_heroData;

	private static DelegateBridge __Hotfix0_get_sourceName;

	private static DelegateBridge __Hotfix0_OnSelectHeroBtnClick;

	private static DelegateBridge __Hotfix0_ProcessSelectionData;

	private static DelegateBridge __Hotfix0_OnConfirmSelection;

	private static DelegateBridge __Hotfix0_OnHeroSelected;

	private static DelegateBridge __Hotfix0_OnClickGuildGiftBtn;

	private static DelegateBridge __Hotfix0_OnBuyBtnClick;

	private static DelegateBridge __Hotfix0_callback_buySuccess;

	private static DelegateBridge __Hotfix0_ReSelectedHero;

	private static DelegateBridge __Hotfix0_OnPurchaseSuccess;

	private static DelegateBridge _c__Hotfix0_ctor;

	private ThemeSupplyBoxHero heroData => null;

	private string sourceName => null;

	public void SetData(ThemeSupplyBox data)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void InitData()
	{
	}

	public void UpdateUI()
	{
	}

	private void OnSelectHeroBtnClick()
	{
	}

	private void ProcessSelectionData(List<Drop_DropModel.DropData> input, out List<Drop_DropModel.DropData> result, out List<RewardSelectionDisplayConfig> configs, out Drop_DropModel.DropData selection)
	{
		result = null;
		configs = null;
		selection = null;
	}

	private void OnConfirmSelection(Drop_DropModel.DropData dropData)
	{
	}

	public void OnHeroSelected(int index)
	{
	}

	private void OnClickGuildGiftBtn()
	{
	}

	private void OnBuyBtnClick()
	{
	}

	private void callback_buySuccess(List<Drop_DropModel.DropData> list)
	{
	}

	private void ReSelectedHero()
	{
	}

	private void OnPurchaseSuccess()
	{
	}
}
