using System;
using TableTool;

public class SelectCharacterPopUICtrl : MediatorCtrlBase
{
	public DxxText titleText;

	public DxxText contentText;

	public GoldTextCtrl goldText;

	public ButtonCtrl confirm;

	public ButtonCtrl close;

	private PlayerCharacter_Character param;

	private Action<PlayerCharacter_Character> buyCallBack;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnClickConfirm()
	{
	}

	private void OnClickClose()
	{
	}
}
