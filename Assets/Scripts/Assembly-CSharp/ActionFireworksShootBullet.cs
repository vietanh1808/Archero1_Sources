using UnityEngine;

internal class ActionFireworksShootBullet
{
	private const int TARGET_WEIGHT = 2;

	private const int AVERAGE_WEIGHT = 1;

	private const string UPDATE_NAME = "ActionFireworksShootBullet";

	private const float shootInterval = 0.4f;

	private const int BULLET_ID = 1219;

	public EntityBase m_Entity;

	public EntityBase HostEntity;

	private float curShootTime;

	private AIFireworksDragon m_AIFireworksDragon;

	private GameObject fireEffect;

	public ActionFireworksShootBullet(EntityBase entity)
	{
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void onUpdate(float delta)
	{
	}

	private void ShootBullet(EntityBase target)
	{
	}

	private EntityBase GetTarget()
	{
		return null;
	}
}
