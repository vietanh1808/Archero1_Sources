public class SkillAlone1078 : SkillAloneBase
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

	protected ActionBasic action;

	protected virtual bool Condition => false;

	protected virtual bool CheckLastSlopTime => false;

	protected virtual int MinNum => 0;

	protected virtual int MaxNum => 0;

	protected virtual float DropRadius => 0f;

	protected virtual float HitRatio => 0f;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAttack()
	{
	}

	protected void CreateStarBullets(int id)
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
