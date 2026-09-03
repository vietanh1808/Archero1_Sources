using PureMVC.Interfaces;
using UnityEngine;

public class FarmVisitInfoPanel : MediatorCtrlBase
{
	public RectTransform contentRTF;

	public ButtonCtrl Button_Close;

	public GameObject cpItem;

	public DxxText Text_Empty;

	public DxxText Text_Title;

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

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}
}
