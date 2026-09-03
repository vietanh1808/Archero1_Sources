using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using TableTool;

public class TotemManager : SingletonNet<TotemManager, CReqEquipTotem, CRespEquipTotem>
{
	private Dictionary<(int rare, int level), Totem_TotemRefine> _refineConfigMap;

	private long FreeRefreshTime;

	public int UseFreeEnhanceCount;

	public bool IsSyncData;

	protected override string Name => null;

	public List<TotemSlotItemData> SlotsItemData { get; private set; }

	public TotemData TotemData { get; private set; }

	public long RefreshLeftTime => 0L;

	private int OpenTotemCond => 0;

	public bool IsOpen => false;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override CReqEquipTotem RequestPacket()
	{
		return null;
	}

	public override SendRequestTime RequestTime()
	{
		return SendRequestTime.None;
	}

	protected override bool AllowBurstRequest()
	{
		return false;
	}

	protected override bool RequestCond()
	{
		return false;
	}

	protected override void Response(NetResponse response, CRespEquipTotem data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	public void RequestTotemEnhance(int totemConfigID, long totemRowID, Action<bool> callBack)
	{
	}

	public void RequestTotemResolve(long[] totemRowID, Action<bool> callBack)
	{
	}

	public void RequestTotemSyncLockStatus(int totemConfigID, long totemRowID, bool isLocked, Action<bool> callBack)
	{
	}

	public void RequestTotemRefine(int totemConfigID, long totemRowID, uint lockedSubAttrMask, Action<bool> callBack)
	{
	}

	public void RequestSaveTotemRefine(int totemConfigID, long totemRowID, Action<bool> callBack)
	{
	}

	public void RequestDiscardTotemRefine(int totemConfigID, long totemRowID, Action<bool> callBack)
	{
	}

	private void RequestPendingRefineOperation(ushort type, int totemConfigID, long totemRowID, Action<bool> callBack)
	{
	}

	private void RequestTotemRefineOperation(ushort type, int totemConfigID, long totemRowID, uint num, Action<bool> callBack)
	{
	}

	private void SendTotemRefineSdk(long totemRowID, bool isConfirmed)
	{
	}

	private static string FormatTotemAttribute(TotemAtt attribute)
	{
		return null;
	}

	private static string FormatTotemValue(double value)
	{
		return null;
	}

	private static string GetTotemQualitySdk(int rare)
	{
		return null;
	}

	private static string GetTotemTypeSdk(TotemItemData totem)
	{
		return null;
	}

	private static int CountSetBits(uint value)
	{
		return 0;
	}

	public void SyncTotemWearSlotID(long rowID, int slotID, Action callback = null)
	{
	}

	public void SyncTotemUnWear(long rowID, int slotID, Action callback = null)
	{
	}

	private bool ValidResponse(NetResponse response, Action<bool> action)
	{
		return false;
	}

	private void SendEquipSdk(long rowID, int equipType)
	{
	}

	public void SetTotemData(CTotem[] totemData)
	{
	}

	public void AddTotemData(CTotem[] totemData)
	{
	}

	private void RefreshTotemOneByServerData(CTotem[] serverData)
	{
	}

	public void ClearTotemWearInfo()
	{
	}

	public Totem_TotemRefine GetRefineConfig(int rare, int refineLevel)
	{
		return null;
	}

	public List<Drop_DropModel.DropData> GetRefineMaterials(int rare, int refineLevel, int lockCount)
	{
		return null;
	}

	public void CheckTotemSlot()
	{
	}

	public TotemItemData GetWearTotemBySlotId(int slotID)
	{
		return null;
	}

	public int[] GetAllTotemRare()
	{
		return null;
	}

	public bool IsHaveRed()
	{
		return false;
	}

	public bool IsTotemSlotHaveRed(int slotID)
	{
		return false;
	}

	public Dictionary<int, long> GetTotemWearMap()
	{
		return null;
	}

	public Dictionary<int, long> GetEmptyTotemWearMap()
	{
		return null;
	}

	public List<Goods_goods.GoodData> GetWearTotemAttributes()
	{
		return null;
	}

	public bool IsHaveTotemCanWear()
	{
		return false;
	}

	public TotemSlotItemData GetSlotDataByTotemType(TotemType slotType)
	{
		return null;
	}

	public int GetFreeEnhanceCount()
	{
		return 0;
	}

	public void ResetUseFreeEnhanceCount()
	{
	}

	public TotemSlotItemData GetSlotDataBySlotID(int slotID)
	{
		return null;
	}
}
