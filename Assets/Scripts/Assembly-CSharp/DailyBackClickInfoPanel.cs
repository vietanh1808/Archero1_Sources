using UnityEngine;
using UnityEngine.UI;
using XLua;

public class DailyBackClickInfoPanel : MonoBehaviour
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText costTip;

	[SerializeField]
	private DxxText costText;

	[SerializeField]
	private DxxText canGetBackPercentTip;

	[SerializeField]
	private DxxText getBackCount;

	[SerializeField]
	private DxxText canGetBackCountTip;

	[SerializeField]
	private DxxText cancelBtnName;

	[SerializeField]
	private DxxText clickBtnName;

	[SerializeField]
	private ButtonCtrl addBtn;

	[SerializeField]
	private ButtonCtrl reduceBtn;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ButtonCtrl cancelBtn;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private Image icon;

	private DailyBackRewardButtonItemData itemData;

	private int selectCount;

	private int costCount;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Show;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshSelect;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_AddClick;

	private static DelegateBridge __Hotfix0_ReduceClick;

	private static DelegateBridge __Hotfix0_GetDailyBackTypeName;

	private static DelegateBridge __Hotfix0_GetDailyBackType;

	private static DelegateBridge __Hotfix0_GetDailyBackNeedCount;

	private static DelegateBridge __Hotfix0_CheckCurrency;

	private static DelegateBridge __Hotfix0_CheckReachCond;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init()
	{
	}

	public void Show(DailyBackRewardButtonItemData itemData)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshSelect(int selectCount)
	{
	}

	private void Click()
	{
	}

	private void AddClick()
	{
	}

	private void ReduceClick()
	{
	}

	private string GetDailyBackTypeName()
	{
		return null;
	}

	private string GetDailyBackType()
	{
		return null;
	}

	private int GetDailyBackNeedCount(CurrencyType currencyType)
	{
		return 0;
	}

	private void CheckCurrency(int selectCount)
	{
	}

	private bool CheckReachCond()
	{
		return false;
	}
}
