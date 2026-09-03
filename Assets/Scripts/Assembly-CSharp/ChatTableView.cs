using System.Collections.Generic;
using Habby.Guild.Data;
using UIKit;
using UnityEngine;

public class ChatTableView : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public ChatPanelController chatPanel;

	public UITableView tableView;

	public List<ChatMsgDataBase> chatDataList;

	private List<ChatMsgDataBase> chatFiltrateLsit;

	public Dictionary<ChatMsgType, MsgItemBase> itemDict;

	public ChatTabPair[] toggleChat;

	private float topPadding;

	private float bottomPadding;

	private int pullLimitCount;

	private bool isPullLoading;

	private Dictionary<ChatTab, List<ChatMsgType>> crtMsgMap;

	private Dictionary<ChatTab, List<ChatMsgType>> chatMsgMap;

	private ChatTab crtOpenTab;

	private float scrollTime;

	private bool isScrolling;

	private bool needResetTime;

	private int test;

	public DxxText _textSizeCalculator;

	private const float defaultTextWidth = 280f;

	private const int defaultFontSize = 20;

	public void init()
	{
	}

	public void InitTopToggle()
	{
	}

	public void RefreshChatData()
	{
	}

	public void show()
	{
	}

	public void hide()
	{
	}

	public UITableViewCell CellAtIndexInTableView(UITableView tableView, int index)
	{
		return null;
	}

	public int NumberOfCellsInTableView(UITableView tableView)
	{
		return 0;
	}

	public float ScalarForCellInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}

	public float ScalarForUpperMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public float ScalarForLowerMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	private void addItemsCache()
	{
	}

	public void pullChatHistory(string lastid)
	{
	}

	private void callback_pullChatHistroy(List<MsgDataBase> list, bool first, bool next, string pullLastId)
	{
	}

	private void PullChatHistoryFailed()
	{
	}

	private void resetTempActionData(List<MsgDataBase> preList, ActionData next)
	{
	}

	public void addChatOne()
	{
	}

	public void updateChatMsg(int index)
	{
	}

	public void updateCells()
	{
	}

	public void onScroll(Vector2 v2)
	{
	}

	public void Update()
	{
	}

	public void Test_pullChatMsgFirst()
	{
	}

	private void Test_Update()
	{
	}

	public ChatMsgDataBase Test_CreateDataOne(GuildMessageEntity pMsg)
	{
		return null;
	}

	private void Test_Reload()
	{
	}

	private float CalculateTextHeight(string text, float textWidth = 280f, int fontSize = 20)
	{
		return 0f;
	}

	public void RearrangeCells(string msgid)
	{
	}

	public void SetToggleOn(ChatTab tab)
	{
	}
}
