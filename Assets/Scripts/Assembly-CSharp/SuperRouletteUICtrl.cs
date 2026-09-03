using Dxx.Util;
using UnityEngine;

public class SuperRouletteUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Close_Button;

	public GameObject Close_Button_dis;

	public GameObject gameturnparent;

	public NormalRouletteCtrl normalCtrl;

	public SuperRouletteCtrl superCtrl;

	public SuperRouletteBox boxCtrl;

	public static bool haveChange;

	private SequencePool mSeqPool;

	private bool isSuper;

	private bool isMoving;

	private void Start()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected void UpdateUI()
	{
	}

	private void android_escape()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	private void UpdateRoulette()
	{
	}

	private void ShowDropList()
	{
	}

	private void goSuper()
	{
	}

	private void backNormal()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
