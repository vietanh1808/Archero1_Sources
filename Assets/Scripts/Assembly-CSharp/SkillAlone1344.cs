using System.Collections.Generic;

public class SkillAlone1344 : SkillAlone1215
{
	private Dictionary<int, int> m_dicMappingWeapons;

	private Dictionary<int, int> m_dicMappingWeapons2;

	private Dictionary<int, int> m_dicMappingFarDueSwords;

	private Dictionary<int, int> m_dicMappingFarResetDueSwords;

	private Dictionary<int, int> m_dicMappingNearDueSwords;

	private Dictionary<int, int> m_dicMappingNearToFar;

	private int[] DuelNearSwords;

	private int m_nDueSwordId;

	private int m_nSwordId;

	private bool m_bChangeBigSwordFlag;

	protected override int WeaponId => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnChangeWeapon(bool value)
	{
	}

	protected override void OnAttackEndEndEvent()
	{
	}

	protected virtual bool ContainsMappingFarDueSword(int nCurWeaponId)
	{
		return false;
	}

	protected virtual int GetMappingFarDueSword(int nCurWeaponId)
	{
		return 0;
	}

	protected virtual void OnFarDurSwordAttack(int nCurWeaponId)
	{
	}

	protected virtual void RealChangeWeapon(int nNewWeaponId)
	{
	}

	protected override void OnMove(bool value)
	{
	}

	private void OnAngerOver()
	{
	}

	private float OnCalValue(HitStruct ht, EntityBase entity)
	{
		return 0f;
	}

	protected virtual void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	protected override void ChangeToOldWeapon()
	{
	}
}
