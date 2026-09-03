using System.Collections.Generic;
using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class ContinuousBuyUIPanel : MediatorCtrlBase
{
	public Color[] lightColor;

	public Color[] timeDownColor;

	public Image titleBgIamg;

	public Image bgImg;

	public Image huawenImage;

	public Image lightImage;

	public Image Image_RedLine_Pay;

	public DxxText titleTex;

	public DxxText timeTex;

	public DxxText priceTex;

	public DxxText oldPriceTex;

	public DxxText Text_Discount;

	public DxxText Text_Value;

	public DxxText hasBuyTex;

	public VIPFlagItem flagItem;

	public ButtonCtrl buyButton;

	public ButtonCtrl rightButton;

	public ButtonCtrl leftButton;

	public ButtonCtrl closeBtn;

	public ButtonCtrl bgBtn;

	public RectTransform itemParent;

	public ContentSizeFitter sizeFitter;

	public ContinuousBuyItem copyOne;

	public RedNodeCtrl redNodeCtrl;

	public StarDiamondItem starItem;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	private List<ContinuousBuyMgr.ContinuousBuyGiftConfig> giftList;

	private int CurIndex;

	private long showTimex;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void ClickClose()
	{
	}

	private void ClickBuy()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshBtn()
	{
	}

	private void freshTime()
	{
	}

	public void RefreshRed()
	{
	}

	private void UpdateTime()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void onButtonStar()
	{
	}

	private void purchaseSuccess(CRespInAppPurchase resp, ContinuousBuyMgr.ContinuousBuyGiftConfig gift)
	{
	}
}
