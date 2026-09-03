using System.Collections.Generic;
using Habby.Model;
using PureMVC.Interfaces;
using UnityEngine;

public class HabbyMailUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Empty;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_DebugClear;

	public HabbyMailInfinity mInfinity;

	public RectTransform window;

	public GameObject copyitems;

	private List<MailData> mList;

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

	private void UpdateChildCallBack(int index, HabbyMailOneCtrl one)
	{
	}

	private void OnClickOpen(int index, HabbyMailOneCtrl one)
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
