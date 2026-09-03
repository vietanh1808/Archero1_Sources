public class HittedData : GameDataBase
{
	public EHittedType type;

	public float hitratio;

	public float backtatio;

	public float backAngle;

	public BulletBase bullet;

	public HitType hittype;

	public float angle => 0f;

	public void SetBullet(BulletBase bullet)
	{
	}

	public void AddBackRatio(float back)
	{
	}

	public bool GetCanHitted()
	{
		return false;
	}

	public bool GetPlayHitted()
	{
		return false;
	}

	public override void Reset()
	{
	}
}
