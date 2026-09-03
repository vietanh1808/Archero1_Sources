using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class CampTalentUIPanel : MonoBehaviour, ICampUILifeCycle
{
	[SerializeField]
	protected CampTalentPersonalUIPanel personalUIPanel;

	[SerializeField]
	private CampTalentTeamUIPanel teamUIPanel;

	[SerializeField]
	private ToggleGroup toggleGroup;

	[SerializeField]
	private GameObject level;

	[SerializeField]
	private GameObject task;

	[SerializeField]
	private ButtonCtrl info;

	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText levelText;

	[SerializeField]
	private DxxText taskText;

	[SerializeField]
	private DxxText personalBtn;

	[SerializeField]
	private DxxText teamBtn;

	[SerializeField]
	private DxxText personalMaskBtn;

	[SerializeField]
	private DxxText teamMaskBtn;

	[SerializeField]
	private RedNodeCtrl personalTabRed;

	[SerializeField]
	private RedNodeCtrl teamTabRed;

	[SerializeField]
	private ButtonCtrl taskBtn;

	[SerializeField]
	private RedNodeCtrl taskBtnRed;

	[SerializeField]
	private CampTalentTip campTalentTip;

	[SerializeField]
	protected ButtonCtrl mask;

	private bool isPersonalTab;

	private static DelegateBridge __Hotfix0_get_CampTalentManager;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshTab;

	private static DelegateBridge __Hotfix0_ClickInfo;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshShow;

	private static DelegateBridge __Hotfix0_RefreshRed;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_TaskClick;

	private static DelegateBridge __Hotfix0_GetPersonalTipStr;

	private static DelegateBridge __Hotfix0_GetTeamTipStr;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTalentManager CampTalentManager => null;

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void RefreshText()
	{
	}

	public void RefreshTab(int index)
	{
	}

	private void ClickInfo()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshShow()
	{
	}

	public void RefreshRed()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	private void TaskClick()
	{
	}

	private (string, string) GetPersonalTipStr()
	{
		return default;
	}

	private (string, string) GetTeamTipStr()
	{
		return default;
	}
}
