using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTalentTeamTaskProgressItem : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private GameObject getReward;

	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText progressCount;

	[SerializeField]
	private DxxText clickName;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private Image rewardBg;

	[SerializeField]
	private Image rewardSubBg;

	private bool isInit;

	private LocalUnityObjctPool propPool;

	private CampTalentTeamTaskProgressItemData data;

	private static DelegateBridge __Hotfix0_get_CampTalentManager;

	private static DelegateBridge __Hotfix0_get_CampTalentTeamTaskData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTalentManager CampTalentManager => null;

	private CampTalentTeamTaskData CampTalentTeamTaskData => null;

	public void Init()
	{
	}

	public void Refresh(CampTalentTeamTaskProgressItemData data)
	{
	}

	public void InitObjectPool()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshItem()
	{
	}

	public void RefreshText()
	{
	}

	private void Click()
	{
	}
}
