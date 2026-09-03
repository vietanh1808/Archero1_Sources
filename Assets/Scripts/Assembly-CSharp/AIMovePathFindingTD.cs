public class AIMovePathFindingTD : AIMovePathFinding
{
	private AIBase_TD aiBase;

	public AIMovePathFindingTD(EntityBase entity)
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
