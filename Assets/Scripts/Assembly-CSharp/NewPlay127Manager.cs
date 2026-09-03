public class NewPlay127Manager
{
	private static NewPlay127Manager _instance;

	public const int NewPlay127PartDisappearDropHPRadius = 1;

	public const int NewPlay127PartCallID = 1801;

	public const int NewPlay127PartCreatePosRange = 4;

	public const int NewPlay127PartCreatePosCount = 1;

	public const int NewPlay127PartCallLastTime = 8000;

	public const int NewPlay127PartInheritPlayerAttackPercent = 200;

	public const int NewPlay127PartInheritPlayerAttackSpeedPercent = 150;

	public static NewPlay127Manager Instance => null;

	public int CurWeaponId { get; private set; }

	public float NewPlay127BulletScaleRadiusMax => 0f;

	public long NewPlay127PartDisappearDropHPCount(EntityBase entity)
	{
		return 0L;
	}

	public int NewPlay127PartBeHitCallCountMin(EntityBase entity)
	{
		return 0;
	}

	public int NewPlay127PartBeHitCallCountMax(EntityBase entity)
	{
		return 0;
	}

	public int NewPlay127PartHitCallCountMin(EntityBase entity)
	{
		return 0;
	}

	public int NewPlay127PartHitCallCountMax(EntityBase entity)
	{
		return 0;
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void SetCurWeaponId(int weaponId)
	{
	}

	public float GetCurRoomMonsterHPRatioAdd()
	{
		return 0f;
	}

	public float GetDropRatioAdd()
	{
		return 0f;
	}
}
