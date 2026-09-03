using UnityEngine;

public class Weapon8001 : WeaponBase
{
	private int throughID;

	private bool change1002;

	protected override void OnInstall()
	{
	}

	protected override void OnUnInstall()
	{
	}

	private void OnAttackEndStartActions()
	{
	}

	private void OnAttackEndEndActions()
	{
	}

	private void OnAttackInterruptActions()
	{
	}

	public override Transform CreateBullet(Vector3 offsetpos, float rota, float customAngleY = -1f)
	{
		return null;
	}
}
