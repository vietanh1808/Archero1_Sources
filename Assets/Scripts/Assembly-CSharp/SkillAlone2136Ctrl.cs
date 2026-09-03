using System;
using UnityEngine;

public class SkillAlone2136Ctrl : FoodBase
{
	[SerializeField]
	private Collider _collider;

	[SerializeField]
	private GameObject[] _effects;

	private EntityHero _entity;

	private float _hitRatio;

	private int _buffId;

	private ActionBasic _action;

	private Action<GameObject> _callback;

	protected override EntityHero AbsorbEntity => null;

	public void Init(EntityHero entity, float ratio, int buffId, Action<GameObject> callback)
	{
	}

	private void DeInit()
	{
	}

	protected override void OnAwakeInit()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	protected override void AbsorbFoods()
	{
	}

	protected override void SetPropClearness(BattlePropClearness clearness)
	{
	}

	private void OnLanceChangeState(bool state)
	{
	}

	protected override void OnAbsorbEnd()
	{
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}
}
