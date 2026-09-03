public class ConsumeTaskItemBaseData
{
	public int ID;

	public int Type;

	public int Pos;

	public int Need;

	public int ShowNeed;

	public int Process;

	public ushort IsDone;

	public uint[] VecArgs;

	public int[][] Rewards;

	public static ConsumeTaskItemBaseData Create(int id, int type, int pos, int need, int showNeed, int process, ushort isDone, uint[] vecArgs, int[][] rewards)
	{
		return null;
	}

	public void SyncProcess(int process)
	{
	}

	public void SyncIsDone(ushort isDone)
	{
	}
}
