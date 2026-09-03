using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class LuckyWheelExtraReward : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private LuckyWheelExtraRewardItem rewardItem;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private DxxText curProgress;

	[SerializeField]
	private RectTransform progress;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private HorizontalLayoutGroup horizontalLayoutGroup;

	[SerializeField]
	private GameObject arrow;

	[SerializeField]
	private RectTransform progressBg;

	private List<LuckyWheelExtraRewardItem> rewardItemList;

	private LocalUnityObjctPool pool;

	private static DelegateBridge __Hotfix0_get_LuckyWheelManager;

	private static DelegateBridge __Hotfix0_get_LuckyWheelData;

	private static DelegateBridge __Hotfix0_get_LuckyWheelExtraRewardData;

	private static DelegateBridge __Hotfix0_get_PreviewItemCount;

	private static DelegateBridge __Hotfix0_get_ProgressMaxWidth;

	private static DelegateBridge __Hotfix0_get_AllProgressMaxScore;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshProgress;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshScroll;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshArrowStatus;

	private static DelegateBridge __Hotfix0_GetPreviewItemCount;

	private static DelegateBridge __Hotfix0_GetProgressMaxWidth;

	private static DelegateBridge __Hotfix0_GetProgressOriginWidth;

	private static DelegateBridge __Hotfix0_GetAllProgressMaxScore;

	private static DelegateBridge _c__Hotfix0_ctor;

	private LuckyWheelManager LuckyWheelManager => null;

	private LuckyWheelData LuckyWheelData => null;

	private LuckyWheelExtraRewardData LuckyWheelExtraRewardData => null;

	private int PreviewItemCount => 0;

	private float ProgressMaxWidth => 0f;

	private int AllProgressMaxScore => 0;

	private void InitObjectPool()
	{
	}

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshProgress()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshScroll()
	{
	}

	private void RefreshStatus()
	{
	}

	public void RefreshArrowStatus(Vector2 value)
	{
	}

	private int GetPreviewItemCount()
	{
		return 0;
	}

	private float GetProgressMaxWidth()
	{
		return 0f;
	}

	private float GetProgressOriginWidth()
	{
		return 0f;
	}

	private int GetAllProgressMaxScore()
	{
		return 0;
	}
}
