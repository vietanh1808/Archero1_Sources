public class AIBase_FrozenFort_Monster : AIDizzyBase
{
	public class AIMovePathFindingFort : AIMovePathFinding
	{
		private AIBase_FrozenFort_Monster aiBase;

		public AIMovePathFindingFort(EntityBase entity)
			: base(null)
		{
		}

		protected override void OnInitBase()
		{
		}

		protected override bool canInterrupt()
		{
			return false;
		}
	}

	private float FortSpeedTimes;

	private float FortCheckRadius;

	private EntityBase FortTarget;

	public int SizeRange { get; set; }

	public virtual float TwistFactor => 0f;

	public void SetFortTarget(EntityBase _entity)
	{
	}

	public EntityBase GetFortTarget()
	{
		return null;
	}

	protected override void OnInit()
	{
	}

	protected override void PopulateActions()
	{
	}

	protected virtual ActionBase GetAttackFortBaseAction()
	{
		return null;
	}

	public virtual ActionBase GetMonsterAtkAction()
	{
		return null;
	}
}
