using UnityEngine;

public class HeroSkinCollectLevelRewardItem : ViewCell
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

	[SerializeField]
	private RectTransform rectTransform;

	private HeroSkinCollectRewardData _data;

	private const float NormalPropScale = 0.45f;

	private const float SpecialPropScale = 0.7f;

	private int CrtLv => 0;

	protected override void OnRefresh()
	{
	}

	public void RefreshStatus()
	{
	}
}
