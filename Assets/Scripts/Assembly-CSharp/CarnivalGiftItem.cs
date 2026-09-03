using System.Collections.Generic;
using UnityEngine;
using XLua;

public class CarnivalGiftItem : MonoBehaviour
{
	public Transform rewardParent;

	public PropOneEquip rewardObj;

	public GameObject maskObj;

	public ButtonCtrl get_Button;

	public DxxText limitTex;

	public GameObject zhekou;

	public DxxText valueTex;

	public DxxText valueDes;

	public DxxText button_text;

	public ButtonCtrl ad_btn;

	public DxxText ad_text;

	public ButtonCtrl adFree_btn;

	public DxxText adFree_text;

	private List<PropOneEquip> RewardList;

	private SevenDayChallengeGiftData item;

	protected AdCallbackControl mAd;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_ClickAd;

	private static DelegateBridge __Hotfix0_OnADEndWrapper;

	private static DelegateBridge __Hotfix0_OnADEnd;

	private static DelegateBridge __Hotfix0_ClickGet;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshState;

	private static DelegateBridge __Hotfix0_InitReward;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init(SevenDayChallengeGiftData item, bool isOpen)
	{
	}

	public void ClickAd()
	{
	}

	private void OnADEndWrapper()
	{
	}

	protected virtual void OnADEnd()
	{
	}

	public void ClickGet()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshState()
	{
	}

	public void InitReward()
	{
	}
}
