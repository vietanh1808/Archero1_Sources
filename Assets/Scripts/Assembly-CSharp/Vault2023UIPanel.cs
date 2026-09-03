using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class Vault2023UIPanel : MonoBehaviour, IUILifeCycle
{
	[SerializeField]
	private Vault2023ShowRewardItem showRewardItem;

	[SerializeField]
	private Transform showRewardParent;

	[SerializeField]
	private Vault2023GameRewardItem gameRewardItem;

	[SerializeField]
	private Transform gameRewardParent;

	[SerializeField]
	private DxxText keyCount;

	[SerializeField]
	private ButtonCtrl clickExchange;

	[SerializeField]
	private ButtonCtrl clickGift;

	[SerializeField]
	private Image keyIcon;

	[SerializeField]
	private GameObject exchangeRed;

	[SerializeField]
	private GameObject giftRed;

	[SerializeField]
	private DxxText exchangeName;

	[SerializeField]
	private DxxText giftName;

	[SerializeField]
	private Image exchangeImg;

	private LocalUnityObjctPool pool;

	private List<Vault2023GameRewardItem> createItem;

	private List<Vault2023ShowRewardItem> createShowReward;

	public ButtonCtrl Button_Skip;

	public GameObject SkipCheck;

	public DxxText Text_Skip;

	private static DelegateBridge __Hotfix0_get_Christmas2023Manager;

	private static DelegateBridge __Hotfix0_get_Vault2023Data;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshTop;

	private static DelegateBridge __Hotfix0_RefreshTopNot;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshShowRewardItem;

	private static DelegateBridge __Hotfix0_RefreshGameRewardItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshImg;

	private static DelegateBridge __Hotfix0_RefreshRed;

	private static DelegateBridge __Hotfix0_RefreshSkip;

	private static DelegateBridge __Hotfix0_RefreshGuide;

	private static DelegateBridge __Hotfix0_RefreshGuideIndex;

	private static DelegateBridge __Hotfix0_RefreshGuideShow;

	private static DelegateBridge __Hotfix0_GetGuideGraphic;

	private static DelegateBridge _c__Hotfix0_ctor;

	private Christmas2023Manager Christmas2023Manager => null;

	private Vault2023Data Vault2023Data => null;

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

	private void RefreshTop()
	{
	}

	private void RefreshTopNot()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshShowRewardItem()
	{
	}

	private void RefreshGameRewardItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshImg()
	{
	}

	private void RefreshRed()
	{
	}

	private void RefreshSkip()
	{
	}

	private void RefreshGuide()
	{
	}

	private void RefreshGuideIndex()
	{
	}

	private void RefreshGuideShow()
	{
	}

	private Image GetGuideGraphic(int guideIndex)
	{
		return null;
	}
}
