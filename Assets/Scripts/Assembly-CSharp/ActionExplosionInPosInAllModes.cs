using System.Collections.Generic;
using UnityEngine;

public class ActionExplosionInPosInAllModes : ActionExplosionInPos
{
	public ActionExplosionInPosInAllModes(EntityBase entity, Vector3 centerPos, float radius)
		: base(null, default, 0f)
	{
	}

	public ActionExplosionInPosInAllModes(EntityBase entity, float radius)
		: base(null, default, 0f)
	{
	}

	public override List<EntityBase> GetTargetList()
	{
		return null;
	}
}
