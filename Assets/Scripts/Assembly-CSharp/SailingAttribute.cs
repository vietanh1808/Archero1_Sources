using TableTool;

public class SailingAttribute
{
	private EntityAttributeBase.ValueBase NewPlay125_QualityRateUp;

	private EntityAttributeBase.ValueBase NewPlay125_IDRateUp;

	private EntityAttributeBase.ValueBase NewPlay125_ColumnMax;

	private EntityAttributeBase.ValueBase NewPlay125_RowMax;

	private EntityAttributeBase.ValueFloatBase NewPlay125_RefreshDownPercent;

	private EntityAttributeBase.ValueFloatBase NewPlay125_RefreshNoMoneyPercent;

	private EntityAttributeBase.ValueBase NewPlay125_FirstItem;

	private EntityAttributeBase.ValueBase NewPlay125_MixMoney;

	private EntityAttributeBase.ValueFloatBase NewPlay125_ReplaceDoublePercent;

	private EntityAttributeBase.ValueFloatBase NewPlay125_ReplacePercent;

	public long NewPlay125_QualityRateUp_Value => 0L;

	public long NewPlay125_IDRateUp_Value => 0L;

	public int NewPlay125_ColumnMax_Value => 0;

	public int NewPlay125_RowMax_Value => 0;

	public float NewPlay125_RefreshDown_Value => 0f;

	public float NewPlay125_RefreshNoMoney_Value => 0f;

	public long NewPlay125_FirstItem_Value => 0L;

	public long NewPlay125_MixMoney_Value => 0L;

	public float NewPlay125_ReplaceDouble_Value => 0f;

	public float NewPlay125_Replace_Value => 0f;

	public bool Excute(string attr)
	{
		return false;
	}

	public bool Excute(Goods_goods.GoodData data)
	{
		return false;
	}

	public bool Excute(string goodType, long value)
	{
		return false;
	}
}
