using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSkinCollectUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText txtLv;

	[SerializeField]
	private DxxText txtLvShow;

	[SerializeField]
	private DxxText txtProgress;

	[SerializeField]
	private DxxText txtAtk;

	[SerializeField]
	private DxxText txtHp;

	[SerializeField]
	private DxxText txtAtkValue;

	[SerializeField]
	private DxxText txtHpValue;

	[SerializeField]
	private DxxText txtRewardTitle;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtCanGet;

	[SerializeField]
	private DxxText txtRewardValue;

	[SerializeField]
	private ButtonCtrl btnGet;

	[SerializeField]
	private ButtonCtrl btnTips;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ScrollRect scroll;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private DxxImage imgReward;

	[SerializeField]
	private WeaponSkinCollectLevelRewardItem rewardTemplate;

	[SerializeField]
	private GameObject goCanGet;

	[SerializeField]
	private PropOneEquip propReward;

	private LocalUnityObjctPool _pool;

	private const float SpecialItemHeight = 100f;

	private const float NormalItemHeight = 67f;

	private List<WeaponSkinCollectLevelRewardItem> _rewardList;

	private int CrtLv => 0;

	private List<WeaponSkinCollectRewardData> RewardList => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void RefreshUI(bool isSliderAni = false)
	{
	}

	private void RefreshLvInfo(bool isAni = false)
	{
	}

	private void RefreshAttrInfo()
	{
	}

	private void RefreshReward()
	{
	}

	private void LoadReward()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void OnBtnCloseClicked()
	{
	}

	private void OnGetRewardBtnClicked()
	{
	}
}
