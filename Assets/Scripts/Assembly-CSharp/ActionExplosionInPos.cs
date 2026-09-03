using System;
using System.Collections.Generic;
using UnityEngine;

public class ActionExplosionInPos
{
	public string ExternalTag;

	public int DeBuffId;

	public float AttackPercent;

	public Action<EntityBase> HitEnemyCallback;

	public Func<long> GetBodyHit;

	protected EntityBase m_Entity;

	private Vector3 CenterPos;

	protected float Radius;

	public bool SameTeam;

	public bool ShowEffect;

	public ActionExplosionInPos(EntityBase entity, Vector3 centerPos, float radius)
	{
	}

	public ActionExplosionInPos(EntityBase entity, float radius)
	{
	}

	public virtual List<EntityBase> GetTargetList()
	{
		return null;
	}

	public virtual Vector3 GetExplosionCenter()
	{
		return default;
	}

	public void Explode()
	{
	}
}
