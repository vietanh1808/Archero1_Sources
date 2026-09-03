using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSkinLevelUpUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private WeaponSkinLevelUpRewardItem rewardTemplate;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtMatTitle;

	[SerializeField]
	private DxxText txtMaxLvTips;

	[SerializeField]
	private DxxText txtMoonCount;

	[SerializeField]
	private DxxText txtSkinKey;

	[SerializeField]
	private ScrollRect scroll;

	[SerializeField]
	private WeaponSkinWeaponItem weaponItem;

	[SerializeField]
	private PropOneEquip propTemplate;

	[SerializeField]
	private RectTransform matParent;

	[SerializeField]
	private ButtonCtrl btnEnhance;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private GameObject levelUpAni;

	[SerializeField]
	private GameObject goMat;

	private LocalUnityObjctPool _pool;

	private const float SpecialItemHeight = 100f;

	private const float NormalItemHeight = 67f;

	private const float SkillItemHeight = 100f;

	private List<WeaponSkinLevelUpRewardItem> _rewardList;

	private int _curSkinID;

	private List<WeaponSkinLevelUpRewardData> RewardList => null;

	private int curSkinLv => 0;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshReward()
	{
	}

	private void RefreshCurrencyProp()
	{
	}

	private void RefreshWeaponModel()
	{
	}

	private void RefreshMaterial()
	{
	}

	private void LoadReward()
	{
	}

	private void OnBtnEnhanceClick()
	{
	}

	private void OnBtnCloseClicked()
	{
	}

	private void PlayLevelUpEffect()
	{
	}
}
