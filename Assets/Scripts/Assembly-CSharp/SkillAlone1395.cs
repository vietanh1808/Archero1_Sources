using System;
using UnityEngine;

public class SkillAlone1395 : SkillAloneBase
{
	[Serializable]
	private class SyncSkill1395BurstVO : CustomJsonActionVO
	{
		public Vector3 Pos;

		public float StartAngle;
	}

	private int POLAR_LIGHT_BULLET_ID;

	private int bulletCount;

	private SkillMissSuccess skill;

	private const string SyncSkill1395_Burst = "SyncSkill1395_Burst";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onMiss()
	{
	}

	private void CreateBurstsAt(Vector3 centerPos, float startAngle)
	{
	}

	private void SyncBurst(Vector3 pos, float startAngle)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
