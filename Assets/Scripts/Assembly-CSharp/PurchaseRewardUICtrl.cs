using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class PurchaseRewardUICtrl : MediatorCtrlBase
{
	public UILineCtrl mTitleCtrl;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public DxxText Text_Content;

	public DxxText Text_Reward;

	public ButtonCtrl Button_Reward;

	public ScrollRectBase mScrollRect;

	private const int LineCount = 6;

	private const float WidthOne = 140f;

	private const float HeightOne = 140f;

	private GameObject _item;

	private LocalUnityObjctPool mPool;

	private SequencePool mSeqPool;

	private List<Drop_DropModel.DropData> mDataList;

	private RewardState mState;

	private GameObject item => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
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
}
