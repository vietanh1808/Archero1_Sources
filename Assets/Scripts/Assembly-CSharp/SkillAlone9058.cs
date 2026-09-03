using UnityEngine;

public class SkillAlone9058 : SkillAloneBase
{
	private float hitRiseRate;

	private float explodeRadius;

	private float explodeHitRatio;

	private int frozenDebuffId;

	private int iceExplodeBulletId;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnEnemyDing(EntityBase target)
	{
	}

	private float OnCalValue(HitStruct ht, EntityBase entity)
	{
		return 0f;
	}

	public BulletBase CreateExplode(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}
}
