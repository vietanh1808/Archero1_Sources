using GameProtocol;

public class TotemItemSourceData
{
	public int ID;

	public long RowID;

	public int Level;

	public TotemAtt MainAtt;

	public TotemAtt[] SubAtt;

	public bool IsLocked;

	public int WearSlotID;

	public int RefineTimes;

	public uint RefineLockMask;

	public bool HasPendingRefineResult;

	public TotemRefineResultData PendingRefineResult;

	public static TotemItemSourceData Create(int id, long rowID, int level, TotemAtt mainAtt, TotemAtt[] subAtt, bool isLocked, STTotemRefineInfo refineInfo = null)
	{
		return null;
	}

	public static TotemItemSourceData Create(CTotem totem)
	{
		return null;
	}

	public void SyncWearSlotID(int slotID)
	{
	}

	public void SyncLockedStatus(bool isLocked)
	{
	}

	public void UpdateData(int level, TotemAtt mainAtt, TotemAtt[] subAtt, bool isLocked, STTotemRefineInfo refineInfo)
	{
	}

	private void SyncRefineInfo(STTotemRefineInfo refineInfo)
	{
	}
}
