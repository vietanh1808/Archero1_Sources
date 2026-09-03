using System.Collections.Generic;
using UnityEngine;

public class ChristmasDiffcultyUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText mTextTitle;

	[SerializeField]
	private ButtonCtrl mBtnClose;

	[SerializeField]
	private DxxText mTextCurrentLevel;

	[SerializeField]
	private ChristmasDiffcultyItemCtrl mCopyOne;

	[SerializeField]
	private Transform mContent;

	[SerializeField]
	private PropOneEquip mRewardCopyOne;

	private List<ChristmasDiffcultyItemCtrl> m_listItems;

	private LocalUnityObjctPool mObjPool;

	private LocalUnityObjctPool mRewardObjPool;

	private ChristmasDiffcultyUIProxy.Transfer mTransfer;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateUI()
	{
	}

	private void OnSelect(int id)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
