using System.Collections.Generic;
using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;

public class MailUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Empty;

	public ButtonCtrl Button_Close;

	public MailInfinity mInfinity;

	public RectTransform window;

	public GameObject copyitems;

	private List<CMailInfo> mList;

	private float topoffset;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void UpdateList()
	{
	}

	private void UpdateChildCallBack(int index, MailOneCtrl one)
	{
	}

	private void OnClickOpen(int index, MailOneCtrl one)
	{
	}

	private void EmptyShow(bool value)
	{
	}

	private void android_escape()
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
}
