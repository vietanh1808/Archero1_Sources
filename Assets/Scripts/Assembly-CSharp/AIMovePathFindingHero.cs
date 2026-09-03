public class AIMovePathFindingHero : AIMovePathFinding
{
	public float HeroHittedRadius;

	private AIBase_TD aiBase;

	public AIMovePathFindingHero(EntityBase entity)
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
