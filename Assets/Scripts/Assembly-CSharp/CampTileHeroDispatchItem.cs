using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTileHeroDispatchItem : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private GameObject curSelect;

	[SerializeField]
	private Image heroIcon;

	[SerializeField]
	private Image heroDispatchStatus;

	[SerializeField]
	private Image heroAdditionIcon;

	[SerializeField]
	private DxxText heroAdditionText;

	[SerializeField]
	private Image heroDispatchResourceIcon;

	[SerializeField]
	private DxxText heroDispatchResourceLevel;

	[SerializeField]
	private GameObject heroDispatchResource;

	[SerializeField]
	private DxxText star;

	public Image Image_Star;

	private LocalSave.CharacterOne data;

	private (int, int) curPos;

	private CampTileResourceType curResourceType;

	private int additionCount;

	private int selectHeroID;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshSelect;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshIcon;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_GetHeroIconName;

	private static DelegateBridge __Hotfix0_GetHeroDispatchStatus;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh((int, int) curPos, int selectHeroID, LocalSave.CharacterOne data, int additionCount, CampTileResourceType curResourceType)
	{
	}

	public void RefreshSelect(int selectD)
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshIcon()
	{
	}

	private void Click()
	{
	}

	public string GetHeroIconName()
	{
		return null;
	}

	public (HeroDispatchStatus, (int, int)) GetHeroDispatchStatus()
	{
		return default;
	}
}
