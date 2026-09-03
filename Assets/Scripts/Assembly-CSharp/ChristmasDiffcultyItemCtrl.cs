using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ChristmasDiffcultyItemCtrl : MonoBehaviour
{
	[SerializeField]
	private DxxText mTextLevel;

	[SerializeField]
	private DxxText mTextRewardTitle;

	[SerializeField]
	private ButtonCtrl mBtnGet;

	[SerializeField]
	private DxxText mTextGet;

	[SerializeField]
	private Image mImgSelected;

	[SerializeField]
	private PropOneEquip mCopyOne;

	[SerializeField]
	private Transform mRewardParent;

	private Daily_HeroPartyDifficult m_data;

	private Action<int> OnSelectAction;

	private Func<PropOneEquip> OnCreateRewardFunc;

	public void Init(Daily_HeroPartyDifficult data, Action<int> OnSelectAction, Func<PropOneEquip> OnCreateRewardFunc)
	{
	}

	private void OnClick()
	{
	}

	private void UpdateUI()
	{
	}
}
