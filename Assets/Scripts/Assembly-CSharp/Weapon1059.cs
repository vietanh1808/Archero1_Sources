using DG.Tweening;

public class Weapon1059 : WeaponBase
{
	private const float ReSendBulletInterval = 0.4f;

	private Tween delayCall;

	private int ReSendBulletProb => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUnInstall()
	{
	}

	protected override void OnAttack(params object[] args)
	{
	}

	private void SendAllBullet()
	{
	}
}
