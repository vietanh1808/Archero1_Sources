using PureMVC.Interfaces;
using UnityEngine;

public class SailingBPPremiumBuyUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Desc;

	public DxxText Text_Crit;

	public DxxText Text_CritDesc;

	public ButtonCtrl Button_Buy;

	public DxxText Text_Price;

	public ButtonCtrl Button_Close;

	public RectTransform RTF_Content;

	public GameObject cpItem;

	public StarDiamondItem starItem;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	public DxxText Text_Time;

	public DxxText Text_BuyBtnTips;

	public DxxText Text_BuyBtnTipsStar;

	public GameObject goBuyAll;

	public GameObject goStageCountDown;

	public DxxText Text_AllBuyTime;

	public DxxText Text_AllBuyCrit;

	public DxxText Text_AllBuyCritStar;

	public DxxText Text_AllBuyBtnTips;

	public DxxText Text_AllBuyBtnTipsStar;

	public DxxText Text_AllBuyStar;

	public DxxText Text_AllBuyPrice;

	public ButtonCtrl Button_BuyAll;

	public ButtonCtrl Button_StarBuyAll;

	private long showTimex;

	private long crtStageEndTime;

	private bool _isFirstStage;

	private int _openStage;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void RefreshAllBuy()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private string GetRomanStage()
	{
		return null;
	}

	private void InitUI()
	{
	}

	private void freshTime()
	{
	}

	public void onButtonClose()
	{
	}

	private void onButtonBuy()
	{
	}

	private void onButtonStar()
	{
	}

	private void onButtonBuyAll()
	{
	}

	private void onButtonStarBuyAll()
	{
	}

	private void PurchaseSuccess(bool isBuyAll = false)
	{
	}
}
