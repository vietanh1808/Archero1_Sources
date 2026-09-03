using PureMVC.Interfaces;
using UnityEngine;

public class MenuPopUICtrl : MediatorCtrlBase
{
	public GameObject panel;

	public MainUISettingCtrl mSettingCtrl;

	public MainUIMailCtrl mMailCtrl;

	public DxxText Text_Setting;

	public DxxText Text_Mail;

	public ButtonCtrl Button_Note;

	public DxxText Text_NoteTitle;

	public RedNodeCtrl Red_Note;

	protected override void OnInit()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void OnButtonClick()
	{
	}
}
