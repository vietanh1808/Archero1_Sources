using UnityEngine;

public class SkillAlone1961 : SkillAloneBase
{
	private float thunderSpearAtkPercent;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnMissWithHitStruct(HitStruct hs)
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void createThunderSpearWrapper(EntityBase enemy)
	{
	}

	private void createThunderSpearBullet(int bulletId, Vector3 bulletPos, float angleY)
	{
	}

	private void syncThunderSpearBullet(int bulletId, Vector3 bulletPos, float angleY)
	{
	}
}
