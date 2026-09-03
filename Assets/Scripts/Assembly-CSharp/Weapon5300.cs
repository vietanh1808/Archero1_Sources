using Dxx.Util;
using UnityEngine;

public class Weapon5300 : Weapon1025
{
	protected SequencePool mPool;

	private float attackStartTime;

	private const float LINE_WIDTH = 1f;

	private const float DELTA_PERCENT = 0.5f;

	protected override void OnInstall()
	{
	}

	protected override Transform getRedLineContainer()
	{
		return null;
	}

	protected override float getLineWidth()
	{
		return 0f;
	}

	protected override float getLineTime()
	{
		return 0f;
	}

	protected override void OnBeforeSetParentNormal(GameObject redline)
	{
	}

	protected override void OnAfterSetParentNormal(GameObject redline)
	{
	}

	protected override void OnBeforeUpdateLine(BulletRedLineCtrl redline)
	{
	}

	protected override void OnUnInstall()
	{
	}

	private void onAttackStart()
	{
	}

	private void onAttackEnd()
	{
	}
}
