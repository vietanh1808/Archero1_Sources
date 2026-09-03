using System.Collections.Generic;
using UnityEngine;

public class Weapon1025 : Weapon1024
{
	private int cnt;

	private float totalAngle;

	private List<BulletRedLineCtrl> mLines;

	public override void AttackJoyTouchDown()
	{
	}

	protected override void OnAttack(params object[] args)
	{
	}

	protected virtual Transform getRedLineContainer()
	{
		return null;
	}

	protected virtual float getLineWidth()
	{
		return 0f;
	}

	protected virtual float getLineTime()
	{
		return 0f;
	}

	protected virtual void OnBeforeSetParentNormal(GameObject redline)
	{
	}

	protected virtual void OnAfterSetParentNormal(GameObject redline)
	{
	}

	protected virtual void OnBeforeUpdateLine(BulletRedLineCtrl redline)
	{
	}

	private void showlines(bool show)
	{
	}

	private void ClearLines()
	{
	}

	protected override void OnUnInstall()
	{
	}
}
