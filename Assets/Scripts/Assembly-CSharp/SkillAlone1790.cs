using UnityEngine;

public class SkillAlone1790 : SkillAloneMagicBookActiveSkillBase
{
	private const string Time = "Time";

	private const string UPDATE_NAME = "SkillAlone1790-UPDATE";

	private const float SPHERE_FLASH_HEIGHT = 1f;

	private const float SPHERE_FLASH_SCALE = 2f;

	public const int AOE_BULLET_ID = 9040;

	private const int AOE_BUFF_ID = 1582;

	private int initFlashChainEjectCount;

	protected float sphereFlashTime;

	private int sphereBuffId;

	private float AOEAtkInterval;

	private float AOEDistance;

	private int AOECount;

	private float AOEHitPercent;

	private float flashChainDis;

	private float flashChainInitRatio;

	private float flashChainDecreaseRatio;

	private float flashChainMinRatio;

	private float bodyScale2TimeRatio;

	private float bodyScale2TimePercentRatio;

	private float bodyScale2HitPercentRatio;

	private float bodyScale2HitRadiusRatio;

	private bool IsMoving;

	private float realSphereFlashTime;

	private float curSphereFlashTime;

	private GameObject goSphereFlash;

	private float curAOETime;

	private ActionMovingDis movingDis;

	private SkillBodyScale2OtherNew skill2TimePercent;

	private SkillBodyScale2OtherNew skill2HitPercent;

	private SkillBodyScale2OtherNew skill2HitRadius;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void ExcuteArgs()
	{
	}

	protected string[] parseQualityArgs(string qualityName)
	{
		return null;
	}

	private void parseEnergyArgs(string[] args)
	{
	}

	private void initSkillBodyScales()
	{
	}

	private void deinitSkillBodyScales()
	{
	}

	private new void OnChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void onReachMaxDis()
	{
	}

	private void onUpdate(float delta)
	{
	}

	protected override bool OnEnergyFull()
	{
		return false;
	}

	private void OnDoubleClick()
	{
	}

	protected virtual bool CanStartFreeSphereFlash()
	{
		return false;
	}

	protected void startSphereFlashWrapper(float _sphereFlashTime)
	{
	}

	protected void cancelSphereFlashWrapper()
	{
	}

	private void OnMove(bool isMoving)
	{
	}

	private void startSphereFlash()
	{
	}

	private void cancelSphereFlash()
	{
	}

	private GameObject createSphereFlash()
	{
		return null;
	}

	private void SetHeroVisible(bool visible, float alpha)
	{
	}

	private void updateMoveAOE()
	{
	}
}
