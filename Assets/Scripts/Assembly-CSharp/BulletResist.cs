public class BulletResist : EntityParentBase
{
	public int BulletResistType;

	private BulletBase _bullet;

	public int ResistCount { get; set; }

	public BulletBase Bullet => null;

	public void SetBullet(BulletBase bullet)
	{
	}

	public void Init(int _resistType)
	{
	}

	public void DeInit()
	{
	}

	private void OnEnable()
	{
	}
}
