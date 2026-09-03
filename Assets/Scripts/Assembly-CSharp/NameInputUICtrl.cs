using PureMVC.Interfaces;
using UnityEngine;

public class NameInputUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public ButtonCtrl Button_OK;

	public ButtonCtrl Button_Diamond;

	public GoldTextCtrl diamondTextCtrl;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_OK;

	public DxxText Text_Free;

	public DxxInput mInput;

	public RectTransform imageBg;

	private string endInputText;

	private bool isGetError;

	private int keyboardHeight;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

	public void onButtonOK()
	{
	}

	private void Update()
	{
	}

	public int GetKeyBoardHeight()
	{
		return 0;
	}
}
