using PureMVC.Interfaces;
using UnityEngine;

public class CooperationJoinUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public ButtonCtrl Button_Join;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Join;

	public DxxInput mInput;

	public RectTransform imageBg;

	private string mRoomID;

	private bool isGetError;

	private int keyboardHeight;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
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

	private void Update()
	{
	}

	public int GetKeyBoardHeight()
	{
		return 0;
	}
}
