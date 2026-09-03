public class CampTalentAttribute
{
	public string AttributeName { get; set; }

	public int Value { get; set; }

	public string Describe { get; set; }

	public bool IsPercent { get; set; }

	public static CampTalentAttribute Create(string attributeName, int value, string describe)
	{
		return null;
	}

	public void AddValue(int value)
	{
	}

	private void UpdateDescribe()
	{
	}
}
