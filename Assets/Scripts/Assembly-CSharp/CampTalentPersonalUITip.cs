using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTalentPersonalUITip : MonoBehaviour
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private DxxText attribute;

	[SerializeField]
	private DxxText currencyACount;

	[SerializeField]
	private DxxText currencyBCount;

	[SerializeField]
	private GameObject currencyA;

	[SerializeField]
	private GameObject currencyB;

	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private DxxText upgradeNeedCount;

	[SerializeField]
	private DxxText clickName;

	[SerializeField]
	private DxxText lockText;

	[SerializeField]
	private DxxText rewardTitle;

	[SerializeField]
	private ButtonCtrl closeMask;

	[SerializeField]
	private GameObject allFinish;

	[SerializeField]
	private GameObject reward;

	[SerializeField]
	private Image currencyIcon;

	private CampTalentPersonalProgressItemData data;

	private static DelegateBridge __Hotfix0_get_CampTalentManager;

	private static DelegateBridge __Hotfix0_Show;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_GetCurrencyAbCount;

	private static DelegateBridge __Hotfix0_GetLockText;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_Disable;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTalentManager CampTalentManager => null;

	public void Show(CampTalentPersonalProgressItemData data)
	{
	}

	public void Close()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshText()
	{
	}

	public void RefreshStatus()
	{
	}

	public (int, int) GetCurrencyAbCount()
	{
		return default;
	}

	public string GetLockText()
	{
		return null;
	}

	private void Click()
	{
	}

	public void Disable()
	{
	}

	private void Esc()
	{
	}
}
