public class SkillAlone1861 : SkillAlonePetBase
{
	private const int invincibleBuff = 5567;

	private float shieldLifeTime;

	private float deltaAtkValuePercent;

	private float recoverRate;

	private float shieldRadius;

	private int reduceSpeedBuffId;

	private int recoverHPBuffId;

	private float recoverHPPercent;

	protected bool addShieldBuff;

	private ActionBasic animAction;

	protected PetShieldHitCtrl shieldHitCtrl;

	protected EntityHero playerEntity;

	private int shieldBuffId;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	private void initCallbacks()
	{
	}

	private void deinitCallbacks()
	{
	}

	private void onEnterCommonCollider(CommonHitCtrl ctrl)
	{
	}

	private void onExitCommonCollider(CommonHitCtrl ctrl)
	{
	}

	private void tryRemoveShieldBuff()
	{
	}

	protected virtual void onShieldDestroyed(CommonHitCtrl hitCtrl)
	{
	}

	private void playAnim()
	{
	}

	private void addShield()
	{
	}
}
