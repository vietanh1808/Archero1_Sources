using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;
using UnityEngine;

public class DragonMagicGlobalManager
{
	private static DragonMagicGlobalManager _instance;

	public Dictionary<string, string> Attr2AddDict;

	public int[] totalUnlockedChapters;

	public static DragonMagicGlobalManager Instance => null;

	public bool IsDragonBlocked => false;

	public int CheckIfDragonEquip(int skillId)
	{
		return 0;
	}

	public int Convert2DragonMagicId(int equipId)
	{
		return 0;
	}

	private float GetDeltaPercentForBasicProperties(int equipID, int skillLevel, SelfAttributeData selfAttributeData)
	{
		return 0f;
	}

	public Dictionary<string, Goods_goods.GoodData> GetAddAttributesByEquipOne(LocalSave.EquipOne equipOne)
	{
		return null;
	}

	public Dictionary<string, Goods_goods.GoodData> GetBasicAttributesByEquipOne(LocalSave.EquipOne equipOne, SelfAttributeData selfAttributeData)
	{
		return null;
	}

	public int Convert2SkillIdBySkillLevel(int skillId, int skillLevel)
	{
		return 0;
	}

	public int Convert2SkillLevelBySkillId(int skillId)
	{
		return 0;
	}

	public DragonMagic_DragonMagic GetDragonMagicMetaByEquipId(int equipId)
	{
		return null;
	}

	public bool IsSkillSlotUnlocked(LocalSave.EquipOne equipOne, int skillSlotIndex)
	{
		return false;
	}

	public LocalSave.EquipOne GetDragonOneBySlotIndex(int slotIndex)
	{
		return null;
	}

	public float GetDeltaPercentForEquipAttributes(LocalSave.EquipOne equipOne, SelfAttributeData selfAttributeData)
	{
		return 0f;
	}

	public bool HaveAvailableDragon()
	{
		return false;
	}

	public bool HaveDragonInGame(DragonType dragonType)
	{
		return false;
	}

	public int GetUnlockedDragonSlots()
	{
		return 0;
	}

	public int GetPassedStageByMaxLayer(ushort maxLayer)
	{
		return 0;
	}

	public bool IsDragonSlotUnlocked(int slotIndex)
	{
		return false;
	}

	public bool CanDragonUpgrade()
	{
		return false;
	}

	public bool CanDragonCombine()
	{
		return false;
	}

	public bool CanSingleDragonUpgrade(LocalSave.EquipOne dragon, out bool matEnough, out int matNeed, out int matHave, out bool goldEnough, out int goldNeed, out long goldHave, out bool limitedByMaxLevel, out bool limitedByDragonLevel)
	{
		matEnough = default;
		matNeed = default;
		matHave = default;
		goldEnough = default;
		goldNeed = default;
		goldHave = default;
		limitedByMaxLevel = default;
		limitedByDragonLevel = default;
		return false;
	}

	private DragonMagic_DragonUpgrade GetUpgradeConfig(LocalSave.EquipOne dragon = null)
	{
		return null;
	}

	private DragonMagic_DragonMagic GetConfig(LocalSave.EquipOne dragonEquip = null)
	{
		return null;
	}

	private LocalSave.EquipOne GetEquip(ulong curRowId)
	{
		return null;
	}

	public void CheckIfCreateDragonRarity(LocalSave.EquipOne equipdata, Transform parent, ref GameObject dragonRarity)
	{
	}

	public void CheckIfCreatePetRarity(LocalSave.PetOne pet, Transform parent, ref GameObject dragonRarity)
	{
	}

	public void CheckIfCreateWingRarity(LocalSave.WingOne wing, Transform parent, ref GameObject dragonRarity)
	{
	}

	public void CheckIfCreateRarity_Artifact(LocalSave.ArtifactOne artifact, Transform parent, ref GameObject dragonRarity)
	{
	}

	public void CheckIfCreateDragonRarity(int rarity, Transform parent, ref GameObject dragonRarity)
	{
	}

	public int GetDragonSkillId(LocalSave.EquipOne dragonEquip, int skillSlotIndex)
	{
		return 0;
	}

	public bool checkOpenLevelUpKeyOne()
	{
		return false;
	}

	public bool isShowLevelUpKeyOne(LocalSave.EquipOne dragon)
	{
		return false;
	}

	public int GetLevelUpMax(LocalSave.EquipOne dragon)
	{
		return 0;
	}

	public void ReduceMatLevelUpKeyOne(int dragonId, int from, int to)
	{
	}

	public void requestLevelUpKeyOne(ulong rowid, Action<CRespDragonUpgrade, int> action = null)
	{
	}
}
