public class Bullet1214 : BulletLavaBeamBase
{
	public const int BULLET_ID = 1214;

	protected override bool FireImme => false;

	protected override bool CustomizeBeamVO => false;

	protected override void OnSetBulletAttribute()
	{
	}
}
