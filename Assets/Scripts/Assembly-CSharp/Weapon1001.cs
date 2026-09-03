using UnityEngine;

public class Weapon1001 : WeaponBase
{
	private Animation weaponAni;

	private const string PrevAction = "weapon1001_prev";

	private const string EndAction = "weapon1001_end";

	private const string ResetAction = "weapon1001_reset";

	protected override void OnInstall()
	{
	}

	protected override void OnUnInstall()
	{
	}

	public override void AttackJoyTouchDown()
	{
	}

	public override void AttackJoyTouchUp()
	{
	}

	private void OnAttackStartStartActions()
	{
	}

	private void OnAttackEndStartActions()
	{
	}

	private void OnAttackInterruptActions()
	{
	}
}
