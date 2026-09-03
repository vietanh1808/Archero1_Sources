using DG.Tweening;
using TableTool;
using UnityEngine;

public class BattleDailyTDCreateButton : MonoBehaviour
{
	public int index;

	[SerializeField]
	private DxxImage imgPlus;

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

	private BattleDailyTDUICtrl ctrl;

	private Daily_DefenseTower config;

	private PVEStage_DefenseTower seasonConfig;

	private int coin => 0;

	private void Awake()
	{
	}

	public void SetData(int id, BattleDailyTDUICtrl ctrl, int index)
	{
	}

	private int getBuildCost()
	{
		return 0;
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
