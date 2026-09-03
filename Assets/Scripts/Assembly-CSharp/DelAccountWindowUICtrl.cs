using UnityEngine;

public class DelAccountWindowUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText mTextTitle;

	[SerializeField]
	private DxxText mTextContent;

	[SerializeField]
	private ButtonCtrl mBtnSure;

	[SerializeField]
	private DxxText mTextSure;

	[SerializeField]
	private ButtonCtrl mBtnCancel;

	[SerializeField]
	private DxxText mTextCancel;

	[SerializeField]
	private ButtonCtrl mBtnClose;

	private DelAccountWindowProxy.Transfer mTransfer;

	private int m_nConfirmCnt;

	protected override void OnInit()
	{
	}

	private void ShowAgain()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
