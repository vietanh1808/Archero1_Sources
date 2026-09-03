using UnityEngine;

public class SkillAlone1805 : SkillAloneBase
{
	private const string UPDATE_NAME = "SkillAlone1805-UPDATE";

	private float timeInterval;

	private int count;

	private float atkRatio;

	private int thunderBuffId;

	private float curTime;

	private int CurBulletId => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void onUpdate(float obj)
	{
	}

	private void createBullet(Vector3 bulletPos, Vector3 bulletDir)
	{
	}

	private void syncBullet(Vector3 bulletPos, Vector3 bulletDir)
	{
	}
}
