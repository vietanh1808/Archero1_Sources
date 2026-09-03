using UnityEngine;

public class SkillAlone2114 : SkillAloneBase
{
	public class Skill1Effect2114V0 : CustomJsonActionVO
	{
		public int sourceEntityId;

		public int targetEntityId;
	}

	private float judgeInterval;

	private float judgeDamageRatio;

	private float attachJudgeRate;

	private int judgeBuffId;

	private float secondEveryOnePercent;

	private float minJudgeInterval;

	private int selectBuffId;

	private int judgeBulletId;

	private const string SyncSkill2114_SynHit = "SyncSkill2114_SynHit";

	private EntityBase target;

	private EntityBase preTarget;

	private bool isInBossRoomOrPVP;

	private float preEffectTime;

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void UpdateTargetBuff()
	{
	}

	private void JudgeTarget()
	{
	}

	private void JudgeHit(EntityBase target, EntityBase source)
	{
	}

	public void CreateJudgeEff(int bulletId, Vector3 bulletPos)
	{
	}

	private float GetCdTime(EntityBase self, EntityBase target)
	{
		return 0f;
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncHit(int targetId, int sourceId)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
