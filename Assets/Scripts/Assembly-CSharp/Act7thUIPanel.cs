using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class Act7thUIPanel : MediatorCtrlBase
{
	public DxxText titleTex;

	public DxxText timeText;

	public DxxText todayPopTex;

	public ButtonCtrl closeBtn;

	public ButtonCtrl bgBtn;

	public ButtonCtrl tipsBtn;

	private Act7thActBtn[] actBtns;

	public GameObject duiObj;

	public Image progressImg;

	public Transform progressEffect;

	private float intervalAngle;

	private float interval;

	private long[] openTimes;

	private Act7thManager AMgr => null;

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

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void freshTime()
	{
	}

	private void RefrshProgress()
	{
	}
}
