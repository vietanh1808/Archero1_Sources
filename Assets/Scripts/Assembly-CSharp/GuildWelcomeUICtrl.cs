using System.Collections.Generic;
using Habby.Guild.Data;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class GuildWelcomeUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_TipDiamond;

	public ButtonCtrl Button_TipChat;

	public ButtonCtrl Button_TipBox;

	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public DxxText Text_Desc;

	public GuildBadgeItem badgeItem;

	public DxxText Text_Name;

	public ButtonCtrl Button_Fresh;

	public RectTransform ContentTags;

	public GuildTagIconItem tagItem;

	public DxxText Text_Lv;

	public DxxText Text_People;

	public DxxText Text_Battle;

	public DxxText Text_Box;

	public DxxText Text_Rate;

	public Image[] Stars;

	public DxxText Text_Score;

	public ButtonCtrl Button_List;

	public DxxText Text_List;

	public ButtonCtrl Button_Join;

	public DxxText Text_Join;

	private int currentIndex;

	private GuildListData.GuildListItem currentGuild;

	private List<GuildTagIconItem> tagInstances;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void ShowCurrent()
	{
	}

	private void DisplayGuild(GuildListData.GuildListItem item)
	{
	}

	private void DisplayStars(int scoreX10)
	{
	}

	private void DisplayTags(string guildContext)
	{
	}

	private void OnRefresh()
	{
	}

	private void OnOpenList()
	{
	}

	private void OnJoinGuild()
	{
	}

	private void OnJoinSuccess(object o)
	{
	}

	private void ShowTip(string langKey, Transform anchor)
	{
	}

	private void Esc()
	{
	}

	public void onButtonClose()
	{
	}
}
