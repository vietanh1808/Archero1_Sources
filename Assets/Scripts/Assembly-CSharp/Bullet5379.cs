using System;
using UnityEngine;

public class Bullet5379 : Bullet3071
{
	private bool isRecycleByNextRoom;

	private Func<EntityBase> findAttackTarget;

	private Action<Vector3> bullet5379DeInit;

	protected override void OnInit()
	{
	}

	public void SetBullet5379Data(int ejectCount, Func<EntityBase> findAttackTarget, Action<Vector3> bullet5379DeInit)
	{
	}

	public void AddBulletEjectCount(int deltaEjectCount)
	{
	}

	protected override bool ExcuteCustomEject(EntityBase entity)
	{
		return false;
	}

	protected override void OnDeInit()
	{
	}

	public void RecycleByNextRoom()
	{
	}

	protected override void UpdateCustomEjectCount(int delta)
	{
	}

	private void CheckShowPar()
	{
	}

	protected override EntityBase GetTrackTarget()
	{
		return null;
	}

	protected override void OnBulletTrack()
	{
	}

	public int GetCurCustomEjectCount()
	{
		return 0;
	}
}
