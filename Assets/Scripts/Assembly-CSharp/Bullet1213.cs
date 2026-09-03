using UnityEngine;

public class Bullet1213 : BulletLavaBeamBase
{
	public const int BULLET_ID = 1213;

	private float beamScale;

	private EntityDragonBase dragon;

	private ActionFirePath firePath;

	private bool isFireStarted;

	protected override float startwidth => 0f;

	protected override bool Follow => false;

	protected override bool FireImme => false;

	protected override bool UseFixedAppearTime => false;

	protected override float FixedAppearTime => 0f;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnAfterStartFire()
	{
	}

	protected override void BeamDir2BulletDir()
	{
	}

	public override Vector3 GetBeamDir()
	{
		return default;
	}

	public void SetDragon(EntityDragonBase _dragon)
	{
	}

	protected override Vector3 getHalfExtents(Vector3 size)
	{
		return default;
	}
}
