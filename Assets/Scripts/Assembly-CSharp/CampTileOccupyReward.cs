using System.Collections.Generic;
using TableTool;
using UnityEngine;
using XLua;

public class CampTileOccupyReward : MonoBehaviour
{
	[SerializeField]
	private DxxText tile;

	[SerializeField]
	private Transform parent;

	private LocalUnityObjctPool propPool;

	private List<Drop_DropModel.DropData> rewards;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_RefreshPreviewItem;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init()
	{
	}

	public void Refresh(List<Drop_DropModel.DropData> rewards)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void InitObjectPool()
	{
	}

	public void RefreshPreviewItem()
	{
	}
}
