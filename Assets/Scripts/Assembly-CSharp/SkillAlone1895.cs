using UnityEngine;

public class SkillAlone1895 : SkillAlonePetBase
{
	private const int BULLET_ID = 1545;

	private float deltaAtkPercent;

	private float atkPercent;

	private int bulletDebuffId;

	private int maxReboundCount;

	private float criteRatePercent;

	private float baseCustomCritValuePercent;

	private float critValuePercent;

	private bool canCrit;

	private ActionBasic atkAI;

	private BulletBase bullet;

	private EntityBase atkTarget;

	private int hitWallCount;

	private float atkAnimTime;

	private GameObject goEffect;

	private EntityBase PlayerEntity => null;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHit(EntityBase enemy, HitStruct hs, HittedData hd)
	{
	}

	protected virtual void ParseArgs()
	{
	}

	private void initEffects()
	{
	}

	private void deinitEffects()
	{
	}

	private void initAtkAI()
	{
	}

	private void deinitAtkAI()
	{
	}

	private void initBullet()
	{
	}

	private void deinitBullet()
	{
	}

	private AIBase.ActionSequence getAIActions()
	{
		return null;
	}

	private AIBase.ActionSequence getAtkSeq()
	{
		return null;
	}

	private EntityBase getTarget()
	{
		return null;
	}
}
