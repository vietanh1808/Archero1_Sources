using System.Collections.Generic;

public class SkillAlone1769 : SkillAloneBase
{
	protected int MeleeWeaponId;

	protected float m_fTime;

	private Dictionary<int, int> m_dicMappingFlashWeapon;

	private List<int> m_listRightHands;

	private int flashWeaponId;

	private RealFlashSuperSkillVO superSkillVO;

	private int initialWeaponId;

	private float meleeHammerDistance;

	private float rangedHammerDistance;

	private EntityBase nearestEnemy;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected void OnUpdate(float delta)
	{
	}

	private void onSuperSkillStart()
	{
	}

	private void onSuperSkillEnd()
	{
	}

	protected void OnMove(bool value)
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

	private void setIsHammerInMidRanged(bool value)
	{
	}

	protected void ChangeToOldWeapon()
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

	private void deinitSuperSkill()
	{
	}

	private void parseHammerDisArgs(string[] args)
	{
	}
}
