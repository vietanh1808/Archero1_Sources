using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1831 : SkillAloneBase
{
	public class Skill1830_CallPart : CustomJsonActionVO
	{
		public Vector3 Pos;

		public int Guid;
	}

	private int ballBuffId;

	private int ballDebuffId;

	private float addDebuffRate;

	private float addDebuffCDTime;

	private Dictionary<int, int> AttackedEnermyDict;

	private float preAddBuffTime;

	private EntityHero self;

	private const string SyncSkill1831_CallPart = "SyncSkill1831_CallPart";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHitAction(EntityBase enermy, HitStruct hs, HittedData hd)
	{
	}

	protected Vector3 GetRandomPos(EntityBase entity)
	{
		return default;
	}

	private void DeadAction(EntityBase entity)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncCallPart(int guid, Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
