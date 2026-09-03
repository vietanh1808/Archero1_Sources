using System.Collections.Generic;
using TableTool;
using XLua;

public class CampTileBaseData<T> : RecycleData<T> where T : CampTileBaseConfigData
{
	private static DelegateBridge __Hotfix0_get_IsOpenTime;

	private static DelegateBridge __Hotfix0_get_IsCloseTime;

	private static DelegateBridge __Hotfix0_get_UnOpenLeftTime;

	private static DelegateBridge __Hotfix0_get_IsShowCountDown;

	private static DelegateBridge __Hotfix0_get_IsSelfOccupied;

	private static DelegateBridge __Hotfix0_get_IsPass;

	private static DelegateBridge __Hotfix0_get_Position;

	private static DelegateBridge __Hotfix0_get_TileID;

	private static DelegateBridge __Hotfix0_get_ImageID;

	private static DelegateBridge __Hotfix0_get_Level;

	private static DelegateBridge __Hotfix0_get_IsTileOccupied;

	private static DelegateBridge __Hotfix0_get_IsBattleTile;

	private static DelegateBridge __Hotfix0_get_IsSelfUnLock;

	private static DelegateBridge __Hotfix0_get_IsTileInSelfCamp;

	private static DelegateBridge __Hotfix0_get_TileOccupyCamp;

	private static DelegateBridge __Hotfix0_get_OpenTime;

	private static DelegateBridge __Hotfix0_get_TilePosCamp;

	private static DelegateBridge __Hotfix0_get_AttackCount;

	private static DelegateBridge __Hotfix0_get_TileStatus;

	private static DelegateBridge __Hotfix0_get_TileType;

	private static DelegateBridge __Hotfix0_get_TileOperationRestriction;

	private static DelegateBridge __Hotfix0_get_TileOperationType;

	private static DelegateBridge __Hotfix0_get_TileOccupyRestriction;

	private static DelegateBridge __Hotfix0_get_TileOccupyType;

	private static DelegateBridge __Hotfix0_get_OccupyValue;

	private static DelegateBridge __Hotfix0_get_NeedOccupyValue;

	private static DelegateBridge __Hotfix0_get_TileOccupyAttackType;

	private static DelegateBridge __Hotfix0_get_OccupyRewards;

	private static DelegateBridge __Hotfix0_get_AttackRewards;

	private static DelegateBridge __Hotfix0_get_Name;

	private static DelegateBridge __Hotfix0_get_isShowName;

	private static DelegateBridge __Hotfix0_get_showLevel;

	private static DelegateBridge __Hotfix0_GetOccupyRewards;

	private static DelegateBridge __Hotfix0_GetAttackRewards;

	private static DelegateBridge __Hotfix0_GetTileStatus;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_UpdateData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public bool IsOpenTime => false;

	public bool IsCloseTime => false;

	public long UnOpenLeftTime => 0L;

	public bool IsShowCountDown => false;

	public bool IsSelfOccupied => false;

	public bool IsPass => false;

	public (int, int) Position => default;

	public int TileID => 0;

	public int ImageID => 0;

	public int Level => 0;

	public bool IsTileOccupied => false;

	public bool IsBattleTile => false;

	public bool IsSelfUnLock => false;

	public bool IsTileInSelfCamp => false;

	public CampID TileOccupyCamp => CampID.Unknown;

	public int OpenTime => 0;

	public HashSet<CampID> TilePosCamp => null;

	public int AttackCount => 0;

	public CampTileStatus TileStatus => CampTileStatus.None;

	public CampTileType TileType => CampTileType.None;

	public CampTileOperationRestriction TileOperationRestriction => CampTileOperationRestriction.None;

	public CampTileOperationType TileOperationType => CampTileOperationType.None;

	public CampTileOccupyRestriction TileOccupyRestriction => CampTileOccupyRestriction.None;

	public CampTileOccupyType TileOccupyType => CampTileOccupyType.None;

	public int[] OccupyValue => null;

	public int NeedOccupyValue => 0;

	public CampTileOccupyAttackType TileOccupyAttackType => CampTileOccupyAttackType.None;

	public List<Drop_DropModel.DropData> OccupyRewards => null;

	public List<Drop_DropModel.DropData> AttackRewards => null;

	public string Name => null;

	public bool isShowName => false;

	public int showLevel => 0;

	private List<Drop_DropModel.DropData> GetOccupyRewards()
	{
		return null;
	}

	private List<Drop_DropModel.DropData> GetAttackRewards()
	{
		return null;
	}

	private CampTileStatus GetTileStatus()
	{
		return CampTileStatus.None;
	}

	public static T1 Create<T1>() where T1 : CampTileBaseData<T>, new()
	{
		return null;
	}

	public void UpdateData(CampID occupyCamp, int[] occupyValue, int addAttackCount)
	{
	}
}
