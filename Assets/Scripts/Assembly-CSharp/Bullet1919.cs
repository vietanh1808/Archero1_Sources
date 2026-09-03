public class Bullet1919 : BulletBase
{
	private float fireRangeMini;

	private float fireRangeMax;

	private float fireAngleMin;

	private float fireAngleMax;

	private float fireAngle;

	public const int buffId = 8202;

	protected override void OnInit()
	{
	}

	protected override bool CanHitted(EntityBase entity)
	{
		return false;
	}
}
