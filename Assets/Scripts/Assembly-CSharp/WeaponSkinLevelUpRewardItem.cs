using UnityEngine;

public class WeaponSkinLevelUpRewardItem : MonoBehaviour
{
	[SerializeField]
	private DxxImage imgAtt;

	[SerializeField]
	private DxxImage imgLvBg;

	[SerializeField]
	private GameObject goSpecialBg;

	[SerializeField]
	private GameObject goLockedProgress;

	[SerializeField]
	private GameObject goUnlockedProgress;

	[SerializeField]
	private GameObject goTick;

	[SerializeField]
	private GameObject goGot;

	[SerializeField]
	private DxxText txtRewardName;

	[SerializeField]
	private DxxText txtLv;

	[SerializeField]
	private DxxText txtAll;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private GameObject goAllTips;

	private WeaponSkinLevelUpRewardData _data;

	private const float NormalPropScale = 0.45f;

	private const float SpecialPropScale = 0.7f;

	private int _crtLv;

	public void Init(WeaponSkinLevelUpRewardData data, int crtLv)
	{
	}

	public void RefreshStatus(int crtLv)
	{
	}
}
