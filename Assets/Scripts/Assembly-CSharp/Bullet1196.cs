using UnityEngine;

public class Bullet1196 : Bullet1024
{
	private float times;

	private float originalStartWidth;

	public Vector3 startPos { get; set; }

	public Vector3 endPos { get; set; }

	protected override void onAfterStartWidthInitialized()
	{
	}

	protected override void OnOverDistance()
	{
	}

	public override void CheckBulletLength()
	{
	}
}
