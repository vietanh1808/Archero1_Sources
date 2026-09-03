using UnityEngine;

public class PetShieldHitCtrl : CommonHitCtrl
{
	public SphereCollider collider;

	public GameObject child;

	private float radius;

	private float lifeTime;

	private ConditionTime lifeCondition;

	public override void Init(EntityBase entity)
	{
	}

	public override void DeInit()
	{
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected override void UpdateProcess()
	{
	}

	private void checkLifeTime()
	{
	}

	public void Scale(float radius)
	{
	}

	public void SetLifeTime(float value)
	{
	}

	public void UpdateLifeTime(float deltaTime)
	{
	}
}
