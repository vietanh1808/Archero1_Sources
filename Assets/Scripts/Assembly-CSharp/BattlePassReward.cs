using UnityEngine;
using UnityEngine.UI;

public class BattlePassReward : MonoBehaviour
{
	[SerializeField]
	private DxxText textLevel;

	[SerializeField]
	private BattlePass_PropOne tokenReward;

	[SerializeField]
	private BattlePass_PropOne tokenRewardPremium;

	[SerializeField]
	private BattlePass_PropOne normalReward;

	[SerializeField]
	private BattlePass_PropOne tokenRewardBig;

	[SerializeField]
	private BattlePass_PropOne tokenRewardBigPremium;

	[SerializeField]
	private BattlePass_PropOne normalRewardBig;

	private LocalSave.BattlePassConfigData_Unit tableData;

	public GameObject connectLineTop;

	public GameObject connectLineBottom;

	[SerializeField]
	private DxxText normalGetText;

	[SerializeField]
	private DxxText tokenGetText;

	[SerializeField]
	private DxxText tokenPremiumGetText;

	public BattlePassChestInformation chestInfo;

	public Image levelBg;

	public Image iconFreeBg;

	public Image iconNormalBg;

	public Image iconPremiumBg;

	public Image iconColumnSplit;

	public Image iconColumnSplitLv;

	public Image iconLineSplit;

	private const byte Normal = 0;

	private const byte Paid = 1;

	private const byte PaidPremium = 2;

	private void Awake()
	{
	}

	public void SetData(LocalSave.BattlePassConfigData_Unit data)
	{
	}

	public void RefreshSprite()
	{
	}

	public void Refresh()
	{
	}

	private void OnClickReward(PropOneBase prop, byte rewardType)
	{
	}

	public void OnLanguageChange()
	{
	}

	private string GetSource(int id, int type)
	{
		return null;
	}
}
