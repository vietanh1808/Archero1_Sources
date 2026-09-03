using UnityEngine;

public class PveSeasonOpenUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText mTextTitle;

	[SerializeField]
	private DxxText mTextContent;

	[SerializeField]
	private DxxText mTextCd;

	[SerializeField]
	private DxxText mTextLine_1;

	[SerializeField]
	private DxxText mTextLine_2;

	[SerializeField]
	private DxxText mTextLine_3;

	[SerializeField]
	private ButtonCtrl mBtnOK;

	[SerializeField]
	private DxxText mTextOk;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}
}
