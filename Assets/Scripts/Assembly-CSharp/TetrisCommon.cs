using UnityEngine;

public class TetrisCommon
{
	public enum PackEditMode
	{
		WeaponEdit = 1,
		PackEdit = 2
	}

	public enum UnitType
	{
		None = 0,
		WeaponUnit = 1,
		BackPackUnit = 2,
		BackPackUnlocked = 3
	}

	public enum UnitStateType
	{
		InPack = 1,
		UnderPack = 2,
		OnDrag = 3
	}

	public enum WeaponUnitType
	{
		None = 0,
		Single = 1,
		Horizontal2 = 2,
		Vertical2 = 3,
		Horizontal3 = 4,
		Vertical3 = 5,
		TriTopLeft = 6,
		TriTopRight = 7,
		TriBottomLeft = 8,
		TriBottomRight = 9
	}

	public static readonly Color PackCanDeploy;

	public static readonly Color PackCannotDeploy;

	public static readonly Color PackDefault;

	public static readonly Color PackEmpty;

	public const float CellSizeX = 83f;

	public const float CellSizeY = 83f;

	public const float CellSpacingX = 7f;

	public const float CellSpacingY = 8f;

	public static readonly int PackOccupiedId;

	public static readonly int PackEmptyId;

	public static readonly int PackInvalidId;

	public const int CombineFxId = 5005001;

	public static readonly string AtlasName;

	public static readonly string PackUnlockDefaultSprite;

	public static readonly string PackUnlockCanDeploySprite;

	public static readonly string PackUnlockCannotDeploySprite;

	public static readonly string PackDefaultSprite;

	public static readonly string PackCanDeploySprite;

	public static readonly string PackCannotDeploySprite;

	public static readonly string PackEmptySprite;
}
