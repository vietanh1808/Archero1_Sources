using System.Collections.Generic;
using PureMVC.Interfaces;

public class CheckBattleInUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Content;

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Refuse;

	public DxxText Text_Sure;

	public DxxText Text_Refuse;

	protected override void OnInit()
	{
	}

	private void LoadBattle()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
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

	private void OnCheckFinish(string groupName, bool ifFinish, int downloadCount, int downloadSize, List<string> downloadList)
	{
	}
}
