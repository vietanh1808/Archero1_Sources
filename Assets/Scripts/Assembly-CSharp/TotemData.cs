using System.Collections.Generic;
using GameProtocol;

public class TotemData : RecycleData<TotemSourceData>
{
	public List<TotemItemData> ItemDataList => null;

	public List<TotemItemData> WearTotemList => null;

	public TotemItemData GetTotemItemDataByRowID(long rowID)
	{
		return null;
	}

	public List<TotemItemData> GetTotemListCanResolve()
	{
		return null;
	}

	public (List<TotemAtt>, List<TotemAtt>) GetAllWearTotemAtt()
	{
		return default;
	}

	public TotemItemData GetTotemItemDataBySlotID(int slotID)
	{
		return null;
	}

	public List<TotemItemData> GetTotemByTotemType(TotemType type)
	{
		return null;
	}

	public void RefreshTotemOneByServerData(CTotem[] serverData)
	{
	}

	public void DelegateTotemDataByRowIDs(long[] rowID)
	{
	}

	public void AddTotemData(CTotem[] totem)
	{
	}

	public void SyncLock(long rowID, bool isLocked)
	{
	}

	public void SyncTotemOneWearSlotID(long rowID, int slotID)
	{
	}

	public void ClearTotemWearInfo()
	{
	}
}
