using TableTool;
using UnityEngine;

public class RewardCharacterUICtrl : MediatorCtrlBase
{
	public DxxText Title;

	public DxxText Title2;

	public DxxText Button_Text;

	public ButtonCtrl Close_Button;

	public ButtonCtrl Check_Button;

	public Transform heroparent;

	private PlayerCharacter_Character mCharData;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
