using PureMVC.Interfaces;
using UnityEngine;

public class Act5thUIPanel : MediatorCtrlBase
{
	public DxxText titleTex;

	public DxxText timeText;

	public DxxText checkInText;

	public DxxText shopText;

	public DxxText todayPopTex;

	public ButtonCtrl closeBtn;

	public ButtonCtrl bgBtn;

	public ButtonCtrl tipsBtn;

	public ButtonCtrl shopBtn;

	public ButtonCtrl checkInBtn;

	public Act5thActBtn[] actBtns;

	public RedNodeCtrl checkInRed;

	public GameObject duiObj;

	private long showTimex;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void ClickTodayPop()
	{
	}

	protected override void OnClose()
	{
	}

	public void ClosePanel()
	{
	}

	private void freshTime()
	{
	}

	private void UpdateTime()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
