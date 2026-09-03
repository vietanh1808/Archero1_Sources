using PureMVC.Interfaces;
using UnityEngine;

public class SoulQuickUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Desc;

	public ButtonCtrl Button_Back;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public DxxText Text_GiveNum;

	public GameObject RedPoint;

	private int m;

	private int hp;

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

	private void android_escape()
	{
	}

	private void init()
	{
	}
}
