using UnityEngine;

public class BulletTrackBase : BulletBase
{
	protected float perangle;

	protected float maxangle;

	private float currentrotateangle;

	private float move1time;

	protected float waittime;

	private float currenttime;

	protected EntityBase mTarget;

	private bool bFind;

	private Vector2 tarpos;

	private Vector2 bulletpos;

	private Vector3 bulletangle;

	private Vector3 endangle;

	protected override void OnInit()
	{
	}

	protected virtual void CustomTrackArgs()
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

	protected virtual void OnBeforeUpdateTrack()
	{
	}

	private void UpdateTrack()
	{
	}

	public void SetTrackTarget(EntityBase target)
	{
	}

	public new EntityBase GetTrackTarget()
	{
		return null;
	}

	protected override void OnDeInit()
	{
	}
}
