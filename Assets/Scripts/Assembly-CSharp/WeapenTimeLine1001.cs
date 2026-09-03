using UnityEngine;

public class WeapenTimeLine1001 : WeaponTimeLineBase
{
	private Animation weaponAni;

	private const string PrevAction = "weapon1001_prev";

	private const string EndAction = "weapon1001_end";

	private const string ResetAction = "weapon1001_reset";

	public WeapenTimeLine1001(EntityTimeLineBase pW)
		: base(null)
	{
	}

	public override void Init(int pWeapenId)
	{
	}

	public override void UnInstall()
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
