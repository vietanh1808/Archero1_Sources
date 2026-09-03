using System.Collections.Generic;

public class NewPlay125WeaponSkillItemData
{
	public int WeaponConfigID { get; set; }

	public TetrisUnitConfig Config { get; set; }

	public float CurCumulativeTime { get; set; }

	public float AttackDistance => 0f;

	public NewPlay125WeaponSkillQuality Quality => NewPlay125WeaponSkillQuality.None;

	public List<NewPlay125WeaponSkillAttribute> Attribute => null;

	public NewPlay125WeaponType WeaponType => NewPlay125WeaponType.None;

	public NewPlay125WeaponEffectType EffectType => NewPlay125WeaponEffectType.None;

	public bool IsShowSkillIcon => false;

	public float CDTime => 0f;

	protected EntityHero SelfEntity => null;

	public float AttributeValue(NewPlay125WeaponSkillAttributeType type)
	{
		return 0f;
	}

	public virtual void Install(int weaponConfigID)
	{
	}

	public virtual void UnInstall()
	{
	}

	protected virtual void SetData(int weaponConfigID)
	{
	}

	public virtual void UpdateCDTime(float deltaTime)
	{
	}

	protected virtual void InitSkill()
	{
	}

	protected virtual void DeInitSkill()
	{
	}

	public virtual BulletBase SendBullet()
	{
		return null;
	}

	public long GetAttackValue()
	{
		return 0L;
	}

	public virtual float GetAttackSpeedValue()
	{
		return 0f;
	}

	protected virtual bool AllowSendBullet()
	{
		return false;
	}

	public EntityBase GetAttackTarget()
	{
		return null;
	}

	public virtual int GetBulletID()
	{
		return 0;
	}

	private float GetCDTime()
	{
		return 0f;
	}

	private NewPlay125WeaponSkillQuality GetQuality()
	{
		return NewPlay125WeaponSkillQuality.None;
	}

	private List<NewPlay125WeaponSkillAttribute> GetAttribute()
	{
		return null;
	}

	private NewPlay125WeaponEffectType GetEffectType()
	{
		return NewPlay125WeaponEffectType.None;
	}
}
