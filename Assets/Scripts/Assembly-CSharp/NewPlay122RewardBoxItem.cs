using UnityEngine;
using XLua;
using newplay122;

public class NewPlay122RewardBoxItem : MonoBehaviour
{
	public class BoxParams
	{
		public TDWeekRewardVO RewardVO;

		public Transform Trans;
	}

	public Animation boxAnim;

	public DxxImage img_bg;

	public DxxImage img_corner;

	public DxxImage img_icon;

	public DxxImage img_check;

	public ButtonCtrl btn_get_reward;

	private int rewardId;

	protected TDWeekRewardVO rewardVO;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_standardBoxAnim;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_onClickGetReward;

	private static DelegateBridge __Hotfix0_get_RewardBoxAtlas;

	private static DelegateBridge __Hotfix0_GetRewardBoxStr;

	private static DelegateBridge __Hotfix0_GetBgStr;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected virtual string RewardBoxAtlas => null;

	public void Init(TDWeekRewardVO vo)
	{
	}

	private void standardBoxAnim()
	{
	}

	public void Refresh()
	{
	}

	private void onClickGetReward()
	{
	}

	protected virtual string GetRewardBoxStr()
	{
		return null;
	}

	private (string, string) GetBgStr()
	{
		return default;
	}
}
