using System;
using UnityEngine;

public class NobilityRuleUICtrl : MonoBehaviour
{
	[SerializeField]
	private DxxText mTextTitle;

	[SerializeField]
	private ButtonCtrl mBtnClose;

	[SerializeField]
	private RectTransform mRtContent;

	[SerializeField]
	private DxxText mCopyOne;

	private bool m_bInitFlag;

	public void Init(Action onClose)
	{
	}
}
