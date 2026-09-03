using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class EntityData_Net : EntityData
{
	protected override void OnMonsterDeadCall(EntityBase entity)
	{
	}

	public override List<EntityBase> GetTargets()
	{
		return null;
	}

	protected override void OnAttackMeteorite(AttackCallData data, Vector3 pos, float time)
	{
	}

	public override void ExcuteAttributeCommand(string attname, long attvalue, EntityAttributeBase.ValueType valuetype = EntityAttributeBase.ValueType.Normal)
	{
	}

	private bool isSpecialCase()
	{
		return false;
	}
}
