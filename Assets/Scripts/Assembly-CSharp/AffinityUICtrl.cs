using System.Collections.Generic;
using UnityEngine;

public class AffinityUICtrl : MediatorCtrlBase
{
	private LocalUnityObjctPool ItemCardPool;

	public GameObject ItemCardCache;

	public AffinityItemCtrl CopyOne;

	public RectTransform mContent;

	public ButtonCtrl mBtnClose;

	public DxxText mTextTitle;

	private List<AffinityItemCtrl> m_listItems;

	private AffinityProxy.Transfer mTransfer;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private bool IsAffinity(int[] ids)
	{
		return false;
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
