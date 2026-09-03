using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class SkillAlone1820 : SkillAloneBase
{
	private const string UPDATE_NAME = "SkillAlone1820";

	private const int RANGE_IN_GRIDS = 5;

	private const int SHARK_PART_ID = 1851;

	public const string SKILL_5_ANIM_IDLE2HALF = "Idle To Half Head";

	public const string SKILL_5_ANIM_HALF_HEAD = "Half Head";

	public const string SKILL_5_ANIM_HALF2IDLE = "Half Head To Idle";

	private const string SKILL_4_ANIM = "Summon";

	private const string REST_ANIM = "Walk Forward";

	private float Play114AccelerateSpeedPercent;

	private float Play114MaxSpeedPercent;

	private int sharkCallCount;

	private float sharkPartAliveTime;

	private float sharkParentHitPercent;

	private float bodyHitPercent;

	private int bodyDebuff;

	protected List<Goods_goods.GoodData> mAttrs;

	private float animTime_idle2half;

	private const float HALF_HEAD_DURATION = 300f;

	private ActionBasic sharkAI;

	private Transform rigWeapon;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void parseArgs0(string[] args)
	{
	}

	private void parseArgs1(string[] args)
	{
	}

	private void parseArgs2(string[] args)
	{
	}

	private void onBodyHit(EntityBase enemy)
	{
	}

	private void onPlay(AnimationCtrlBase.AniClass curState)
	{
	}

	private void onUpdate(float deltaTime)
	{
	}

	private void onMove(bool isMoving)
	{
	}

	private void onActiveSkill()
	{
	}

	private void callSharkSolider(Vector3 pos)
	{
	}

	public virtual AIBase.ActionSequence skill_5()
	{
		return null;
	}

	private float getAnimTime(string animName)
	{
		return 0f;
	}

	private void playAnim(string animName)
	{
	}

	private void addExtraAnimsWrapper()
	{
	}

	private void loadAnimationClips()
	{
	}

	private void addExtraAnims()
	{
	}
}
