using Ara;

public class Bullet3063 : Bullet3015
{
	public int InitCustomEjectCount;

	private float InitRatio;

	public float DecreaseRatio;

	public float MinRatio;

	private AraTrail mTrail;

	private int hitCount;

	protected int TotalCustomEjectCount;

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

	public override float modifyCurHitRatio(EntityBase target)
	{
		return 0f;
	}

	public void SetNextentity(EntityBase target)
	{
	}

	protected override void OnBulletTrack()
	{
	}
}
