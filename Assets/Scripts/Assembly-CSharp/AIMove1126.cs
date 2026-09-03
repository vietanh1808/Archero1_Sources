using System;
using UnityEngine;

public class AIMove1126 : AIMove1011
{
	private Vector3? m_pos;

	private float m_fDistance;

	public AIMove1126(EntityBase entity, int min = 0, int max = 0)
		: base(null)
	{
	}

	public AIMove1126(EntityBase entity, Func<EntityBase, EntityBase> findTarget, int min = 0, int max = 0)
		: base(null)
	{
	}

	protected override void OnUpdate()
	{
	}
}
