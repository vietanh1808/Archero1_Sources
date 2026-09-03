using UnityEngine;

public class WeaponSkinCollectLevelRewardItem : MonoBehaviour
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
	private PropOneEquip prop;

	private WeaponSkinCollectRewardData _data;

	private const float NormalPropScale = 0.45f;

	private const float SpecialPropScale = 0.7f;

	private int CrtLv => 0;

	public void Init(WeaponSkinCollectRewardData data)
	{
	}

	public void RefreshStatus()
	{
	}
}
