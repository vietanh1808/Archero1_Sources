using System;
using UnityEngine;

public class EntityTD2023Base : EntityCallBase
{
	public GameObject LvUpEffect;

	public Action OnTDAttackSpeedChanged;

	public int DivideCountOfBullet1905;

	public int tdLevel;

	public TDAreaVO tdAreaVO;

	protected ActionBasic action;

	public bool IsObstacleTower;

	public bool HasUpgradeSkills;

	private bool isHeroEntered;

	protected override string ModelPath => null;

	protected override void OnInitAfter()
	{
	}

	public void PlayLvUpEffect()
	{
	}

	protected override void OnAfterAddInitSkills()
	{
	}

	public void OnTDLevelUp(BattleTowerDefense2023UICtrl.TowerLvUpSuccessData successData)
	{
	}

	protected override void OnTriggerEnterExtra(Collider collider)
	{
	}

	protected override void OnTriggerExitExtra(Collider collider)
	{
	}

	public void Init(int id, float time)
	{
	}

	protected override void OnInitBefore()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void StartInit()
	{
	}

	protected virtual int GetDefaultHPSliderId()
	{
		return 0;
	}

	protected virtual bool IsInvincible()
	{
		return false;
	}

	protected virtual bool GetColliderEnabled()
	{
		return false;
	}

	protected virtual bool CanShowHP()
	{
		return false;
	}

	protected override void InitAnimations()
	{
	}

	protected override void OnDeInitLogic()
	{
	}

	public void onAnchorChanged()
	{
	}

	protected override void UpdateProcess(float delta)
	{
	}

	protected virtual void PartBodyUpdate(float delta)
	{
	}

	protected override void OnDeInit()
	{
	}

	public void SetTDAreaVO(TDAreaVO vo)
	{
	}

	public bool IsInTDArea(Vector2Int XY)
	{
		return false;
	}
}
