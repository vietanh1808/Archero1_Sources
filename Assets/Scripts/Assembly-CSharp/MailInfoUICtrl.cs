using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class MailInfoUICtrl : MediatorCtrlBase
{
	public class RewardData
	{
		public int type;

		public int id;

		public int count;
	}

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public UILineCtrl mTitleLineCtrl;

	public DxxText Text_Title;

	public DxxText Text_Time;

	public DxxText Text_Content;

	public DxxText Text_Get;

	public GameObject rewardparent;

	public UILineCtrl mRewardLineCtrl;

	public ScrollRectBase mScrollRect;

	public ScrollRectBase mScrollReward;

	public ButtonCtrl Button_Get;

	private const float RewardWidth = 130f;

	private const float RewardHeight = 80f;

	private const float OneWidth = 140f;

	private bool bHaveReward;

	private List<RewardData> mList;

	private LocalUnityObjctPool mPool;

	private MailInfoProxy.Transfer mTranfer;

	private Vector3 mCoinPos;

	private Vector3 mDiamondPos;

	private RectTransform mScrollRectTransform;

	private float haverewardy;

	private float norewardy;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void InitGet()
	{
	}

	private void RefreshGot()
	{
	}

	private void OnClickGet()
	{
	}

	private void OnClickClose()
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
