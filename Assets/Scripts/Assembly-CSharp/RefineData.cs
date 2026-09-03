using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using TableTool;

public class RefineData
{
	private enum RefineRequestType
	{
		Info = 0,
		Refine = 1,
		RefineBreakThrough = 2,
		EquipCarving = 3,
		CombineCarving = 4,
		ExtractCarving = 5
	}

	private Dictionary<uint, uint> carvingIdToCount;

	private List<int> refineLevelByPosIndex;

	private List<int[]> equippedIdsByPosIndex;

	public Dictionary<int, int> CarvingAttributeLevelToQuality;

	public int ExtractCount { get; private set; }

	public List<LocalSave.EquipOne> GetAllCarvingItems()
	{
		return null;
	}

	public List<LocalSave.EquipOne> GetCaringItemsByPos(int pos)
	{
		return null;
	}

	public LocalSave.EquipOne GetCarvingItemById(int id)
	{
		return null;
	}

	public int GetRefineLevel(int index)
	{
		return 0;
	}

	public int SetRefineLevel(int index, int value)
	{
		return 0;
	}

	public List<STCarvingItem> GetCarvings(bool includingEquipped)
	{
		return null;
	}

	public void AddCarvings(STCarvingItem[] all)
	{
	}

	public void AddCarving(STCarvingItem item)
	{
	}

	public void UpdateCarvings(STCarvingItem[] all)
	{
	}

	private void UpdateCarving(STCarvingItem item)
	{
	}

	public void RemoveCarving(uint id)
	{
	}

	public List<(int, int)> GetEquippedPosAndSlotById(int id)
	{
		return null;
	}

	public int[] GetEquippedCarvingsByPos(int pos)
	{
		return null;
	}

	public void SyncEquippedCarvingsByPos(int pos, int[] carvingIds)
	{
	}

	public void ReqInfo(Action<bool> callback = null)
	{
	}

	private void OnInfoResponse(NetResponse response, Action<bool> callback = null)
	{
	}

	public void ReqExtract(ulong[] rowIds, Dictionary<int, int> scrolls, int gold, Action<bool> callback = null)
	{
	}

	private void OnExtractCarvingResponse(NetResponse response, ulong[] rowIds, Dictionary<int, int> scrolls, int gold, Action<bool> callback)
	{
	}

	public void ReqCombine(uint[] ids, int mainPos, int mainSlot, Action<bool> callback = null)
	{
	}

	private void OnCombineCarvingResponse(NetResponse response, uint[] ids, int mainPos, int mainSlot, Action<bool> callback)
	{
	}

	public void ReqEquipCarving(ushort posId, ushort index, uint id, Action<bool> callback = null)
	{
	}

	private void OnEquipCarvingResponse(NetResponse response, ushort posId, ushort index, uint id, Action<bool> callback)
	{
	}

	public void ReqRefine(ushort pos, int materialId, int materialCount, int gold, ulong[] materials = null, Action<bool, List<Drop_DropModel.DropData>> callback = null)
	{
	}

	private void OnRefineResponse(NetResponse response, ushort pos, ulong[] equipMaterials, int materialId, int materialCount, int gold, Action<bool, List<Drop_DropModel.DropData>> callback)
	{
	}

	private static bool ProcessResponse(NetResponse response, out CRespEquipRefine o, out string reason)
	{
		o = null;
		reason = null;
		return false;
	}

	public static int GetRandomCarvingId(int attributesLevel, int position, int type)
	{
		return 0;
	}

	public static int GetRandomCarvingId(int attributesLevel, int position, bool isCore)
	{
		return 0;
	}
}
