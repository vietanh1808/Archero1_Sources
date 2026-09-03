using UnityEngine;

public class SkillAlone2108 : SkillAloneBase
{
	public class Skill1Effect2108IgniteVO : CustomJsonActionVO
	{
		public Vector3 pos;
	}

	private float explodeRate;

	private float explodeRadius;

	private float explodeHitRatio;

	private int bulletId;

	private const string SyncSkill2108_bullet = "SyncSkill2108_bullet";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	public BulletBase CreateExplosion(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private void SyncExplosion(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
