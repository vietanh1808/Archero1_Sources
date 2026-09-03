using TableTool;
using UnityEngine;
using XLua;

namespace Activity
{
	public class ActivityBattlePassReward : MonoBehaviour
	{
		[SerializeField]
		private DxxText txtLevel;

		[SerializeField]
		private DxxText txtGetNormal;

		[SerializeField]
		private DxxText txtGetToken;

		[SerializeField]
		private DxxText txtGetPremium;

		[SerializeField]
		private BattlePass_PropOne tokenReward;

		[SerializeField]
		private BattlePass_PropOne tokenRewardPremium;

		[SerializeField]
		private BattlePass_PropOne freeReward;

		[SerializeField]
		private BattlePass_PropOne tokenRewardBig;

		[SerializeField]
		private BattlePass_PropOne tokenRewardBigPremium;

		[SerializeField]
		private BattlePass_PropOne freeRewardBig;

		public GameObject goConnectTop;

		public GameObject goConnectBottom;

		public DxxImage bgLevel;

		public BattlePassChestInformation chestInformation;

		private int index;

		private int point;

		private Drop_DropModel.DropData rewardFree;

		private Drop_DropModel.DropData rewardToken;

		private Drop_DropModel.DropData rewardPaidPremium;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_SetData;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_OnClickReward;

		private static DelegateBridge __Hotfix0_GetSource;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		public void SetData(int index, int[] free, int[] paid, int[] paidPremium, int point)
		{
		}

		public void Refresh()
		{
		}

		private void OnClickReward(PropOneBase prop, ActivityTreasureData.RewardType rewardType)
		{
		}

		private string GetSource(ActivityTreasureData.RewardType type)
		{
			return null;
		}
	}
}
