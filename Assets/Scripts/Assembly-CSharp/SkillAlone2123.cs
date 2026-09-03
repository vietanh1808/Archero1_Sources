using UnityEngine;

public class SkillAlone2123 : SkillAlone1033
{
	private int callPartBodyCount;

	protected float explodeRadius;

	protected float explodeDmgScale;

	protected virtual int SkillEffectID => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected override void Excute(string str, bool bExcute = false)
	{
	}

	private void OnPartBodyDisappear(EntityPartBodyBase partBody)
	{
	}

	protected virtual void CastSkill(EntityBase entity, Vector3 targetPos, bool isShowSelf)
	{
	}

	private void SendCreatePartBodyMsg(EntityBase entity, Vector3 pos)
	{
	}

	private void SyncCreatePartBodyMsg(EntityBase entity, Vector3 pos)
	{
	}

	private void SendCreateExplodeMsg(EntityBase entity, Vector3 pos)
	{
	}

	private void SyncCreateExplodeMsg(EntityBase entity, Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	protected override EntityPartBodyBase CallOne(EntityBase entity, Vector3? newCreatePos, bool CallPlusOne = false)
	{
		return null;
	}
}
