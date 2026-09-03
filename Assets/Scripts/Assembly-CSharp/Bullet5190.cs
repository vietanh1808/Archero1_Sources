using UnityEngine;

public class Bullet5190 : Bullet5056
{
	protected GameObject Fire;

	private Vector3? mLastPos;

	private float left;

	private float right;

	private float top;

	private float bottom;

	public float despawnTime;

	private bool over;

	protected ParticleSystem mParticle;

	protected override void OnInit()
	{
	}

	private void CreateOne(Vector3 pos)
	{
	}

	protected virtual void CreateFire(Vector3 pos)
	{
	}

	protected virtual GameObject OnCreateOne()
	{
		return null;
	}

	protected virtual GameObject OnCreateFire()
	{
		return null;
	}

	protected override void UpdateProcess()
	{
	}

	protected override void OnDeInit()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
