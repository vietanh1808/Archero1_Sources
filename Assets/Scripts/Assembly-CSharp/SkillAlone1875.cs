public class SkillAlone1875 : SkillAlonePetBase
{
	private const int BULLET_ID = 1543;

	private float deltaFireAtkPercent;

	private float deltaExplodePercent;

	private float fireAtkPercent;

	private float explodePercent;

	private int bulletDebuff;

	private float explodeRadius;

	private float bulletSpeedPercent;

	private EntityPet4004 pet;

	private float atkInterval;

	private ActionBasic atkAI;

	private float animReadyTime;

	private float deltaAnimReadySpeed;

	private float animPrevTime;

	private float animEndTime;

	private Bullet1543 bullet;

	private EntityBase playerEntity => null;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	private void initAtkAI()
	{
	}

	private void deinitAtkAI()
	{
	}

	private bool isAttacking()
	{
		return false;
	}

	private AIBase.ActionSequence getAtkSeq()
	{
		return null;
	}

	private void initAnims()
	{
	}

	private Bullet1543 createBullet()
	{
		return null;
	}
}
