using System;
using UnityEngine;

public class SkillAlone1731 : SkillAloneBase
{
	private const string UPDATE_NAME = "SkillAlone1731-UPDATE";

	private int hitGroundBulletId;

	private int strecthBulletId;

	private bool IsMoving;

	private Func<Vector3, Quaternion, BulletBase> CreateHitGroundBullet;

	private Func<Vector3, Quaternion, BulletBase> CreateStretchBullet;

	private int skillId;

	private float hitGroundRatio;

	private float StrentchRatio;

	private bool canChangeStatus;

	public int AIWorkingCount;

	public int AIWorkingCount2;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void resetAI()
	{
	}

	private void onUpdate(float delta)
	{
	}

	private void onMove(bool isMoving)
	{
	}

	private void OnBeforeRunWuKongAI()
	{
	}

	private void OnAfterRunWuKongAI()
	{
	}

	private BulletBase OnCreateWuKongStretchBullet(Vector3 bulletPos, Quaternion rotation)
	{
		return null;
	}

	private BulletBase OnCreateWuKongHitGroundBullet(Vector3 bulletPos, Quaternion rotation)
	{
		return null;
	}
}
