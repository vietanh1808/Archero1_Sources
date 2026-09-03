using UnityEngine;

public class SkillAlone1830 : SkillAloneBase
{
	public class Skill1830_ShockExplode : CustomJsonActionVO
	{
		public Vector3 Pos;

		public int Guid;
	}

	private float shockWaveRate;

	private float shockWaveRadius;

	private float shockWaveRatio;

	private float shockWaveCDTime;

	private int debuffId;

	private float preExplodeTime;

	private int ExplodeBulletId;

	private bool isBatBombExist;

	private const string SyncSkill1830_ShockExplode = "SyncSkill1830_ShockExplode";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData hd)
	{
	}

	public BulletBase CreateExplode(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private void SyncShockExplode(int guid, Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
