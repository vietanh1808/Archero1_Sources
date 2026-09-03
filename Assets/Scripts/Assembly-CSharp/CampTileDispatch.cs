using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileDispatch : MonoBehaviour
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private Image icon;

	private (int, int) curResourcePos;

	private CampTileResourceType resourceType;

	private LocalSave.CharacterOne dispatchHeroData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshIcon;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init()
	{
	}

	public void Refresh((int, int) curResourcePos, CampTileResourceType resourceType)
	{
	}

	public void RefreshIcon()
	{
	}

	public void OnLanguageChange()
	{
	}

	private void Click()
	{
	}
}
