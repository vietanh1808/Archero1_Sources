using UnityEngine;
using UnityEngine.UI;

public class InviteCodeUICtrl : MediatorCtrlBase
{
	public InputField CodeInput;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Receive;

	public DxxText Text_Title;

	public DxxText Button_Text;

	public RectTransform imageBg;

	private int CharacterID;

	private bool isGetError;

	private int keyboardHeight;

	protected override void OnInit()
	{
	}

	protected override void OnClose()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public int GetKeyBoardHeight()
	{
		return 0;
	}

	private void Update()
	{
	}
}
