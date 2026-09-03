using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class ActiveUICtrl : MediatorCtrlBase
{
	private const string Ani_Info_Show = "Info_Show";

	private const string Ani_Info_Hide = "Info_Hide";

	public GameObject copyitems;

	public ButtonCtrl Button_Close;

	public ScrollIntActiveCtrl mScrollInt;

	public Transform mScrollChild;

	public GameObject copyActive;

	public GameObject copyDiffcult;

	public ActiveInfoCtrl mInfoCtrl;

	public Animation mInfoAni;

	private int showCount;

	private int count;

	private float allWidth;

	private float itemWidth;

	private float offsetx;

	private float lastscrollpos;

	private float lastspeed;

	private int mCurrentIndex;

	private List<ActiveOneCtrl> mCaches;

	private List<Stage_Level_activityModel.ActivityTypeData> mDataList;

	private int currentChoose;

	private ActiveOneCtrl mChooseActive;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void UpdateActiveOne(int index, ActiveOneCtrl one)
	{
	}

	private void UpdateActiveSize(int index, ActiveOneCtrl one)
	{
	}

	private void OnScrollEnd(int index, ActiveOneCtrl one)
	{
	}

	private void OnBeginDrag()
	{
	}

	private void UpdateUI()
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
}
