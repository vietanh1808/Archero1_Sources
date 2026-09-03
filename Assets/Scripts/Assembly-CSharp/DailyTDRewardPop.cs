using UnityEngine;
using XLua;
using newplay122;

public class DailyTDRewardPop : MonoBehaviour
{
	private const float POS_Y = -50f;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private BattlePass_ChestPropOne propTemplate;

	[SerializeField]
	private RectTransform rtContentRoot;

	[SerializeField]
	private ButtonCtrl btnClose;

	private static readonly Vector2 vector2;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_resetPos;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	public void Open(TDWeekRewardVO rewardVO, Transform anchor)
	{
	}

	private void resetPos(int rewardCount)
	{
	}

	public void Close()
	{
	}
}
