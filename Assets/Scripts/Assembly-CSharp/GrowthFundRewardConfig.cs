using System;

[Serializable]
public class GrowthFundRewardConfig
{
	public int Layer_Min;

	public int Layer_Max;

	public string[] product_id;

	public GrowthFundRewardIapItem[] iapArray;
}
