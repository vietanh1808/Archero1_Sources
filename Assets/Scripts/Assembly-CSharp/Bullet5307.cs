using System.Collections.Generic;
using UnityEngine;

public class Bullet5307 : BulletBase
{
	private const int LASER_BULLET_ID = 5306;

	private List<BulletRedLineCtrl> redLineCtrlList;

	private Transform redlineParent;

	private float lineWidth;

	private int timerId;

	private float timeInterval;

	private Vector3 rotateSpeed;

	public override void OnBeforeInit()
	{
	}

	protected override void OnInit()
	{
	}

	private void onTimer()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void UpdateProcess()
	{
	}

	private void createRedLines()
	{
	}

	private void updateRedLines()
	{
	}

	private void clearRedLines()
	{
	}

	private void createLaserBullets()
	{
	}
}
