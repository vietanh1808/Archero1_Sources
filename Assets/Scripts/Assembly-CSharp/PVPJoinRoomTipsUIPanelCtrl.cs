using UnityEngine;

public class PVPJoinRoomTipsUIPanelCtrl : MediatorCtrlBase
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

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void Update()
	{
	}

	public int GetKeyBoardHeight()
	{
		return 0;
	}

	public override void OnLanguageChange()
	{
	}
}
