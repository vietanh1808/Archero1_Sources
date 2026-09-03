using System.Collections.Generic;
using TableTool;

public class ConsumeTaskItemData : RecycleData<ConsumeTaskItemBaseData>
{
	public int ID => 0;

	public int Type => 0;

	public int Pos => 0;

	public int Need => 0;

	public int ShowNeed => 0;

	public int Process => 0;

	public bool IsDone => false;

	public bool IsCanGet => false;

	public uint[] VecArgs => null;

	public List<Drop_DropModel.DropData> Rewards => null;

	public void SyncProcess(int process)
	{
	}

	public void SyncIsDone(ushort isDone)
	{
	}
}
