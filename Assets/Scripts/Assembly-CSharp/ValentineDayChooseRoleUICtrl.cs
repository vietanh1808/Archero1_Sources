using UnityEngine;

public class ValentineDayChooseRoleUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText _textTitle;

	[SerializeField]
	private DxxText _textContent;

	[SerializeField]
	private DxxText _textTips;

	[SerializeField]
	private DxxText _textLeft;

	[SerializeField]
	private DxxText _textRight;

	[SerializeField]
	private DxxText _textLeftBtn;

	[SerializeField]
	private DxxText _textRightBtn;

	[SerializeField]
	private ButtonCtrl _btnLeft;

	[SerializeField]
	private ButtonCtrl _btnRight;

	[SerializeField]
	private DxxText _textRedRose;

	[SerializeField]
	private DxxText _textBlueRose;

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
