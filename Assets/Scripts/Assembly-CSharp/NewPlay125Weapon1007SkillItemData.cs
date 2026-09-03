using System.Collections.Generic;

public class NewPlay125Weapon1007SkillItemData : NewPlay125WeaponSkillItemData
{
	private EntityPartBodyBase elf;

	private long haveExcuteAttack;

	private long haveExcuteAttackSpeed;

	private Dictionary<int, float> allHitEnemy;

	public override void Install(int weaponConfigID)
	{
	}

	public override void UnInstall()
	{
	}

	private void InstallElf()
	{
	}

	private void UnInstallElf()
	{
	}

	public void UpdateAddHitEvent()
	{
	}

	public void UpdateRemoveHitEvent()
	{
	}

	public override BulletBase SendBullet()
	{
		return null;
	}

	public override int GetBulletID()
	{
		return 0;
	}

	protected override bool AllowSendBullet()
	{
		return false;
	}

	private void UpdateElfAttackValue()
	{
	}

	private void UpdateElfAttackSpeed()
	{
	}

	private void OnAttackValueUpdate(long curAttack)
	{
	}

	private void OnAttackSpeedUpdate(int curAttackSpeed)
	{
	}

	public EntityBase GetElf()
	{
		return null;
	}

	private void HitAction(EntityBase attackTarget, HitStruct hs, HittedData hd)
	{
	}
}
