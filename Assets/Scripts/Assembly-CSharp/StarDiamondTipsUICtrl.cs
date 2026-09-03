using UnityEngine;

public class StarDiamondTipsUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private ButtonCtrl _btnClose;

	[SerializeField]
	private DxxText _textTipsTitle;

	[SerializeField]
	private DxxText[] _textContents;

	protected override void OnInit()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
