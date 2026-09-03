using PureMVC.Interfaces;
using UnityEngine;

public class FirstIAPResetUICtrl : MediatorCtrlBase
{
	public const int ResetLen = 5;

	public DxxText titleText;

	public DxxText descText;

	public GameObject[] items;

	public DxxText[] iconText;

	public DxxText[] infoText;

	public ButtonCtrl Button_Close;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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
