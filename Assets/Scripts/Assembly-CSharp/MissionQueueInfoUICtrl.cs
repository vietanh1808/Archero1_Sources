using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class MissionQueueInfoUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Quick;

	public ButtonCtrl Button_Get;

	public ButtonCtrl Button_Close;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Quick;

	public DxxText Text_Get;

	public DxxText Text_Diamond;

	public DxxText Text_Time;

	public Image Monster_BG;

	public Image Monster_Icon;

	public GameObject prop;

	public ScrollRect scroll;

	public RectTransform Container;

	public MissionQueueItemData data;

	private int needDiamond;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void init()
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

	private void onButtonQuick()
	{
	}

	private void onButtonGet()
	{
	}
}
