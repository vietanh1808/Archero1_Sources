using Daily129;
using UnityEngine;

public class EntityTower8006 : EntityTowerBase
{
	public Vector2Int VecPos;

	public TowerModel TowerModel;

	private Daily129InGameController _inGameController;

	private GameObject _upgradeEffect;

	protected override void OnInit()
	{
	}

	protected override void OnCreateModel()
	{
	}

	public override bool GetIsDead()
	{
		return false;
	}

	public override void DeInit()
	{
	}

	public override bool SetHitted(HittedData data)
	{
		return false;
	}

	public void ShowCanUpgradeEffect(bool show)
	{
	}

	public void PlayHittedEffect()
	{
	}
}
