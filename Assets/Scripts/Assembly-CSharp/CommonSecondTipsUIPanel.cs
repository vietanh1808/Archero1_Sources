using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class CommonSecondTipsUIPanel : MediatorCtrlBase
{
	public class TipsData
	{
		public int style;

		public List<Drop_DropModel.DropData> rewards;

		public List<Drop_DropModel.DropData> needs;

		public int min;

		public int max;

		public int count;

		public bool showCount;

		public Action okAction;

		public bool checkSkin;

		public string desc;
	}

	public GameObject[] BG;

	public GameObject[] TBG;

	public GameObject[] SBG;

	public Color[] SubTitleColor;

	public RectTransform CostRect;

	public GameObject CostObj;

	public GameObject ChooseObj;

	public DxxText Text_Title;

	public DxxText Text_SubTitle;

	public ButtonCtrl Button_Close;

	public Image Image_Cost;

	public DxxText Text_Cost;

	public DxxText Text_Choose;

	public DxxText Text_Cos;

	public ButtonCtrl Button_Cancel;

	public ButtonCtrl Button_OK;

	public DxxText Text_OK;

	public DxxText Text_Cancel;

	public RectTransform Container;

	public GameObject cpItem;

	public ScrollRect scrollView;

	public GameObject Arrow;

	public DxxText Text_Desc;

	private TipsData data;

	private int chooseCount;

	private PropType needType;

	private int needId;

	private int needCost;

	private int oneValue;

	private const int showScroll = 4;

	private bool showChoose => false;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void init()
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

	private void android_escape()
	{
	}

	private void onButtonOK()
	{
	}

	public int GetChooseCount()
	{
		return 0;
	}

	private void calcuteChooseCount(int offset)
	{
	}

	public void onButtonClick(bool add)
	{
	}

	public void onButtonDoubleClick()
	{
	}

	public void onButtonLongPress(bool add)
	{
	}

	public void onButtonLongPressCancel(bool add)
	{
	}

	private void checkRewardSkinIn(Drop_DropModel.DropData drop)
	{
	}
}
