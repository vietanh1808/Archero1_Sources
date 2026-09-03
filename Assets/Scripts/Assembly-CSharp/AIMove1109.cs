public class AIMove1109 : AIMovePathFindingHitted
{
	private float sqrDis;

	protected override float AnimSpeedTimes => 0f;

	public AIMove1109(EntityBase entity)
		: base(null)
	{
	}

	protected override bool canInterrupt()
	{
		return false;
	}
}
