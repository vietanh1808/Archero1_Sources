using PureMVC.Interfaces;
using UnityEngine;

public class Act6thUIPanel : MediatorCtrlBase
{
	public DxxText titleTex;

	public DxxText timeText;

	public DxxText todayPopTex;

	public ButtonCtrl closeBtn;

	public ButtonCtrl bgBtn;

	public ButtonCtrl tipsBtn;

	public Act6thActBtn[] actBtns;

	public GameObject duiObj;

	private long showTimex;

	private Act6thManager AMgr => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RefreshRedAction(WindowID arg)
	{
	}

	private void onButtonCheckIn()
	{
	}

	private void onButtonShop()
	{
	}

	private void OnBpBtnClick()
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

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void freshRedPoint()
	{
	}
}
