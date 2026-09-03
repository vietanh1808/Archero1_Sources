using System.Collections.Generic;
using DG.Tweening;

public class Weapon5148 : WeaponBase
{
	private const float SendBulletRoundInterval = 0.5f;

	private List<Tween> delayCall;

	protected virtual int SendBulletRound => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUnInstall()
	{
	}

	protected override void OnAttack(params object[] args)
	{
	}

	private void SendPerRoundBullet()
	{
	}
}
