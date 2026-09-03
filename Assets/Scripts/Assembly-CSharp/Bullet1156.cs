using Dxx.Util;
using UnityEngine;

public class Bullet1156 : BulletBase
{
	public GameObject alarm;

	private CapsuleCollider bulletCollider;

	private SequencePool sequence;

	protected override void OnInit()
	{
	}

	protected virtual float GetTime()
	{
		return 0f;
	}

	protected override void OnOverDistance()
	{
	}
}
