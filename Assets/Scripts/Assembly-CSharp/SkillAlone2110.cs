using UnityEngine;

public class SkillAlone2110 : SkillAloneBase
{
	public class Skill1Effect2110IgniteVO : CustomJsonActionVO
	{
		public Vector3 pos;

		public float rotation;
	}

	private float callRate;

	private float duration;

	private float CDTime;

	private float hitRatio;

	private float bulletRadius;

	private int bulletId;

	private float preHitTime;

	private const string SyncSkill2110_bullet = "SyncSkill2110_bullet";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnCreateForwardBullet(BulletBase bullet)
	{
	}

	public BulletBase CreateStorm(int bulletId, Vector3 bulletPos, float rotate, float atkPercent, float radius)
	{
		return null;
	}

	private void SyncExplosion(Vector3 pos, float rotate)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
