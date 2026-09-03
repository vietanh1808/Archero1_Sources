using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileIcon : MonoBehaviour
{
	[SerializeField]
	private GridLayoutGroup gridLayoutGroup;

	[SerializeField]
	private CampTileIconItem iconItem;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private DxxImage icon_King;

	private LocalUnityObjctPool pool;

	private float originSize;

	private int titleID;

	private int imageID;

	private CampID occupyCamp;

	private static DelegateBridge __Hotfix0_get_CampTileResourceType;

	private static DelegateBridge __Hotfix0_get_CampTileType;

	private static DelegateBridge __Hotfix0_get_CurCampStyle;

	private static DelegateBridge __Hotfix0_get_CampMapManager;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshGrid;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshImageScale;

	private static DelegateBridge __Hotfix0_GetImageID;

	private static DelegateBridge __Hotfix0_GetTileSize;

	private static DelegateBridge __Hotfix0_GetTileAllSize;

	private static DelegateBridge __Hotfix0_GetTileScale;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTileResourceType CampTileResourceType => CampTileResourceType.None;

	private CampTileType CampTileType => CampTileType.None;

	private int CurCampStyle => 0;

	private CampMapManager CampMapManager => null;

	public void Init()
	{
	}

	public void Refresh(int titleID, CampID occupyCamp, int imageID)
	{
	}

	public void RefreshGrid()
	{
	}

	public void RefreshItem()
	{
	}

	public void RefreshImageScale()
	{
	}

	public int GetImageID()
	{
		return 0;
	}

	public int GetTileSize()
	{
		return 0;
	}

	public int GetTileAllSize()
	{
		return 0;
	}

	public float GetTileScale()
	{
		return 0f;
	}
}
