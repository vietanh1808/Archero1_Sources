using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class GuildAskHelpUICtrl : MediatorCtrlBase
{
	public RectTransform contentRTF;

	public Button[] TabButton;

	public GameObject[] TabFocus;

	public DxxText[] TabText;

	public GameObject[] Tab_Locker;

	public EquipOneCtrl topEquip;

	public DxxText Text_Title;

	public DxxText Text_Desc;

	public DxxText Text_Left;

	public DxxText Text_Time;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Ask;

	public Text Text_Ask;

	public RectTransform RTF_Time;

	public GameObject cpItem;

	public DxxText Text_HaveTips;

	private int currentTab;

	private int currentSelectId;

	private int[] unlockLevel;

	private Dictionary<int, List<int>> askDict;

	private Dictionary<int, AskHelpItem> askItems;

	private int leftCount;

	private long leftTime;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void freshCountAndTime()
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

	public void OnButtonTab(int tab)
	{
	}

	private void initTab(int tab)
	{
	}

	public void onButtonAsk()
	{
	}

	private void chooseOne(int aid)
	{
	}

	public bool isTabUnlock(int tab)
	{
		return false;
	}

	public bool isTabShow(int tab)
	{
		return false;
	}
}
