using PureMVC.Interfaces;
using UnityEngine;

public class MonsterStarUpUICtrl : MediatorCtrlBase
{
	public DxxText Text_Got;

	public TapToCloseCtrl mTapCloseCtrl;

	public GameObject monster;

	public GameObject effect1;

	public GameObject effect2;

	public DxxText Text_Title;

	public MonsterStarShow starShow;

	private int monsterid;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

	public void android_escape()
	{
	}
}
