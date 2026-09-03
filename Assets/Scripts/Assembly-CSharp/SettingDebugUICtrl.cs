using PureMVC.Interfaces;
using UnityEngine;

public class SettingDebugUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public ScrollRectBase mScrollRect_Main;

	public ScrollRectBase mScrollRect_Game;

	public RectTransform window;

	public RectTransform guildCommandUI;

	private float topoffset;

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
}
