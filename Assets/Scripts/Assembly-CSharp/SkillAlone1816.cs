using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1816 : SkillAloneBase
{
	private int igniteProb;

	private float igniteRadius;

	private float igniteDmgMult;

	private int igniteBuffID;

	private int fireAndSpeedProb;

	private int fireAndSpeedBuffID;

	private int fireAndSpeedInterval;

	private float fireRangeSpeed;

	private List<SkillAlone1816GoodCtrl> createList;

	private float lastAddTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHeadShot(EntityBase entity, bool lessHpHeadShot)
	{
	}

	private void OnCrit(EntityBase entity, long value)
	{
	}

	private void SendCreateIgniteMsg(Vector3 pos)
	{
	}

	private void SyncCreateIgniteMsg(EntityBase entity, Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void CheckIgnite(Vector3 createPos)
	{
	}

	private void CreateIgnite(EntityBase entity, Vector3 createPos)
	{
	}

	private void CheckFireAndSpeed()
	{
	}

	private void RecycleResource(RoomGenerateBase.Room room)
	{
	}
}
