using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class MissionUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_TimeEnd;

	public DxxText Text_Desc;

	public ButtonCtrl Button_Info;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Back;

	public ButtonCtrl Button_Task;

	public ButtonCtrl Button_Queue;

	public RectTransform Window;

	public MissionTaskUI uiTask;

	public MissionQueueUI uiQueue;

	public DxxText Text_Scroll;

	public DxxText Text_ScrollHigh;

	public DxxText Text_Diamond;

	private int currentTab;

	public DxxText Title_Task;

	public GameObject Icon_Task;

	public GameObject Red_Task;

	public DxxText Title_Queue;

	public GameObject Icon_Queue;

	public GameObject Red_Queue;

	public Sprite[] kvs;

	public Image Image_KV;

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

	private void init()
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonBack()
	{
	}

	private void onButtonTask()
	{
	}

	private void onButtonQueue()
	{
	}
}
