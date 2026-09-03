using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class GameTurnTableUICtrl : MediatorCtrlBase
{
	public GameObject gameturnparent;

	public ButtonCtrl Button_Start;

	public GameTurnTableCtrl mTurnCtrl;

	public DxxText Text_Title;

	public DxxText Text_Start;

	public AdTurnTableCtrl mAdTurnCtrl;

	[SerializeField]
	private GameObject jumpMask;

	[SerializeField]
	private DxxText jumpText;

	[SerializeField]
	private ButtonCtrl jumpBtn;

	private TurnTableType resultType;

	private SequencePool mSeqPool;

	private float adx;

	private bool show_currency;

	private bool m_bRotateOver;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private bool GetRerandom(int skillid)
	{
		return false;
	}

	private bool ContainsArrow(string[] attrs)
	{
		return false;
	}

	private void OnRotateStart()
	{
	}

	private void OnRotateEnd()
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
