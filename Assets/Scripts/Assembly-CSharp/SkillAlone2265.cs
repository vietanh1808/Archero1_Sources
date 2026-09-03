using UnityEngine;

public class SkillAlone2265 : SkillAloneBase
{
	public class Skill2265_SwordFall : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	private float callFallRate;

	private float fallHitRatio;

	private float fallRadius;

	private float fieldDuration;

	private float fieldRadius;

	private int fieldBuffId;

	private float CDTime;

	private float closeRateRise;

	private float fallHitRatioArthur;

	private float preEffectTime;

	private const int SwordFallBulletId = 8927;

	private const string SwordFieldEffPath = "Game/Aura/AuraKingSword";

	private const string SwordFieldEffPathPVP = "Game/Aura/AuraKingSwordPVP";

	private const string SyncSkill2265_SwordFall = "SyncSkill2265_SwordFall";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void OnHitAction(EntityBase entity, HitStruct hs, HittedData ht)
	{
	}

	private void ParseParams()
	{
	}

	private BulletBase CreatSword(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private void CreateSwordField(Vector3 pos, bool isEnermy)
	{
	}

	private void SyncSwordFall(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
