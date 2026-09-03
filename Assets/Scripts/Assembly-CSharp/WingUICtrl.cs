using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class WingUICtrl : MediatorCtrlBase
{
	public WingListPart wingListPart;

	public WingAttributePart wingAttributePart;

	public WingBottomPart wingBottomPart;

	public WingModelShowPart wingModelShowPart;

	public Image fragmentIcon;

	public Image exchangeImg;

	public Image showImg;

	public Image displayImg;

	public DxxText fragmentTex;

	public ButtonCtrl switchBtn;

	public DxxText nameText;

	public RectTransform topTrans;

	private LocalSave.WingOne wing;

	public DxxText rateDes;

	public DxxText collectionRate;

	public WingAttributeTips wingAttributeTips;

	public ButtonCtrl showBtn;

	public Transform starParent;

	public GameObject starObj;

	public HeroPropInfoCtrl atkCtrl;

	public HeroPropInfoCtrl hpCtrl;

	public HeroLevelInfoCtrl levelInfoCtrl;

	public WingAssistPart wingAssistPart;

	public WingSelectAssistPart wingSelectAssistPart;

	public GameObject lockAttrObj;

	public GameObject unlockAttrObj;

	public RectTransform rateTrans;

	public ButtonCtrl[] needCloseBtns;

	public ButtonCtrl tipsBtn;

	public WingMaxExchangeBtn wingMaxExchangeBtn;

	public ButtonCtrl dispalyBtn;

	public ButtonCtrl tryPlayBtn;

	public DxxText tryPlayText;

	private List<Image> stars;

	private bool isPreviewMax;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RefreshExchangeImg()
	{
	}

	protected override void OnClose()
	{
	}

	private void OnWear(bool obj)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnSelectWing(LocalSave.WingOne wing)
	{
	}

	public void OpenAttributeTips()
	{
	}

	private void RefreshFragment()
	{
	}

	private void OnUnLock()
	{
	}

	private void RefreshStar()
	{
	}

	private void RefreshLevel()
	{
	}

	private void RefreshAttribute()
	{
	}

	private void RefreshRate()
	{
	}

	private void OnLevelUp()
	{
	}

	private void OnStarUp()
	{
	}

	private void ClickPreviewMax()
	{
	}

	private void RefreshPreviewMax()
	{
	}

	private void RefreshHideToggle()
	{
	}

	private void RefreshDiapalyoggle()
	{
	}

	public void OpenAssistSelectPart()
	{
	}

	public void CloseAssistSelectPart()
	{
	}

	private void OnClickBack()
	{
	}

	private void onButtonInfo()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
