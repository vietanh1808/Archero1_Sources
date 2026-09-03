using PureMVC.Interfaces;
using UnityEngine;

public class SettingUICtrl : MediatorCtrlBase
{
	public GameObject loginObj;

	public GameObject logoutObj;

	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public DxxText Text_Music;

	public DxxText Text_Sound;

	public DxxText Text_Language;

	public DxxText Text_Producter;

	public DxxText Text_Login;

	public DxxText Text_ButtonLogin;

	public DxxText Text_Logout;

	public DxxText Text_Quality;

	public ButtonCtrl Button_Producter;

	public ButtonCtrl Button_Logout;

	public ButtonCtrl Button_Login;

	public SettingMusicCtrl mMusicCtrl;

	public SettingSoundCtrl mSoundCtrl;

	public SettingLanguageCtrl mLanguageCtrl;

	public SettingQualityCtrl mQualityCtrl;

	public DxxText Text_Version;

	public DxxText Text_UserID;

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
