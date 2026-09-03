using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2283 : SkillAloneBase
{
	private float CONFIG_RATE_MIN;

	private float CONFIG_RATE_MAX;

	private float CONFIG_TIME;

	private float CONFIG_HIT_RATIO;

	private int CONFIG_BUFF_ID;

	private float CONFIG_CD;

	private int CONFIG_BUFF_ID2;

	private Dictionary<EntityBase, long> _dicEntities;

	private Dictionary<EntityBase, Coroutine> _dicCoroutines;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void Play5100060Effect(EntityBase entity)
	{
	}

	private void Play5100061Effect(EntityBase entity)
	{
	}

	private void OnMonsterWillDead(EntityBase entity)
	{
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void OnReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void SyncSkill2283_1(EntityBase target)
	{
	}

	private void SyncSkill2283_2(EntityBase target)
	{
	}
}
