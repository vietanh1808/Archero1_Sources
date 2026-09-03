using System;
using UnityEngine;

public class SkillAlone1730 : SkillAloneBase
{
	private Func<Vector3, Quaternion, BulletBase> CreateHitGroundBullet;

	private Func<Vector3, Quaternion, BulletBase> CreateStretchBullet;

	private int hitGroundSkillId;

	private int stretchingSkillId;

	private int hitGroundBulletId;

	private int strecthBulletId;

	private SkillBase hitGroundSkill;

	private SkillAlone1723 hitGroundSkillAlone;

	private SkillBase stretchingSkill;

	private SkillAlone1725 stretchingSkillAlone;

	protected ActionBasic ai;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ClearRunWukongAI()
	{
	}

	private void RunWuKongAI()
	{
	}

	public void AddAIActions()
	{
	}

	public void RemoveAIActions()
	{
	}
}
