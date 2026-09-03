using DG.Tweening;
using UnityEngine;

public class SkillAloneWuKongTwirl : SkillAloneBase
{
	protected float atkPercent;

	protected float oneTwirlTime;

	protected int TwirlCount;

	protected float twirlFactor;

	protected float stickThicknessScale;

	protected float stickLengthScale;

	protected Sequence scaleSeq;

	public Vector3 InitEndScale;

	public Vector3 TwirlEndScale;

	public float oneTwirlAnimSpeed;

	private float deltaTwirlAnimSpeed;

	private float originalTwirlAnimSpeed;

	private float originalTwirlAnimTime;

	private float originalTwirlAnimFrames;

	public const string TWIRL_PRE_ANIM = "SkillWhirlwindPrev";

	public const string TWIRL_ROTATING_ANIM = "SkillWhirlwindRotating";

	public const string TWIRL_END_ANIM = "SkillWhirlwindEnd";

	private float TwirlPreAnimTime;

	private float TwirlRotatingAnimTime;

	private float TwirlEndAnimTime;

	private float SkillIdleTime;

	private WuKongStickMid stick;

	public float stickLength;

	public float stickEndLength;

	private float stickLossyScaleZ;

	public BulletBase bullet;

	protected Transform stickNodeTrans;

	private ActionBasic ai;

	protected virtual int BULLET_ID => 0;

	public float FinalTwirlSpeed => 0f;

	private float lengthOverScale => 0f;

	protected override void OnInstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected void killBullet()
	{
	}

	protected virtual void OnBeforeTwirlSkill()
	{
	}

	protected virtual void OnAfterTwirlSkill()
	{
	}

	protected void parseArgs1(string[] args)
	{
	}

	protected void parseArgs2(string[] args)
	{
	}

	private BulletBase createTwirlStickBullet(int bulletId, float endLocalScaleZ)
	{
		return null;
	}

	public void SetBoxColliderByStickLength(float _stickLength, float deltaSpeedPercent)
	{
	}

	protected void runTwirlSkill()
	{
	}

	private ActionBasic.ActionBase GetActionTwirl()
	{
		return null;
	}

	private void initTwirlAnims()
	{
	}

	public float getNewStickLength(float endLocalScaleZ)
	{
		return 0f;
	}

	public void RefreshStickInfo()
	{
	}

	protected void forceResetScale()
	{
	}

	public void DoScaleAnim(Vector3 endScale, float time)
	{
	}

	public void KillScaleAnim()
	{
	}

	protected void doResetAnim(float time)
	{
	}

	protected void parseArgsInitEndScale(string[] args)
	{
	}
}
