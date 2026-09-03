public class SkillAlone2213 : SkillAloneBase
{
	private int[] bulletID;

	private float callRadius;

	private float innerRadius;

	private float innerHitRatio;

	private float outRadius;

	private float outHitRatio;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	public BulletBase CreateBullet(EntityBase target, int id, float radiusScale)
	{
		return null;
	}

	public int[] GetBulletID()
	{
		return null;
	}
}
