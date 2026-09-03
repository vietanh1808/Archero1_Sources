public class AIBase_Artifact_Monster : AIDizzyBase
{
	public class AIMovePathFindingArtifact : AIMovePathFinding
	{
		private AIBase_Artifact_Monster aiBase;

		public AIMovePathFindingArtifact(EntityBase entity)
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

	public class AIMovePathFindingHero_Artifact : AIMovePathFinding
	{
		public float HeroHittedRadius;

		private AIBase_Artifact_Monster aiBase;

		public AIMovePathFindingHero_Artifact(EntityBase entity)
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

	public float HeroHittedRadius;

	protected float HeroSpeedTimes;

	protected float ArtifactSpeedTimes;

	public float ArtifactCheckRadius;

	public float HeroCheckRadius;

	private EntityBase TDTarget;

	public int SizeRange { get; set; }

	public virtual float TwistFactor => 0f;

	public void SetTDTarget(EntityBase _entity)
	{
	}

	public EntityBase GetTDTarget()
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

	public virtual ActionBase GetMonsterAtkAction()
	{
		return null;
	}

	protected ActionBase GetActionMovPathFindingHero()
	{
		return null;
	}
}
