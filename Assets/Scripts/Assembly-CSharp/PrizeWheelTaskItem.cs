using Activity;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class PrizeWheelTaskItem : MonoBehaviour
{
	[SerializeField]
	private DxxImage imgItemBg;

	[SerializeField]
	private DxxImage imgBgProgressVal;

	[SerializeField]
	private DxxImage imgItemProgressBar;

	[SerializeField]
	private DxxImage imgBgItemProgressBar;

	[SerializeField]
	private DxxImage imgRewardIcon;

	[SerializeField]
	private GameObject goBg;

	[SerializeField]
	private GameObject goProgress;

	[SerializeField]
	private ButtonCtrl btnClaim;

	[SerializeField]
	private DxxText txtComplete;

	[SerializeField]
	private DxxText txtBtnClaim;

	[SerializeField]
	private DxxText txtContent;

	[SerializeField]
	private DxxText txtProgress;

	[SerializeField]
	private DxxText txtRewardCount;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private PrizeWheelPanel panel;

	private ActivityTurnTask task;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_SetData;

	private static DelegateBridge __Hotfix0_CanClaim;

	private static DelegateBridge __Hotfix0_Claimed;

	private static DelegateBridge __Hotfix0_Unfinished;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	public void SetData(ActivityTurnTask task, PrizeWheelPanelStyle style)
	{
	}

	private void CanClaim()
	{
	}

	private void Claimed()
	{
	}

	private void Unfinished()
	{
	}
}
