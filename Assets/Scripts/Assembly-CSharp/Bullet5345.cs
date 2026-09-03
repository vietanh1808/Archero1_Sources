public class Bullet5345 : Bullet3022
{
	private int isEffect;

	private float hitRise;

	protected override void OnSetArgs()
	{
	}

	public override float modifyCurHitRatio(EntityBase target)
	{
		return 0f;
	}

	protected override void OnOverDistance()
	{
	}
}
