using TableTool;

public class BulletColorModle : BulletBase
{
	public bool DoNoHarm;

	public int ColorIndex;

	public override string GetModelColorPath(Weapon_weapon weapon)
	{
		return null;
	}

	protected override void SendHitBullet(EntityBase target, EntityBase source, long beforehit, HitType hittype, HitBulletStruct bulletdata)
	{
	}
}
