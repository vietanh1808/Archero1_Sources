using XLua;

public class CampTileResourceData : CampTileBaseData<CampTileResourceConfigData>
{
	private static DelegateBridge __Hotfix0_get_CampTileManager;

	private static DelegateBridge __Hotfix0_get_TileResourceType;

	private static DelegateBridge __Hotfix0_get_TileBattleStatus;

	private static DelegateBridge __Hotfix0_get_BattleLeftTime;

	private static DelegateBridge __Hotfix0_get_OccupiedLeftTime;

	private static DelegateBridge __Hotfix0_get_OutputReward;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTileManager CampTileManager => null;

	public CampTileResourceType TileResourceType => CampTileResourceType.None;

	public CampTileBattleStatus TileBattleStatus => CampTileBattleStatus.None;

	public long BattleLeftTime => 0L;

	public long OccupiedLeftTime => 0L;

	public (CampTileOutputResourceType, float) OutputReward => default;
}
