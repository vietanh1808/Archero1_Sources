using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class EventFirstGoldUICtrl : MediatorCtrlBase, AdsRequestHelper.AdsCallback
{
	public DxxText Text_Title;

	public Image Image_Ad;

	public ButtonCtrl Button_Start;

	public ButtonCtrl Button_Close;

	public DxxText Text_Start;

	public GameTurnTableCtrl mTurnCtrl;

	[SerializeField]
	private GameObject jumpMask;

	[SerializeField]
	private DxxText jumpText;

	[SerializeField]
	private ButtonCtrl jumpBtn;

	private float Text_StartX;

	private TurnTableType resultType;

	private int[] qualities;

	private bool bShowAd;

	private bool bReward;

	private bool bInside;

	private SequencePool mPool;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
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

	public void onRequest(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onLoad(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onFail(AdsRequestHelper.AdsDriver sender, string msg)
	{
	}

	public void onOpen(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onClose(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onClick(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	private void onRewardWrapper()
	{
	}

	private void onRewardInternal()
	{
	}

	public void onReward(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}
}
