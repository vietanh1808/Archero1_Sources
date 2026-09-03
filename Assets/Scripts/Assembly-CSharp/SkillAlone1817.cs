using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1817 : SkillAloneBase
{
	private SkillAlone1817Data skillData;

	private List<SkillAlone1817GoodCtrl> createList;

	private float lastCreateTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase entity, long hit)
	{
	}

	private void HitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void SendCreateBoomerangMsg(Vector3 pos)
	{
	}

	private void SyncCreateBoomerangMsg(EntityBase entity, Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void CheckBoomerang()
	{
	}

	private void CreateBoomerang(EntityBase entity, Vector3 pos, bool isUseRed)
	{
	}

	private void RecycleResource(RoomGenerateBase.Room room)
	{
	}
}
