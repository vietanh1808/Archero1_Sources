using DG.Tweening;
using UnityEngine;
using XLua;

public class BattleTowerDefense2023CreateButton : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl btnCtrl;

	[SerializeField]
	private DxxText txtPrice;

	[SerializeField]
	private DxxImage imgBg;

	public DxxImage imgIcon;

	private int id;

	private int cost;

	private bool isTower;

	private Sequence seq;

	private BattleTowerDefense2023UICtrl ctrl;

	private static DelegateBridge __Hotfix0_get_coin;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_SetData;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_CreateTower;

	private static DelegateBridge __Hotfix0_OnSpaceOccupied;

	private static DelegateBridge __Hotfix0_ForbidTower;

	private static DelegateBridge _c__Hotfix0_ctor;

	private int coin => 0;

	private void Awake()
	{
	}

	public void SetData(int id, BattleTowerDefense2023UICtrl ctrl)
	{
	}

	public void Refresh()
	{
	}

	private void CreateTower()
	{
	}

	private void OnSpaceOccupied()
	{
	}

	private static bool ForbidTower(int towerId, Vector2Int xy)
	{
		return false;
	}
}
