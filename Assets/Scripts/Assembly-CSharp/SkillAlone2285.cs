using UnityEngine;

public class SkillAlone2285 : SkillAloneBase
{
	private class SkillEffect2285_SyncEffVO : CustomJsonActionVO
	{
		public int Guid;

		public int Count;
	}

	private float callLanternRate;

	private int lanternBuffId;

	private int maxLanternNum;

	private float lanternRadius;

	private int springBuffId;

	private float hitExplodeRadius;

	private float hitRatio;

	private float endExplodeRadius;

	private float endRatio;

	private float cdTime;

	private int curLanternNum;

	private float preExplodeTime;

	private const string LanternEffPath = "Effect/Battle/eff_springFstvsun_lamp";

	private int smallExplodeId;

	private int finalExplodeId;

	private const string SyncSkill2285_SyncEff = "SyncSkill2285_SyncEff";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnAttack()
	{
	}

	private void OnBuffRemovedByTime(EntityBase entity, int buffId)
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData data)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private BulletBase CreateSmallExplode(Vector3 bulletPos, float rotate, float atkPercent, float radius)
	{
		return null;
	}

	private BulletBase CreateFinalExplode(Vector3 bulletPos, float rotate, float atkPercent, float radius)
	{
		return null;
	}

	private BulletBase CreateExplode(int bulletId, Vector3 bulletPos, float rotate, float atkPercent, float radius)
	{
		return null;
	}

	private void SyncEffectCount(int guid, int count)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
