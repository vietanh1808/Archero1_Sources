using System;
using Newtonsoft.Json;

[Serializable]
public class DiamondChoiceItemData
{
	[JsonProperty("id")]
	public int Id;

	public int Diamond_Price;

	public int Diamond_InitialePrice;

	public int Count;

	public int Quota;

	public int[][] Optional;

	[JsonProperty("discount")]
	public int Discount;

	public int DailyReset;
}
