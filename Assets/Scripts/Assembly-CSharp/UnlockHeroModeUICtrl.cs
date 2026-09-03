using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;

public class UnlockHeroModeUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public DxxText Text_Title;

	public CanvasGroup titlecanvas;

	public CanvasGroup levelcanvas;

	public CanvasGroup infocanvas;

	public DxxText Text_Close;

	public DxxText Text_Info;

	private Tweener t_close;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
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
}
