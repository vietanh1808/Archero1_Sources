using System;
using UnityEngine;

public class Bullet5195 : BulletBase
{
	private Action<BulletBase> DeInitAction;

	private Vector3 followDir;

	public void Init(EntityBase entity, int BulletID, Vector3 followDir, Action<BulletBase> DeInitAction = null)
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void UpdateProcess()
	{
	}
}
