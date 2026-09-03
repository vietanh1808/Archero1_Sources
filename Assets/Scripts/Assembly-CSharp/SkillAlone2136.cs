using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2136 : SkillAloneBase
{
	private float CONFIG_RATE;

	private int CONFIG_RADIUS;

	private float CONFIG_CD;

	private int CONFIG_BUFF_ID;

	private float CONFIG_RATIO;

	private int CONFIG_MAX;

	private List<GameObject> _objs;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitEnemy(EntityBase entity, HitStruct ht, HittedData data)
	{
	}

	protected virtual void CreateEffect(float x, float z)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
