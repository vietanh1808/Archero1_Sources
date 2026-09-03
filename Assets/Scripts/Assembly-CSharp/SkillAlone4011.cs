public class SkillAlone4011 : SkillAloneBase
{
	private long clockindex;

	private int bulletid;

	private int createweight;

	private float hitratio;

	private float dropRadius;

	private float bulletRadius;

	private int minNum;

	private int maxNum;

	private float m_fLastSlopeTime;

	private int canBulletEject;

	private ActionBasic action;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAttack()
	{
	}

	private void UpdateBulletTransmit(BulletBase bullet)
	{
	}

	private bool OnBulletIsMeteor(int id)
	{
		return false;
	}
}
