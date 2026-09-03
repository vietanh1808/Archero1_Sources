using TableTool;

public class DailyBackData
{
	private DailyBackConfigData DailyBackConfigData { get; set; }

	private LocalModelManager LocalModelManager => null;

	public bool IsOpen => false;

	public long ActivityLeftTime => 0L;

	public int DayCount => 0;

	public bool ReachOpenCond => false;

	public void SyncRemoteData(DailyBackConfigData dailyBackConfigData)
	{
	}

	public void Clear()
	{
	}

	public bool HaveData()
	{
		return false;
	}

	private bool ReachCond()
	{
		return false;
	}
}
