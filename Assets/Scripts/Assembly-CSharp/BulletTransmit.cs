using System.Collections.Generic;
using TableTool;

public class BulletTransmit : GameDataBase
{
	public EntityAttributeBase.ValueBase GlobalDeltaCount;

	public EntityAttributeBase.ValueBase ArrowTrack;

	public EntityAttributeBase.ValueRange ReboundWall;

	public EntityAttributeBase.ValueRange ArrowEject;

	public EntityAttributeBase.ValueBase ArrowEjectAbsoluteMax;

	public EntityAttributeBase.ValueFloatBase MeleeHitPercent;

	public bool IsPersistent;

	private EntityBase m_Entity;

	private Weapon_weapon weapondata;

	public EntityType mEntityType;

	public EElementType trailType;

	public EElementType headType;

	private long attack;

	private float attackratio;

	public float CritRate;

	public float CritSuperRate;

	public float CustomCritValue;

	public long ExtraHit;

	public float BackRatio;

	private List<float> ExtraHitPercents;

	public float HeadShotRate;

	public float DragonAttackReducePercent;

	private HitStruct m_AttackStruct;

	public int mThroughEnemy;

	public float mThroughRatio;

	public int mHitCreate2;

	public float mHitCreate2Percent;

	public int mHitSputter;

	private float mThunderRatio;

	private List<int> mDebuffList;

	public int ReboundWallValue => 0;

	public int ArrowEjectValue => 0;

	public long OriginalAttack { get; private set; }

	public float OriginalAttackRatio { get; private set; }

	public float FinalHitRatio { get; private set; }

	public bool ThroughWall { get; set; }

	protected void InheritAttributes(EntityAttributeBase attribute)
	{
	}

	protected void ResetAttributes()
	{
	}

	public bool Excute(string attr)
	{
		return false;
	}

	public bool Excute(Goods_goods.GoodData data)
	{
		return false;
	}

	public bool Excute(string type, long value)
	{
		return false;
	}

	public BulletTransmit()
	{
	}

	public BulletTransmit(EntityBase entity, int bulletid, bool clear = false)
	{
	}

	public BulletTransmit(EntityBase entity, int bulletid, float attackRatio, float backRatio, int throughEnemy, float throughRatio, bool clear = false)
	{
	}

	public BulletTransmit Init(EntityBase entity, int bulletid, float attackRatio, float backRatio, int throughEnemy, float throughRatio, bool clear = false, float finalHitRatio = 0f)
	{
		return null;
	}

	public BulletTransmit Init(EntityBase entity, int bulletid, bool clear = false, float finalHitRatio = 0f)
	{
		return null;
	}

	private long calculateAttack()
	{
		return 0L;
	}

	private void tryLearnEntityElements(int bulletId)
	{
	}

	public void SetDragonAttackReducePercent(float value)
	{
	}

	public void AddBackRatio(float ratio)
	{
	}

	public void SetBackRatio(float ratio)
	{
	}

	public void SetHeadShotRate(float ratio)
	{
	}

	public void AddExtraHitRatio(float ratio)
	{
	}

	public void SetAttack(long attack, float ratio = 1f)
	{
	}

	public long GetAttack()
	{
		return 0L;
	}

	public HitStruct GetAttackStruct()
	{
		return null;
	}

	public HitStruct GetAttackStruct(BulletBase bullet)
	{
		return null;
	}

	public void ArrowEjectAction(float value)
	{
	}

	public bool GetThroughEnemy()
	{
		return false;
	}

	public bool GetHitCreate2()
	{
		return false;
	}

	public void ModifyThroughEnemy(int count)
	{
	}

	public bool GetHitSputter()
	{
		return false;
	}

	public void SetDebuffList(List<int> list)
	{
	}

	public void PrintDebuffs(string tag)
	{
	}

	public void AddDebuffs(params int[] buffs)
	{
	}

	public void RemoveDebuff(int debuffId)
	{
	}

	public void AddDebuffsToTarget(EntityBase target)
	{
	}

	public void MultiplyAttackRatio(float value)
	{
	}

	public void Add2AttackRatio(float value)
	{
	}

	public void SetAttackRatio(float value)
	{
	}

	public float GetAttackRatio()
	{
		return 0f;
	}

	private void Clear()
	{
	}

	public override void Reset()
	{
	}
}
