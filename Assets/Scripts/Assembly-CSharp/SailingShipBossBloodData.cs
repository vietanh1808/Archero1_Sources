public class SailingShipBossBloodData
{
	public int Index { get; set; }

	public int ProgressActiveIndex { get; set; }

	public int ProgressIconIndex { get; set; }

	public int ProgressMaxValue { get; set; }

	public int ProgressValue { get; set; }

	public int ProgressRealValue => 0;

	public static SailingShipBossBloodData Create(int progressActiveIndex, int progressIconIndex, int progressMaxValue, int index)
	{
		return null;
	}

	public int UpdateData(int progressValue)
	{
		return 0;
	}
}
