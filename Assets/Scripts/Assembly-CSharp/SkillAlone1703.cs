using UnityEngine;

public class SkillAlone1703 : SkillAloneBase
{
	private const int BULLET_ID = 1521;

	private bool isUsingBigSword;

	private const string UPDATE_NAME = "SkillAlone1703-Update";

	private float runningDis;

	private int reboundCount;

	private int bulletCount;

	private Vector3 oldPos;

	private float curDis;

	private string weaponHandIdStr;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onCreatePlayer()
	{
	}

	private void onUpdate(float delta)
	{
	}

	private GameObject getBulletModel(GameObject realBulleModel)
	{
		return null;
	}
}
