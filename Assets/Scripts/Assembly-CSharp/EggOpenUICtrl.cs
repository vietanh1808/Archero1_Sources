using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class EggOpenUICtrl : MediatorCtrlBase
{
	public DxxText Text_Got;

	public TapToCloseCtrl mTapCloseCtrl;

	public GameObject egg0Bottom;

	public GameObject egg0Top;

	public GameObject egg1Bottom;

	public GameObject egg1Top;

	public GameObject monster;

	public GameObject effect1;

	public GameObject effect2;

	public GameObject effect3;

	public MonsterGetInfo info;

	private int monsterid;

	private int flyY;

	private int mz;

	private Dictionary<int, int> flyYDict;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void initNormal()
	{
	}

	private void initBoss()
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
