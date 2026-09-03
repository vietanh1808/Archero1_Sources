using System;
using GameProtocol;
using TableTool;
using UnityEngine;

public class DragonMagicSkillDetail : MonoBehaviour
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtSkillType;

	[SerializeField]
	private DxxText txtDesc;

	[SerializeField]
	private DxxText txtBtnUpgrade;

	[SerializeField]
	private DxxText txtLevelMax;

	[SerializeField]
	private DxxText txtManaCost;

	[SerializeField]
	private ButtonCtrl btnUpgrade;

	[SerializeField]
	private ButtonCtrl btnBG;

	[SerializeField]
	private RectTransform rtTip;

	[SerializeField]
	private DragonMagicDetailUICtrl ctrl;

	[SerializeField]
	private DragonMagicSkillProperty[] props;

	[SerializeField]
	private PropOneEquip material;

	[SerializeField]
	private GameObject goManaCost;

	private ushort skillIndex;

	private DragonMagic_MagicConfig magicConfig;

	private ulong equipRowId;

	private void Awake()
	{
	}

	private void OnBtnUpgradeClick()
	{
	}

	private void dragonSkillUpDCError(CDragonUpgarde packet, int skillSlotIndex)
	{
	}

	private void PerformUpgrade(ushort newLevel, Action callback = null)
	{
	}

	public void Open(ulong rowId, int skillIndex)
	{
	}

	private void OnDisable()
	{
	}

	private void OnEscape()
	{
	}

	private void SetPosAndTip()
	{
	}

	private void Refresh()
	{
	}

	private void SetProps()
	{
	}

	private void SetDynamicTexts()
	{
	}

	private LocalSave.EquipOne GetEquip()
	{
		return null;
	}

	private DragonMagic_DragonMagic GetConfig(LocalSave.EquipOne equip = null)
	{
		return null;
	}
}
