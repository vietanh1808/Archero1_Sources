using UnityEngine;

public class SkillAlone1723 : SkillAloneWuKongAI
{
	protected float shortDis;

	protected float hitStickThickness;

	public const string HIT_GROUND_PRE_ANIM = "SkillAttack01Prev";

	public const string HIT_GROUND_END_ANIM = "SkillAttack01End";

	private float hitGroundPreAnimTime;

	private float hitGroundEndAnimTime;

	public Vector3 hitGroundEndScale;

	private const int HIT_GROUND_BULLET_ID = 8905;

	public float maxSpeedPercent;

	protected override float StickThickness => 0f;

	private float lengthOverScale => 0f;

	protected override void OnInstall(params object[] args)
	{
	}

	protected void parseDisArgs(string[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void addClips()
	{
	}

	private void RunWuKongHitGroundAI()
	{
	}

	public ActionBasic.ActionBase GetActionMeleeWrapper()
	{
		return null;
	}

	public BulletBase createScaledStickBulletWorld(float endLocalScaleZ)
	{
		return null;
	}

	protected float getNewStickLength(float endLocalScaleZ)
	{
		return 0f;
	}

	private void initHitGroundAnims()
	{
	}
}
