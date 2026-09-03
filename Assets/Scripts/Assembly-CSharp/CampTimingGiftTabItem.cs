using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTimingGiftTabItem : MonoBehaviour
{
	[SerializeField]
	private Image activeBgImg;

	[SerializeField]
	private DxxText price;

	[SerializeField]
	private GameObject mask;

	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private RectTransform btnRect;

	public GameObject StarObj;

	public DxxText StarText;

	private string giftPrice;

	private string productId;

	private bool isSelect;

	private int curIndex;

	private static DelegateBridge __Hotfix0_get_ThemeType;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshTheme;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTimingGiftThemeType ThemeType => CampTimingGiftThemeType.None;

	public void Refresh(int curSelectIndex, int curIndex, string productId)
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshText()
	{
	}

	public void RefreshTheme()
	{
	}

	private void Click()
	{
	}
}
