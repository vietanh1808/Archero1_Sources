using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening;
using UnityEngine;

public class AIMeadowBattleBase : AIGroundBase
{
	public enum MoveStateInAttack
	{
		straight = 0,
		bezier = 1,
		underground = 2
	}

	public bool IsEvoluated;

	public Vector2Int oldRowCol;

	private List<GameObject> cacheAlarmCicles;

	private List<GameObject> debugCircleList;

	private float offsetAngle;

	public Sequence seq;

	private Vector3 faceDir => default;

	private Vector3 centerPos => default;

	public virtual MoveStateInAttack CurMoveStateInAttack => MoveStateInAttack.straight;

	public virtual bool CanBeSearched { get; set; }

	public virtual bool CanSearchEnemy { get; set; }

	public virtual bool CanSearchTargetAfterEvolved => false;

	public ObscuredInt[] CustomAttackWeights { get; private set; }

	protected override void OnInitOnce()
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	private void updateBodyGrids()
	{
	}

	public void PrintAction()
	{
	}

	public void InitDebugLocationCircles()
	{
	}

	public override void DestroyMeadowBattleCircles()
	{
	}

	public virtual void AddAttackActions()
	{
	}

	protected virtual ActionBase GetActionMeadowBattleAttack()
	{
		return null;
	}

	public void StartFreeAttack()
	{
	}

	private void onEvolved()
	{
	}

	public void SyncCircles()
	{
	}

	public void SetCirclesVisible(bool visible)
	{
	}

	public void SetAlarmCiclesVisible(bool visible)
	{
	}

	public void SetDebugCiclesVisible(bool visible)
	{
	}

	public void SyncAlarmCircles()
	{
	}

	private void SyncDebugCircles()
	{
	}

	public void CreateCacheAlarmCircles()
	{
	}

	public void ClearAlarmCircles()
	{
	}

	public void CreateDebugCircles()
	{
	}

	public void ClearDebugCircles()
	{
	}

	public void ClearDebugCircleList()
	{
	}

	public MeadowBattleMonsterInfo.AttackAreaEnum GetAttackAreaEnum()
	{
		return (MeadowBattleMonsterInfo.AttackAreaEnum)0;
	}

	public virtual bool checkIfHitWalls(float maxDistance, out RaycastHit hitInfo)
	{
		hitInfo = default;
		return false;
	}

	private bool rayCast(Vector3 dir, float maxDistance, out RaycastHit hitInfo)
	{
		hitInfo = default;
		return false;
	}

	public void SetShadowVisible(bool visible)
	{
	}

	public virtual void ShowAnimFromUnderground(Action showComplete)
	{
	}

	public virtual void HideAnimToUnderground(Action hideStart, Action hideComplete)
	{
	}

	public void killSeq()
	{
	}

	public void enableSearch(bool enabled, bool checkCircle = true)
	{
	}

	protected void onHideAnimStarted(Action hideStart, Action playAnim)
	{
	}

	protected void onHideAnimFinished(Action hideComplete)
	{
	}

	protected void onShowAnimStarted(Action playAnim)
	{
	}

	protected void onShowAnimFinished(Action showComplete)
	{
	}

	public void SetCustomAttackWeights(ObscuredInt[] value)
	{
	}

	public bool IsInAttackAreas(EntityBase enemy, List<Vector2Int> attackArea)
	{
		return false;
	}

	public bool IsInAttackAreas(EntityBase enemy)
	{
		return false;
	}
}
