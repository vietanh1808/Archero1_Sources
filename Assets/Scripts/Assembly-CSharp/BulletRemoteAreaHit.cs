public class BulletRemoteAreaHit : BulletBase
{
	public float HitRange;

	private bool isExploded;

	public bool IsExploded => false;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void ShowDeadEffect()
	{
	}

	public void SendHit_Bullet(EntityBase target, EntityBase source, long beforehit, HitType hittype, HitBulletStruct bulletdata)
	{
	}
}
