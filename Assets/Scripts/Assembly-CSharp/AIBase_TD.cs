public class AIBase_TD : AIDizzyBase
{
	public float HeroHittedRadius;

	protected float HeroSpeedTimes;

	protected float BaseSpeedTimes;

	public float BaseCheckRadius;

	public float HeroCheckRadius;

	private EntityBase TDTarget;

	private EntityBase interfereTower;

	public int SizeRange { get; set; }

	public virtual float TwistFactor => 0f;

	public void SetTDTarget(EntityBase _entity)
	{
	}

	public EntityBase GetTDTarget()
	{
		return null;
	}

	public void SetInterfereTower(EntityBase _towerTarget)
	{
	}

	public EntityBase GetInterfereTower()
	{
		return null;
	}

	protected override void OnInit()
	{
	}

	protected override void PopulateActions()
	{
	}

	protected virtual ActionBase GetAttackTDBaseAction()
	{
		return null;
	}

	protected virtual ActionBase GetAttackHeroAction()
	{
		return null;
	}

	protected virtual ActionBase GetAttackTowerAction()
	{
		return null;
	}

	public virtual ActionBase GetMonsterAtkAction()
	{
		return null;
	}

	protected ActionBase GetActionMovPathFindingHero()
	{
		return null;
	}

	protected ActionBase GetActionMovPathFindingInterfereTower()
	{
		return null;
	}

	public ActionBase GetAITransportAction(EntityBase towerEntity)
	{
		return null;
	}
}
