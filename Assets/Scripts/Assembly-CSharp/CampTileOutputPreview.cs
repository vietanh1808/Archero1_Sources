using UnityEngine;
using XLua;

public class CampTileOutputPreview : MonoBehaviour
{
	[SerializeField]
	private DxxText tile;

	[SerializeField]
	private CampTileOutputPreviewItem previewItem;

	private (CampTileOutputResourceType, float) rewards;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_RefreshPreviewItem;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init()
	{
	}

	public void Refresh((CampTileOutputResourceType, float) rewards)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void RefreshPreviewItem()
	{
	}
}
