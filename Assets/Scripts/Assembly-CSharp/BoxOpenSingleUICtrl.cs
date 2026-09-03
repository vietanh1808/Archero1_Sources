using Dxx.Util;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class BoxOpenSingleUICtrl : MediatorCtrlBase
{
	public BoxOpenBoxAniCtrl mBoxCtrl;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public GameObject titleparent;

	public CanvasGroup nameparent;

	public DxxText Text_Quality;

	public DxxText Text_Name;

	public DxxText Text_Info;

	public BoxOpenSingleRetryCtrl mRetryCtrl;

	public BoxOpenStepCtrl mStepCtrl;

	public GameObject goBgEquip;

	public GameObject goBgGem;

	public GameObject goBgDragon;

	public GameObject goBgRelics;

	public GameObject goBgEquipS;

	public GameObject goBgPet;

	public GameObject goBgImprint;

	public GameObject goBgRelics_GoldBG;

	public GameObject goBgManor;

	private SequencePool mSeqPool;

	private BoxOpenSingleProxy.Transfer mTransfer;

	private bool bShowCurrency;

	public BoxOpenNormalTen boxNormalTen;

	private Drop_DropModel.DropData finalData;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void show_close(bool value)
	{
	}

	private void ShowCurrency(bool value)
	{
	}

	private void updateui()
	{
	}

	private void InitUI()
	{
	}

	private void init1()
	{
	}

	private void init2()
	{
	}

	private void init3()
	{
	}

	private void ShowFinalyData()
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

	private void showNormalTen()
	{
	}
}
