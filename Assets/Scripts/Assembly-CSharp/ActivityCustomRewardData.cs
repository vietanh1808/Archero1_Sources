using Newtonsoft.Json;

public class ActivityCustomRewardData
{
	[JsonProperty("id")]
	public int Id;

	[JsonProperty("Product_id")]
	public string ProductId;

	public int Count;

	public int Quota;

	public int[][] Optional;

	public string Title;

	[JsonProperty("discount")]
	public int Discount;

	public int DailyReset;

	private int index => 0;

	public string GetSourceName(int index)
	{
		return null;
	}

	public int GetLeftCount()
	{
		return 0;
	}

	public void RefreshDailyCount()
	{
	}
}
