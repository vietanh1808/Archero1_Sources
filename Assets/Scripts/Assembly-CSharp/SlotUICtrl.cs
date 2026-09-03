using PureMVC.Interfaces;
using UnityEngine;

public class SlotUICtrl : MediatorCtrlBase
{
	public SlotOne[] slots;

	public ButtonCtrl Button_Slot;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Rule;

	public ButtonCtrl Button_Rule_Close;

	public DxxText Text_Title;

	public DxxText Text_Three;

	public DxxText Text_Slot;

	public GoldTextCtrl goldTextCtrl;

	[Header("奖励规则")]
	public GameObject RuleWindow;

	public DxxText RuleTitle;

	public DxxText RuleSubTitle;

	public DxxText Rule3;

	public DxxText Rule2;

	public DxxText Rule1;

	public DxxText RuleRandom;

	public GameObject ResultWindow;

	public GameObject Rx2;

	public GameObject Rx10;

	public Transform contentTF;

	public GameObject tempItem;

	public GameObject light1;

	public GameObject light2;

	private int lighter;

	public int[] endFlag;

	[HideInInspector]
	public int eventId;

	private FarmSlotData slotData;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	public void onButtonSlot()
	{
	}

	public void beginScroll()
	{
	}

	public void onScrollEnd(SlotOne one)
	{
	}

	public void initRule()
	{
	}

	public void switchLight()
	{
	}
}
