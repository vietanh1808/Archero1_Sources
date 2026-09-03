public class SkillAlone1827 : SkillAloneBase
{
	private int MeleeWeaponId;

	private int GunWeaponId;

	private float meleeLanceDistance;

	private float darkEnergyLimit;

	private float darkEnergyAddByHit;

	private float darkEnergyDecByHit;

	private float darkEnergyDecPerSecond;

	private const string LaserRun = "LaserRun";

	private LanceShieldSuperSkill superSkillVO;

	private float m_fTime;

	private int initialWeaponId;

	private bool isCannon;

	private float cumulativeTime;

	private EntityBase nearestEnemy;

	private EntityHero _hero;

	private int _RealMeleeWeaponId;

	private LocalSave.LancePassiveV0 lancePassiveV0 => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected void OnUpdate(float delta)
	{
	}

	private void DecDarkEnergy(float delta)
	{
	}

	private void onSuperSkillStart()
	{
	}

	private void onSuperSkillEnd()
	{
	}

	private void OnMove(bool value)
	{
	}

	private void OnLanceChangeState(bool isInCannon)
	{
	}

	protected void ResetOldWeapon()
	{
	}

	protected void ChangeMeleeWeapon()
	{
	}

	protected void CheckWeapon()
	{
	}

	protected void ChangeToInitialWeapon()
	{
	}

	protected void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected void OnAttackPrePre()
	{
	}

	protected void OnAttackStart()
	{
	}

	protected void OnAttack()
	{
	}

	private void LanceAttack()
	{
	}

	private void CannonAttack()
	{
	}

	protected void OnAttackEndEndEvent()
	{
	}

	private bool isSuperSkillWorking()
	{
		return false;
	}

	private bool isMeleeAttack()
	{
		return false;
	}

	private bool isRangedAttack()
	{
		return false;
	}

	private void initSuperSkill()
	{
	}

	private void InitAnimations()
	{
	}

	private void UpdateState()
	{
	}

	private void deinitSuperSkill()
	{
	}
}
