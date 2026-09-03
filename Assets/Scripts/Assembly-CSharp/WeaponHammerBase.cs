using UnityEngine;

public class WeaponHammerBase : WeaponBase
{
	protected GameObject goWeaponEffect;

	protected Transform weaponTrans;

	protected virtual string EffectName => null;

	protected virtual int ConfigId => 0;

	protected virtual int ConfigIndex => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUnInstall()
	{
	}

	protected void updateAtkModify(float factor)
	{
	}

	private string GetEffectName()
	{
		return null;
	}

	public static string GetHammerEffectName(string idStr)
	{
		return null;
	}

	protected void addEffect()
	{
	}

	protected void clearEffect()
	{
	}
}
