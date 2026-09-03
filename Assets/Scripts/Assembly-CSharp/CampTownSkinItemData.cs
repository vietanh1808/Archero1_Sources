using System.Collections.Generic;
using UnityEngine;
using XLua;

public class CampTownSkinItemData
{
	private static DelegateBridge __Hotfix0_get_Config;

	private static DelegateBridge __Hotfix0_set_Config;

	private static DelegateBridge __Hotfix0_get_SkinID;

	private static DelegateBridge __Hotfix0_get_IsUsing;

	private static DelegateBridge __Hotfix0_get_IsUnlock;

	private static DelegateBridge __Hotfix0_get_IsDistinguish;

	private static DelegateBridge __Hotfix0_get_Picture;

	private static DelegateBridge __Hotfix0_get_Icon;

	private static DelegateBridge __Hotfix0_get_Quality;

	private static DelegateBridge __Hotfix0_get_QualityName;

	private static DelegateBridge __Hotfix0_get_QualityColor;

	private static DelegateBridge __Hotfix0_get_LockType;

	private static DelegateBridge __Hotfix0_get_Price;

	private static DelegateBridge __Hotfix0_get_HaveEnoughCurrency;

	private static DelegateBridge __Hotfix0_get_AttributeItemData;

	private static DelegateBridge __Hotfix0_get_IsTimeLimit;

	private static DelegateBridge __Hotfix0_get_SkinShowShifting;

	private static DelegateBridge __Hotfix0_get_SkinPreviewShifting;

	private static DelegateBridge __Hotfix0_get_IsDefault;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_GetAttributeItemData;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTownSkinItemConfigData Config { get; set; }

	public int SkinID => 0;

	public bool IsUsing => false;

	public bool IsUnlock => false;

	public bool IsDistinguish => false;

	public int Picture => 0;

	public string Icon => null;

	public int Quality => 0;

	public string QualityName => null;

	public Color QualityColor => default;

	public CampTownSkinLockType LockType => CampTownSkinLockType.None;

	public string Price => null;

	public bool HaveEnoughCurrency => false;

	public List<CampTownSkinAttributeItemData> AttributeItemData => null;

	public bool IsTimeLimit => false;

	public int SkinShowShifting => 0;

	public int SkinPreviewShifting => 0;

	public bool IsDefault => false;

	public static CampTownSkinItemData Create(CampTownSkinItemConfigData config)
	{
		return null;
	}

	private List<CampTownSkinAttributeItemData> GetAttributeItemData()
	{
		return null;
	}
}
