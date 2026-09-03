using UnityEngine;
using XLua;

public class CampMap : MonoBehaviour
{
	public CampMapEventHandler touchHandler;

	public int Width;

	public int Height;

	public Camera Camera_Camp;

	public Camera Camera_UI;

	public GridLayout gridLayout;

	public TileMapLayer Layer_Ground;

	public TileMapLayer Layer_Road;

	public TileMapLayer Layer_Building;

	public TileMapLayer Layer_Fog;

	[HideInInspector]
	public float totalOffsetx;

	[HideInInspector]
	public float totalOffsety;

	[HideInInspector]
	public int BeginRealX;

	[HideInInspector]
	public int BeginRealY;

	[HideInInspector]
	public int BeginMapX;

	[HideInInspector]
	public int BeginMapY;

	[HideInInspector]
	public int BeginBasicX;

	[HideInInspector]
	public int BeginBasicY;

	private LocalUnityObjctPool mLocalPool;

	[HideInInspector]
	public bool isMoving;

	[HideInInspector]
	public bool isNeedFreshMap;

	public TileExtraItemMgr tileExtraItemMgr;

	private const float MinX = -15f;

	private const float MinY = -15f;

	private const float MaxX = 215f;

	private const float MaxY = 215f;

	private bool showFog;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_createMap;

	private static DelegateBridge __Hotfix0_resetEnterMap;

	private static DelegateBridge __Hotfix0_handleDrag;

	private static DelegateBridge __Hotfix0_requestMapData_Fresh;

	private static DelegateBridge __Hotfix0_handleClick;

	private static DelegateBridge __Hotfix0_PosMapXY_RealXY;

	private static DelegateBridge __Hotfix0_PosRealXY_MapXY;

	private static DelegateBridge __Hotfix0_GetTilePopUIXY;

	private static DelegateBridge __Hotfix0_FreshAllTileState;

	private static DelegateBridge __Hotfix0_FreshOneTileState;

	private static DelegateBridge __Hotfix0_FreshTileOneRoad;

	private static DelegateBridge __Hotfix0_FreshTileOneFog;

	private static DelegateBridge __Hotfix0_FreshAllTileFog;

	private static DelegateBridge __Hotfix0_AddExtraItem;

	private static DelegateBridge __Hotfix0_DeleteExtraItem;

	private static DelegateBridge __Hotfix0_setFogView;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Awake()
	{
	}

	public void createMap(int cellx, int celly)
	{
	}

	public void resetEnterMap(int centerx, int centery)
	{
	}

	public void handleDrag(float offx, float offy)
	{
	}

	public void requestMapData_Fresh()
	{
	}

	public void handleClick(Vector2 v2)
	{
	}

	public Vector2Int PosMapXY_RealXY(Vector2Int mv2)
	{
		return default;
	}

	public Vector2Int PosRealXY_MapXY(Vector2Int rv2)
	{
		return default;
	}

	public Vector2 GetTilePopUIXY(int tidex, Vector3Int cpos)
	{
		return default;
	}

	public void FreshAllTileState()
	{
	}

	public void FreshOneTileState(int rx, int ry)
	{
	}

	public void FreshTileOneRoad(int rx, int ry)
	{
	}

	public void FreshTileOneFog(int rx, int ry)
	{
	}

	public void FreshAllTileFog()
	{
	}

	public void AddExtraItem(LayerName layer, int rx, int ry, int mx, int my)
	{
	}

	public void DeleteExtraItem(int mx, int my)
	{
	}

	public void setFogView()
	{
	}
}
