using System.Collections.Generic;
using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ChapterGiftItemCell : ViewCell
{
	public ScrollRect scrollRect;

	public Image ScrollImage;

	public RectTransform Content;

	public PropOneEquip rewardItemTemplate;

	public DxxText Text_Title;

	public DxxText Text_Price;

	public DxxText Text_GoldBefore;

	public DxxText Text_Multiply;

	public DxxText Text_Value;

	public DxxText Text_StarDiamond;

	public DxxText Text_StarDiamondBefore;

	public DxxText Text_GuidGift;

	public ButtonCtrl Button_Buy;

	public GuildBoxButton Button_GuidGift;

	public VIPFlagItem vipItem;

	public GameObject go_StarDiamond;

	public GameObject go_StarDiamondBefore;

	public DxxImage Image_BG;

	public Sprite normalItemSprite;

	public Sprite heroItemSprite;

	public Sprite hellItemSprite;

	public Color[] titleColor;

	private ChapterGiftItemData itemData;

	private Current_purchaseItem item;

	private List<Drop_DropModel.DropData> rewards;

	private readonly List<PropOneEquip> rewardItems;

	private string productId;

	private int stageMode;

	private int chapterId;

	protected override void OnInit()
	{
	}

	protected override void OnRefresh()
	{
	}

	protected override void OnRecycle()
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshRewardList()
	{
	}

	private void ClearRewards()
	{
	}

	private void RefreshTexts()
	{
	}

	private void RefreshVipAndGuild()
	{
	}

	private void OnButtonGuildGift()
	{
	}

	private void RefreshPriceState()
	{
	}

	private void RefreshBackground()
	{
	}

	private void OnButtonBuy()
	{
	}

	private void OpenChoiceBoxThenBuy(List<Drop_DropModel.DropData> dropList, Drop_DropModel.DropData choiceDrop)
	{
	}

	private void BuyWithCurrentCurrency(List<Drop_DropModel.DropData> dropList, Drop_DropModel.DropData selectedChoice)
	{
	}

	private void ConfirmPurchase(List<Drop_DropModel.DropData> dropList, Drop_DropModel.DropData selectedChoice)
	{
	}

	private void OnStarBuy(List<Drop_DropModel.DropData> dropList)
	{
	}

	private bool CheckBuy()
	{
		return false;
	}

	private void PurchaseSuccess(CRespInAppPurchase resp, List<Drop_DropModel.DropData> dropList)
	{
	}

	private void ReadStageInfo()
	{
	}

	private static void SetText(DxxText target, string value)
	{
	}

	private static string GetLanguageOrDefault(string key, string fallback)
	{
		return null;
	}
}
