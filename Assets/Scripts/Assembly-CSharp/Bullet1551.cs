using UnityEngine;

public class Bullet1551 : BulletBeamBase
{
	private float beamScale;

	protected override bool FireImme => false;

	protected override float startwidth => 0f;

	protected override bool UseFixedAppearTime => false;

	protected override float FixedAppearTime => 0f;

	public override Vector3 GetBeamDir()
	{
		return default;
	}

	protected override void initLayerMask()
	{
	}
}
