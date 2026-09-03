using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class LanguageUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public LanguageInfinity mInfinity;

	public GameObject copyitems;

	private List<string> mList;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void UpdateChildCallBack(int index, LanguageOneCtrl one)
	{
	}

	private void OnClickLanguage(LanguageOneCtrl one)
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
