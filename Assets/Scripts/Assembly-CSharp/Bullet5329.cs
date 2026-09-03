using UnityEngine;

public class Bullet5329 : BulletTrackBase
{
	[Header("分裂子弹数量-要求为偶数")]
	public int DivideCount;

	[Header("分裂子弹与主子弹分裂夹角")]
	public float DivideAngle;

	[Header("子弹飞行多远分裂")]
	public float DivideDistance;

	private bool isDivided;

	public override void OnBeforeInit()
	{
	}

	protected override void CustomTrackArgs()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	public void CheckIfCreateDividedBullet()
	{
	}

	private void createDividedBullet()
	{
	}
}
