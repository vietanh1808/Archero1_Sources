using UnityEngine;

public class Weapon1197 : Weapon1024
{
	private GameObject[] redlines;

	private BulletRedLineCtrl[] ctrls;

	protected float time;

	private float[] mindises;

	private int cnt;

	protected virtual float alltime => 0f;

	protected override void OnInstall()
	{
	}

	protected virtual void OnCalRedLineDis(float distance, float angle, Collider c)
	{
	}

	protected override void OnUnInstall()
	{
	}

	protected virtual void OnUpdate(float delta)
	{
	}

	protected virtual void DeinitRedLine()
	{
	}

	protected override void OnAttack(params object[] args)
	{
	}
}
