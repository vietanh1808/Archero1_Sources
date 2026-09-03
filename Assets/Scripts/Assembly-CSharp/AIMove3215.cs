public class AIMove3215 : AIMoveToTarget
{
	private bool changeRotateSpeed;

	private int deltaRotatePercentage;

	protected override bool isCloseEnough()
	{
		return false;
	}

	public AIMove3215(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnEnd()
	{
	}
}
