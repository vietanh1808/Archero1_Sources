using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Habby.Model;
using Habby.Net.Responses;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class HabbyMailInfoUICtrl : MediatorCtrlBase
{
	public class RewardData
	{
		public int type;

		public int id;

		public int count;

		public int days;
	}

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public UILineCtrl mTitleLineCtrl;

	public DxxText Text_Title;

	public DxxText Text_Time;

	public DxxText Text_Content;

	[SerializeField]
	private DxxtextLink _textConent;

	public DxxText Text_Get;

	public GameObject rewardparent;

	public UILineCtrl mRewardLineCtrl;

	public ScrollRectBase mScrollRect;

	public ScrollRectBase mScrollReward;

	public ButtonCtrl Button_Get;

	public GameObject LoadingUI;

	public Animator LoadingAnim;

	private const float RewardWidth = 130f;

	private const float RewardHeight = 80f;

	private const float OneWidth = 140f;

	private List<RewardData> mList;

	private LocalUnityObjctPool mPool;

	private HabbyMailInfoProxy.Transfer mTranfer;

	private Vector3 mCoinPos;

	private Vector3 mDiamondPos;

	private RectTransform mScrollRectTransform;

	private float haverewardy;

	private float norewardy;

	private bool bMask;

	private Regex reg;

	public List<PlayerCharacter_Skin> SkinList;

	private StringBuilder rewardStringBuilder;

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

	private void ShowMask(bool value)
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

	private void OnMailRewarded(MailRewardResponse response)
	{
	}

	private void OnError(string errorMsg)
	{
	}

	private string ToRewardString(List<MailReward> rewards)
	{
		return null;
	}

	private void OnSuccess_MailReaded(MailReadedResponse response)
	{
	}

	private void OnError_MailReaded(string errorMsg)
	{
	}
}
