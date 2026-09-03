using TableTool;

public class SkillAloneMeteoriteBase : SkillAloneBase
{
	protected BulletSlopeBase CreateMeteoriteBullet(int nBulletId, float fRadius, float fInnerRadius, float fInnerHitRatio, float fOutRadius, float fOutHitRatio)
	{
		return null;
	}

	private void OnBulletOverDistance(BulletSlopeBase bullet)
	{
	}

	protected virtual bool OnMeteoriteOverDistance(BulletSlopeBase bullet)
	{
		return false;
	}

	private void SendHit(EntityBase entity, BulletBase bullet, Weapon_weapon data, float ratio)
	{
	}

	protected virtual float CalAttackRatio(EntityBase entity)
	{
		return 0f;
	}

	protected virtual void OnSendHit(EntityBase entity, BulletBase bullet)
	{
	}
}
