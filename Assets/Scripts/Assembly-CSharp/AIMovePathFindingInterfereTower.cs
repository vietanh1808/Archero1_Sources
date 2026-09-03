public class AIMovePathFindingInterfereTower : AIMovePathFinding
{
	public float TowerHittedRadius;

	private AIBase_TD aiBase;

	public AIMovePathFindingInterfereTower(EntityBase entity)
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
