using UnityEngine;

public class SkillAlone2340WaterBallCtrl : MonoBehaviour
{
	private EntityBase source;

	private EntityBase target;

	private Vector3 startPos;

	private Vector3 endPos;

	private float hitRatio;

	private float healPercent;

	private bool isPvp;

	private float elapsed;

	private float duration;

	private bool isFlying;

	private Vector3 controlPoint;

	private Vector3 launchEndPos;

	private Vector3 launchControlPoint;

	public void Launch(EntityBase source, EntityBase target, Vector3 startPos, Vector3 endPos, float curveAngle, float height, float speed, float hitRatio, float healPercent, bool isPvp)
	{
	}

	private void Update()
	{
	}

	private void TrackTarget()
	{
	}

	private Vector3 QuadraticBezier(Vector3 p0, Vector3 p1, Vector3 p2, float t)
	{
		return default;
	}

	private void OnArrived()
	{
	}

	private void Recycle()
	{
	}

	private float EstimateBezierLength(Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return 0f;
	}
}
