using System;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity
{
	public class PrizeWheelExtraTips : MonoBehaviour
	{
		[SerializeField]
		private DxxText mTextTitle;

		[SerializeField]
		private DxxText mTextContent;

		[SerializeField]
		private DxxText txtTotalTurn;

		[SerializeField]
		private ButtonCtrl[] mBtnBoxes;

		[SerializeField]
		private Image[] mImageBoxMasks;

		[SerializeField]
		private Image[] mImageTicks;

		[SerializeField]
		private Slider mSlider;

		[SerializeField]
		private DxxText[] mProgresses;

		[SerializeField]
		private Animation[] mAnimations;

		[SerializeField]
		private PrizeWheelBoxPreviewTips mPrizeWheelBoxPreviewTips;

		private ActivityTurnData m_data;

		private ActivityTurnData.BoxReward[] mBoxDatas;

		private LocalUnityObjctPool mPropOnePool;

		private Action m_claimAction;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_UpdateUI;

		private static DelegateBridge __Hotfix0_OnClickBox;

		private static DelegateBridge _c__Hotfix0_ctor;

		public void Init(ActivityTurnData actData, Action claimAction)
		{
		}

		private void UpdateUI()
		{
		}

		private void OnClickBox(Transform t, int i)
		{
		}
	}
}
