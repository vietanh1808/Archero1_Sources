using UnityEngine;

public class SkillAlone1952 : SkillAlone1949
{
	private float revengeThunderRadius;

	private float callThunderSpearRate;

	private float thunderSpearAtkPercent;

	private int thunderSpearDebuff;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	protected override void parseArgs()
	{
	}

	private void createThunderSpearBullet(int bulletId, Vector3 bulletPos, float angleY)
	{
	}

	private void syncThunderSpearBullet(int bulletId, Vector3 bulletPos, float angleY)
	{
	}

	private void onAttack()
	{
	}
}
