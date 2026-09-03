public class Bullet3015 : BulletFlySwordBase
{
	public int DivideCount;

	public bool isDivide { get; set; }

	protected override void OnSetBulletAttribute()
	{
	}

	protected override void OnInit()
	{
	}

	public void IncreaseDivideCount()
	{
	}

	protected override float CalWaitTime()
	{
		return 0f;
	}
}
