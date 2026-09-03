using UnityEngine;

public class Bullet1010501 : BulletBase
{
	private float perangle;

	private float maxangle;

	private float currentrotateangle;

	private float move1time;

	private float waittime;

	private float currenttime;

	private EntityBase mTarget;

	private bool bFind;

	private Vector2 tarpos;

	private Vector2 bulletpos;

	private Vector3 bulletangle;

	private Vector3 endangle;

	public float CurrentRotateAngle => 0f;

	protected override void OnInit()
	{
	}

	private void Refresh()
	{
	}

	protected override void OnArrowEject(EntityBase nexttarget)
	{
	}

	private void find_entity()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnDeInit()
	{
	}

	private void resetTrails()
	{
	}

	protected virtual float GetWaitTime()
	{
		return 0f;
	}

	public void AddMaxAngle(float angle)
	{
	}
}
