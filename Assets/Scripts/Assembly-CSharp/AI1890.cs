using System;
using UnityEngine;

public class AI1890 : AIBase
{
	public const string SKILL_IDLE = "SkillIdle";

	private Func<Vector3, Quaternion, BulletBase> CreateHitGroundBullet;

	private Func<Vector3, Quaternion, BulletBase> CreateStretchBullet;

	private const int SKILL_ID = 1000269;

	public const int hitGroundSkillId = 1000277;

	public const int stretchingSkillId = 1000278;

	private SkillBase hitGroundSkill;

	private SkillAlone1723 hitGroundSkillAlone;

	private SkillBase stretchingSkill;

	private SkillAlone1725 stretchingSkillAlone;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	public void AddAIActions()
	{
	}

	public void RemoveAIActions()
	{
	}

	private BulletBase OnCreateWuKongStretchBullet(Vector3 bulletPos, Quaternion rotation)
	{
		return null;
	}

	private BulletBase OnCreateWuKongHitGroundBullet(Vector3 bulletPos, Quaternion rotation)
	{
		return null;
	}
}
