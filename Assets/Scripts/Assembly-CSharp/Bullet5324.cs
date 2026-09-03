using DG.Tweening;
using UnityEngine;

internal class Bullet5324 : BulletBase
{
	private const float DELTA_DEGREES_PER_SECOND = 360f;

	private const float MAX_ARC_PERCENT_SECOND = 18f;

	private float radius;

	private Vector3 radiusDir;

	private float accelerateArcPerSecond;

	private float accelerateRadiusPerSecond;

	private float maxRadiusPerSecond;

	private float scaleDuration;

	private float deltaDegreesPerSecond;

	private float deltaRadiusPerSecond;

	private float ArcLengthPerSecond;

	private bool IsArcLengthFixed;

	private Tweener tweener;

	private Tweener particleTweener;

	private float deltaRadius;

	protected override int RotateSpeedSign => 0;

	protected override void OnInit()
	{
	}

	public void StartAnim()
	{
	}

	protected override int GetLayer()
	{
		return 0;
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	public void SetExtraArgs(float _radius, Vector3 _radiusDir)
	{
	}
}
