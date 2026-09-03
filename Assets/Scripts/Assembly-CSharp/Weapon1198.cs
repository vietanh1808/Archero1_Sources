using System.Collections.Generic;
using UnityEngine;

public class Weapon1198 : Weapon1024
{
	private GameObject redline;

	private BulletRedLineCtrl ctrl;

	protected float time;

	private float mindise;

	private List<GameObject> rebound_redlines;

	private List<BulletRedLineCtrl> rebound_ctrls;

	private List<float> rebound_mindises;

	private float time2;

	private float alltime => 0f;

	protected override void OnInstall()
	{
	}

	protected override void OnUnInstall()
	{
	}

	private void OnCalRedLineDis(float distance, float angle, Collider c)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void DeinitRedLine()
	{
	}

	protected override void OnAttack(params object[] args)
	{
	}
}
