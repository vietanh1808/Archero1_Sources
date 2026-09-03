using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileOutputPreviewItem : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private DxxText rate;

	private CampTileOutputResourceType type;

	private int rateCount;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(CampTileOutputResourceType type, float rateCount)
	{
	}
}
