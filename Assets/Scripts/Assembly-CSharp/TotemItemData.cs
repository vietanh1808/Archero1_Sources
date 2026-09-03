using System.Collections.Generic;
using GameProtocol;
using TableTool;
using UnityEngine;

public class TotemItemData
{
	private TotemItemSourceData SourceData { get; set; }

	public int ID => 0;

	public long RowID => 0L;

	public int Level => 0;

	public int RefineLevel => 0;

	public uint RefineLockMask => 0u;

	public TotemRefineResultData PendingRefineResult => null;

	public bool HasPendingRefineResult => false;

	public Totem_Totem ConfigData => null;

	public int MaxLevel => 0;

	public bool IsMaxLevel => false;

	public bool HasRefined => false;

	public bool CanRefine => false;

	public bool IsRefineMaxLevel => false;

	public TotemDisplayLevelType DisplayLevelType => TotemDisplayLevelType.Enhance;

	public string NameOnlyString => null;

	public string EnhanceNameString => null;

	public string NameString => null;

	public Color RareColor => default;

	public Sprite Icon => null;

	public TotemAtt MainAtt => null;

	public TotemAtt MainNextLevelAtt => null;

	public TotemAtt[] SubAtt => null;

	public TotemAtt[] SubNextLevelAtt => null;

	public List<int> LockAttLevel => null;

	public int Rare => 0;

	public bool IsLocked => false;

	public HashSet<TotemType> TotemSlotType => null;

	public long WearSlotID => 0L;

	public List<Goods_goods.GoodData> Attributes => null;

	public string GetTotemSlotTypeToSdk()
	{
		return null;
	}

	public static TotemItemData Create(TotemItemSourceData sourceData)
	{
		return null;
	}

	public List<Drop_DropModel.DropData> GetUpgradeNeed()
	{
		return null;
	}

	public List<Drop_DropModel.DropData> GetRefineMaterials(int lockCount)
	{
		return null;
	}

	public bool CanAffordRefine(int lockCount)
	{
		return false;
	}

	public List<Drop_DropModel.DropData> GetResolveMaterials()
	{
		return null;
	}

	public List<TotemAtt> GetSkillAtt()
	{
		return null;
	}

	public List<TotemAtt> GetNormalAtt()
	{
		return null;
	}

	public void SyncTotemWearSlot(int slotID)
	{
	}

	public void SyncLockStatus(bool isLocked)
	{
	}

	public void UpdateData(int level, TotemAtt mainAtt, TotemAtt[] subAtt, bool isLocked, STTotemRefineInfo refineInfo)
	{
	}

	public TotemAtt GetTotemAttByConfigId(int configID)
	{
		return null;
	}
}
