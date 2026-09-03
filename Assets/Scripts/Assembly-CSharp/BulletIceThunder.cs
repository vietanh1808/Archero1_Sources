using UnityEngine;

public class BulletIceThunder : BulletBase
{
	public CapsuleCollider BulletResistCollider;

	private bool isResistEnabled;

	protected CapsuleCollider capsuleCollider;

	private GameObject testSphere;

	protected override void OnInit()
	{
	}

	protected override void OnSetBulletAttribute()
	{
	}

	protected override void OnDeInit()
	{
	}

	public void SetIceThunderRadius(float radius)
	{
	}

	private void initBulletResist()
	{
	}

	protected override void CheckCapsuleHits()
	{
	}
}
