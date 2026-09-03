using PureMVC.Interfaces;
using UnityEngine;

public class PVEExchangeUICtrl : MediatorCtrlBase
{
	public DxxText Text_Left;

	public GameObject Focus_Left;

	public DxxText Text_Right;

	public GameObject Focus_Right;

	public PVEExcOutPanel outPanel;

	public PVEExcInPanel inPanel;

	public DxxText Text_Title;

	public DxxText Text_Currency;

	public DxxText Text_Time;

	public ButtonCtrl Button_Info;

	public ButtonCtrl Button_Close;

	public int currentTab;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void initUI()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void onButtonTabLeft()
	{
	}

	public void onButtonTabRight()
	{
	}

	private void showUI(int tab)
	{
	}

	public void onButtonInfo()
	{
	}
}
