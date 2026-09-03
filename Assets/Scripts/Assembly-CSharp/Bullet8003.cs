using UnityEngine;

public class Bullet8003 : BulletBase
{
	private Transform trailattparent;

	private Material mMaterial;

	private Color meshColor;

	private bool bHasColor;

	private Transform trailtran;

	private TrailRenderer trailrender;

	protected override void AwakeInit()
	{
	}

	protected override void OnInit()
	{
	}

	private bool OnHitWalls(Collider o)
	{
		return false;
	}

	protected override void OnHitHero(EntityBase entity)
	{
	}

	protected override void OnOverDistance()
	{
	}

	protected override void BoxEnable(bool enable)
	{
	}

	protected override void OnThroughTrailShow(bool show)
	{
	}

	protected override void OnUpdate()
	{
	}

	private void OnMeshAlpha(float value)
	{
	}

	protected override Transform GetTrailAttParent()
	{
		return null;
	}

	private void OnTrailShowEvents(bool show)
	{
	}

	protected override void KillBulletModel()
	{
	}
}
