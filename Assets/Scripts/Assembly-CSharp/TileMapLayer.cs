using UnityEngine;
using UnityEngine.Tilemaps;
using XLua;

public class TileMapLayer : MonoBehaviour
{
	public CampMap campMap;

	public Tilemap tileMap;

	[HideInInspector]
	public int Layer;

	private int Width;

	private int Height;

	private static DelegateBridge __Hotfix0_init;

	private static DelegateBridge __Hotfix0_addTileX;

	private static DelegateBridge __Hotfix1_addTileX;

	private static DelegateBridge __Hotfix0_addTileY;

	private static DelegateBridge __Hotfix1_addTileY;

	private static DelegateBridge __Hotfix0_DeleteTileX;

	private static DelegateBridge __Hotfix0_DeleteTileY;

	private static DelegateBridge __Hotfix0_handleClick;

	private static DelegateBridge __Hotfix0_FreshTileState;

	private static DelegateBridge __Hotfix0_FreshOneTileState;

	private static DelegateBridge __Hotfix0_FreshTileOneRoad;

	private static DelegateBridge __Hotfix0_FreshTileOneFog;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void init(LayerName layer)
	{
	}

	public void addTileX(int rx, int ry, int mx, int my)
	{
	}

	public void addTileX(int rx, int ry, int mx, int my, int pic)
	{
	}

	public void addTileY(int rx, int ry, int mx, int my)
	{
	}

	public void addTileY(int rx, int ry, int mx, int my, int pic)
	{
	}

	public void DeleteTileX(int mx, int my)
	{
	}

	public void DeleteTileY(int mx, int my)
	{
	}

	public bool handleClick(Vector3 wpos, Vector3Int cpos)
	{
		return false;
	}

	public void FreshTileState(int rx, int ry, int mx, int my)
	{
	}

	public void FreshOneTileState(int rx, int ry, int mx, int my)
	{
	}

	public void FreshTileOneRoad(int rx, int ry, int mx, int my)
	{
	}

	public void FreshTileOneFog(int rx, int ry, int mx, int my)
	{
	}
}
