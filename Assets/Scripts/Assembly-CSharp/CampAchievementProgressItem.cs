using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampAchievementProgressItem : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl click;

	[SerializeField]
	private GameObject getReward;

	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText clickName;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private RectTransform progress;

	[SerializeField]
	private DxxText progressText;

	[SerializeField]
	private Image rewardBg;

	[SerializeField]
	private Image rewardSubBg;

	private bool isInit;

	private float progressOriginWidth;

	private LocalUnityObjctPool propPool;

	private CampAchievementItemData data;

	private static DelegateBridge __Hotfix0_get_CampAchievementManager;

	private static DelegateBridge __Hotfix0_get_CampAchievementData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshProgress;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampAchievementManager CampAchievementManager => null;

	private CampAchievementData CampAchievementData => null;

	public void Init()
	{
	}

	public void Refresh(CampAchievementItemData data)
	{
	}

	private void InitObjectPool()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshItem()
	{
	}

	public void RefreshProgress()
	{
	}

	public void RefreshText()
	{
	}

	private void Click()
	{
	}
}
