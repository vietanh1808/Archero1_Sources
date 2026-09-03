using UnityEngine;

public class BulletFlyOffsetBase : BulletBase
{
	[Header("横向偏移距离")]
	public float offsetposx;

	[Header("横向偏移速度")]
	public float speed;

	private float symbol;

	private float offsetcurrent;

	protected override void OnInit()
	{
	}

	private void init_offset()
	{
	}

	public void SetOffset(float x, float speed)
	{
	}

	protected override void OnUpdate()
	{
	}
}
