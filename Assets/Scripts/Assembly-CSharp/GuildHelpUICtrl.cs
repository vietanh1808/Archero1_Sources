using System.Collections.Generic;
using Habby.Guild.Data;
using PureMVC.Interfaces;
using UnityEngine;

public class GuildHelpUICtrl : MediatorCtrlBase
{
	public GuildHelpTableView helpTableView;

	public GuildHelpButtonWindow Window_Button;

	public GuildHelpListWindow Window_HelpList;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_HelpList;

	public ButtonCtrl Button_Ask;

	public DxxText Text_Select;

	public DxxText Text_Help;

	public DxxText Text_Ask;

	public DxxText Text_AskCount;

	public DxxText Text_Title;

	public DxxText Text_Title_Left;

	public DxxText Text_Count_Left;

	public DxxText Text_Title_Right;

	public DxxText Text_Count_Right;

	public int currentTab;

	private int haveAskNum;

	private int TotalAskNum;

	private List<HelpMeData> helpMeList;

	public GameObject RedPoint_HelpMe;

	public ButtonCtrl Button_HatchAll;

	public DxxText Text_HatchAll;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void android_escape()
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

	private void onButtonClose()
	{
	}

	public void onButtonSelect()
	{
	}

	private void onButtonHelpList()
	{
	}

	private void onButtonAsk()
	{
	}

	public void freshHelpList(int index, string text)
	{
	}

	private void onEventUpdateMessage(string from, ActionData action)
	{
	}

	public void onButtonHatchAll()
	{
	}

	private void Test_ShowHelpMe()
	{
	}
}
