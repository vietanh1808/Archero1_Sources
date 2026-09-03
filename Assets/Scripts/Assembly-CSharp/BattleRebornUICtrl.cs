using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;

public class BattleRebornUICtrl : MediatorCtrlBase
{
	public DxxText Text_Content;

	public DxxText Text_Time;

	public DxxText Text_Count;

	public GoldTextCtrl mDiamondCtrl;

	public DxxText Text_Free;

	public DxxText Text_FreeCount;

	public DxxText Text_BPFree;

	public GameObject FreeParent;

	public ButtonCtrl Button_Buy;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public ButtonCtrl Button_BPFree;

	public ButtonAdControl mButtonAd;

	private const int Max_Second = 5;

	private bool bFree;

	private long needdiamond;

	private bool bStart;

	private float starttime;

	private int second;

	private RebornSource rebornSource;

	private bool bDealed;

	private Sequence seq;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void update_ad()
	{
	}

	private void UpdateButton()
	{
	}

	private void CloseWindow()
	{
	}

	private void DoReborn(bool usecount, BattleModuleData.UseRebornType rebornType = BattleModuleData.UseRebornType.None)
	{
	}

	private void CloseWindowInternal()
	{
	}

	private void OnDiamondShopClose()
	{
	}

	private void Update()
	{
	}

	private void KillSequence()
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
