using Ara;

public class Bullet9039 : BulletBase
{
	public int InitCustomEjectCount;

	public float InitRatio;

	public float DecreaseRatio;

	public float MinRatio;

	private AraTrail mTrail;

	private int hitCount;

	private int TotalCustomEjectCount;

	protected override void OnInit()
	{
	}

	public void RefreshCustomEjectCount(int value)
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override bool IsCustomArrowEject()
	{
		return false;
	}

	protected override void OnHitEventInternal(EntityBase entity, float hittedAngle)
	{
	}

	public override float modifyCurHitRatio(EntityBase target)
	{
		return 0f;
	}

	private void hideTrail()
	{
	}
}
