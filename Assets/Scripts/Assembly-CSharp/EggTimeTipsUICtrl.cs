using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class EggTimeTipsUICtrl : MediatorCtrlBase
{
	public GameObject Top;

	public GameObject Bottom;

	public EggTimeOne[] timeOne;

	public DxxText Time_Acc;

	public DxxText Time_Desc;

	public ButtonCtrl Button_OK;

	public DxxText Text_OK;

	public Dictionary<int, int> dict;

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

	private void init()
	{
	}
}
