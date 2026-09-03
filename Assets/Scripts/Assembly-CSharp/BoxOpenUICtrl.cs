using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class BoxOpenUICtrl : MediatorCtrlBase
{
	public BoxOpenBoxAniCtrl mBoxCtrl;

	public DxxText Text_Got;

	public Transform gotparent;

	private const int width = 160;

	private const int height = 210;

	private const int LineCount = 4;

	private GameObject equipone;

	private LocalUnityObjctPool mPool;

	private LocalSave.TimeBoxType boxtype;

	private BoxOpenProxy.Transfer mTransfer;

	private List<Drop_DropModel.DropData> mEquipTransfer;

	private int currentIndex;

	private SequencePool mSeqPool;

	public GameObject Panel_Next;

	public GameObject goBGEquip;

	public GameObject goBGGem;

	public GameObject goBGDragon;

	public GameObject goBGRelics;

	public GameObject goBGEquipS;

	public GameObject goBGManor;

	public GameObject goBGPet;

	public GameObject goBGImprint;

	public BoxOpenSingleRetryCtrl boxNormalOne;

	public BoxOpenNormalTen boxNormalTen;

	public ButtonCtrl Btn_Close;

	public Button Button_TouchScreen;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	private void InitUI()
	{
	}

	private void init_box()
	{
	}

	private void show_equips()
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

	public void OnShareClick()
	{
	}

	private void showNextButton()
	{
	}

	private void updateui()
	{
	}

	public void onButtonTouchScreen()
	{
	}
}
