using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class GuildUICtrl : MediatorCtrlBase
{
	public enum GuildTab
	{
		Unkonwn = 0,
		Main = 1,
		Chat = 2,
		Shop = 3,
		Activity = 4,
		Rank = 5,
		Task = 6,
		Lock = 7
	}

	private const int ACTIVITY_TAB_INDEX = 4;

	private const int ACTIVITY_OPEN_LIMIT = 4;

	public ButtonCtrl Button_Close;

	public RectTransform contentRT;

	public RectTransform chatParent;

	public GuildUITitleCtl titleCtl;

	public GuildTabItem[] tabItems;

	[SerializeField]
	private GameObject goTabActivityLock;

	public GuildTab currentTab;

	public GuildPanelBase currentPanel;

	public ButtonCtrl Button_Main;

	public ButtonCtrl Button_Chat;

	public GameObject go_MainMini;

	public GameObject go_MainBig;

	public GameObject go_ChatMini;

	public GameObject go_ChatBig;

	public DxxText textMain;

	public DxxText textChat;

	public ChatPanelController chatPanel;

	public RedNodeCtrl redNode_Main;

	public RedNodeCtrl redNode_Chat;

	private List<GuildUIChildCtlBase> childCtlList;

	private Dictionary<GuildTab, GuildPanelBase> panelMap;

	private static bool guildActivityUnlocked => false;

	protected override void OnInit()
	{
	}

	private void InitViewSize()
	{
	}

	protected override void OnOpen()
	{
	}

	private void SetRed(object _)
	{
	}

	private void SetApplyRed(object _)
	{
	}

	public void SetRedNode()
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

	private void OnBottomBtnClick(GuildTab tab)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void init(GuildTab tab = GuildTab.Main)
	{
	}

	private void onButtonClose()
	{
	}

	public void onButtonTab(int index)
	{
	}

	private void closeCurrentTab()
	{
	}

	private void ShowCurrentTab()
	{
	}

	private void ShowFocusTab(int index, bool pFocus)
	{
	}

	private void addTab(GuildTab tab)
	{
	}

	private string getTabPrefabName(GuildTab tab)
	{
		return null;
	}

	private void OnEventOpenShop(object data)
	{
	}

	private void OnEventOpenHelpUI(object data)
	{
	}

	private void OnQuitGuild(object o)
	{
	}

	private void OnGuildInfoUpdate(object _)
	{
	}

	private void OnGuildActivityUpdate(object _)
	{
	}

	public void onButtonMain()
	{
	}

	public void onButtonChat()
	{
	}
}
