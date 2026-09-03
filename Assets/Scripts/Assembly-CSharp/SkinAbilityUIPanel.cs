using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class SkinAbilityUIPanel : MediatorCtrlBase
{
	public RawImage img_heroShow;

	private HeroShow heroShow;

	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText levelName;

	[SerializeField]
	private DxxText attackName;

	[SerializeField]
	private DxxText bloodName;

	[SerializeField]
	private DxxText levelValue;

	[SerializeField]
	private DxxText attackValue;

	[SerializeField]
	private DxxText bloodValue;

	[SerializeField]
	private DxxText attributeTitle;

	[SerializeField]
	private DxxText upgradeTitle;

	[SerializeField]
	private DxxText resetName;

	[SerializeField]
	private DxxText upgradeName;

	[SerializeField]
	private DxxText fastUpgradeName;

	[SerializeField]
	private DxxText skinName;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ButtonCtrl resetBtn;

	[SerializeField]
	private ButtonCtrl upgradeBtn;

	[SerializeField]
	private ButtonCtrl fastUpgradeBtn;

	[SerializeField]
	private Transform modelParent;

	[SerializeField]
	private SkinAbilityItem abilityItem;

	[SerializeField]
	private Transform abilityItemParent;

	[SerializeField]
	private SkinAbilityMaterialItem materialItem;

	[SerializeField]
	private Transform materialParent;

	[SerializeField]
	private Slider levelSlider;

	[SerializeField]
	private SkinAbilitUpAni attrAni;

	[SerializeField]
	private SkinAbilityBtnAni btnAni;

	[SerializeField]
	private Animator levelAnimator;

	[SerializeField]
	private DxxText skinMaxLevelText;

	private Dictionary<int, GameObject> skinDic;

	private LocalUnityObjctPool pool;

	private static DelegateBridge __Hotfix0_get_SkinAbilityManager;

	private static DelegateBridge __Hotfix0_get_SkinAbilityData;

	private static DelegateBridge __Hotfix0_set_SkinAbilityData;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshImmediately;

	private static DelegateBridge __Hotfix0_RefreshLate;

	private static DelegateBridge __Hotfix0_RefreshSkin;

	private static DelegateBridge __Hotfix0_createHeroModel;

	private static DelegateBridge __Hotfix0_createHeroShow;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshAbilityItem;

	private static DelegateBridge __Hotfix0_RefreshMaterialItem;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_ResetEvent;

	private static DelegateBridge __Hotfix0_UpgradeEvent;

	private static DelegateBridge __Hotfix0_UpgradeDisabledEvent;

	private static DelegateBridge __Hotfix0_FastUpgradeEvent;

	private static DelegateBridge __Hotfix0_Upgrade;

	private static DelegateBridge __Hotfix0_ClearSkinModel;

	private static DelegateBridge __Hotfix0_PlayUpgradeAni;

	private static DelegateBridge __Hotfix0_PlayBtnAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge __Hotfix0_SendMsg;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge _c__Hotfix0_ctor;

	private SkinAbilityManager SkinAbilityManager => null;

	private SkinAbilityData SkinAbilityData { get; set; }

	private void InitObjectPool()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshImmediately()
	{
	}

	private void RefreshLate()
	{
	}

	private void RefreshSkin()
	{
	}

	private void createHeroModel(GameObject modelObj)
	{
	}

	private GameObject createHeroShow(GameObject prefab)
	{
		return null;
	}

	private void RefreshItem()
	{
	}

	private void RefreshAbilityItem()
	{
	}

	private void RefreshMaterialItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void ResetEvent()
	{
	}

	private void UpgradeEvent()
	{
	}

	private void UpgradeDisabledEvent()
	{
	}

	private void FastUpgradeEvent()
	{
	}

	private void Upgrade(int upgrade)
	{
	}

	private void ClearSkinModel()
	{
	}

	private void PlayUpgradeAni(float startAttack, float endAttack, float startBlood, float endBlood)
	{
	}

	private void PlayBtnAni()
	{
	}

	private void StopAni()
	{
	}

	private void SendMsg(List<SkinAbilityMaterialItemData> materialItemData, bool isFastUpgrade)
	{
	}

	private void Esc()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
