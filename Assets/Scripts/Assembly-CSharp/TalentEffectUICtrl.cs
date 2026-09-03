using PureMVC.Interfaces;
using UnityEngine;

public class TalentEffectUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Title1;

	public DxxText Text_Title2;

	public RectTransform Container1;

	public RectTransform Container2;

	public ButtonCtrl Button_Close;

	public GameObject cpAttr;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

	public void initUI()
	{
	}

	private void android_escape()
	{
	}

	public void onButtonClosed()
	{
	}
}
