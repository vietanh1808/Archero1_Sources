using System.Collections.Generic;
using UnityEngine;

public class ActionExplosionInEntity : ActionExplosionInPos
{
	public ActionExplosionInEntity(EntityBase entity, float radius)
		: base(null, default, 0f)
	{
	}

	public override List<EntityBase> GetTargetList()
	{
		return null;
	}

	public override Vector3 GetExplosionCenter()
	{
		return default;
	}
}
