using System.Collections.Generic;
using UnityEngine;

public class Weapon1147 : WeaponBase
{
	private int AttackEffect;

	private Transform effectparent;

	private List<GameObject> m_listEffects;

	private int cnt;

	private List<BulletRedLineCtrl> mLines;

	protected override void OnInstall()
	{
	}

	public override void AttackJoyTouchDown()
	{
	}

	protected override void OnAttack(params object[] args)
	{
	}

	protected override void OnUnInstall()
	{
	}

	private void RemoveCreateEffect()
	{
	}

	private void showlines(bool show)
	{
	}

	private void ClearLines()
	{
	}
}
