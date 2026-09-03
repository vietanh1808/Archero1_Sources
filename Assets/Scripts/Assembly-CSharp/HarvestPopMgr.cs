public class HarvestPopMgr : CInstance<HarvestPopMgr>
{
	private bool bExcuted;

	private bool bOpened;

	private int check_count;

	private const float Check_Interval = 5f;

	private const float Check_Interval_Add = 1f;

	private const int Check_Max_Count = 10;

	private float check_time;

	public void CheckPop()
	{
	}

	private void check_internal()
	{
	}

	private bool can_open()
	{
		return false;
	}

	private void open_window()
	{
	}
}
