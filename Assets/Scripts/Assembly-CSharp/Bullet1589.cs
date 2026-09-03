using UnityEngine;

public class Bullet1589 : BulletBase
{
	[SerializeField]
	protected int bulletId;

	protected float Radius;

	protected float hitRatio;

	protected override void OnDeInit()
	{
	}

	protected virtual void OnExplode()
	{
	}

	public void SetParams(int bulletId, float radius, float hitRatio)
	{
	}

	protected BulletBase CreateBullet(int bulletId, Vector3 bulletPos, float rota, float atkPercent, float radius)
	{
		return null;
	}
}
