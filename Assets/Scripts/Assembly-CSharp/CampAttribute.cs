using TableTool;

public class CampAttribute
{
	private EntityAttributeBase.ValueBase ArrowHit;

	private EntityAttributeBase.ValueFloatBase ArrowHitPercent;

	private EntityAttributeBase.ValueBase Camp_Wood_Storage_Max;

	private EntityAttributeBase.ValueFloatBase Camp_Wood_Storage_Max_Percent;

	private EntityAttributeBase.ValueBase Camp_Food_Storage_Max;

	private EntityAttributeBase.ValueFloatBase Camp_Food_Storage_Max_Percent;

	private EntityAttributeBase.ValueBase Camp_Iron_Storage_Max;

	private EntityAttributeBase.ValueFloatBase Camp_Iron_Storage_Max_Percent;

	private EntityAttributeBase.ValueBase Camp_Crystal_Storage_Max;

	private EntityAttributeBase.ValueFloatBase Camp_Crystal_Storage_Max_Percent;

	private EntityAttributeBase.ValueBase Camp_Gold_Storage_Max;

	private EntityAttributeBase.ValueFloatBase Camp_Gold_Storage_Max_Percent;

	private EntityAttributeBase.ValueBase Camp_Wood_Output;

	private EntityAttributeBase.ValueFloatBase Camp_Wood_Output_Percent;

	private EntityAttributeBase.ValueBase Camp_Food_Output;

	private EntityAttributeBase.ValueFloatBase Camp_Food_Output_Percent;

	private EntityAttributeBase.ValueBase Camp_Iron_Output;

	private EntityAttributeBase.ValueFloatBase Camp_Iron_Output_Percent;

	private EntityAttributeBase.ValueBase Camp_Crystal_Output;

	private EntityAttributeBase.ValueFloatBase Camp_Crystal_Output_Percent;

	private EntityAttributeBase.ValueFloatBase Camp_IronOre_Output_Gold_Rate;

	private EntityAttributeBase.ValueBase Camp_Dispatch_Hero_Output;

	private EntityAttributeBase.ValueFloatBase Camp_Dispatch_Hero_Output_Percent;

	private EntityAttributeBase.ValueFloatBase Camp_Sweep_Output_Percent;

	private EntityAttributeBase.ValueFloatBase Camp_MonsterNest_Hit_Percent;

	private EntityAttributeBase.ValueFloatBase Camp_Boss_Hit_Percent;

	private EntityAttributeBase.ValueFloatBase Camp_HolyPlace_Hit_Percnet;

	private EntityAttributeBase.ValueBase Camp_Base_Produce_Arrow;

	private EntityAttributeBase.ValueFloatBase Camp_CityGate_Hit_Percent;

	private EntityAttributeBase.ValueFloatBase Camp_Battle_Crystal_Percent;

	private EntityAttributeBase.ValueFloatBase Camp_Battle_Coins_Percent;

	private EntityAttributeBase.ValueFloatBase Camp_Battle_Equips_Percent;

	private EntityAttributeBase.ValueFloatBase Camp_Blessing_Consume_Reduce_Percent;

	private EntityAttributeBase.ValueFloatBase Camp_Honor_Output_Percent;

	private EntityAttributeBase.ValueBase Camp_Vision;

	public long ArrowHit_Value => 0L;

	public float ArrowHitPercent_Value => 0f;

	public long Camp_Wood_Storage_Max_Value => 0L;

	public float Camp_Wood_Storage_Max_Percent_Value => 0f;

	public long Camp_Food_Storage_Max_Value => 0L;

	public float Camp_Food_Storage_Max_Percent_Value => 0f;

	public long Camp_Iron_Storage_Max_Value => 0L;

	public float Camp_Iron_Storage_Max_Percent_Value => 0f;

	public long Camp_Crystal_Storage_Max_Value => 0L;

	public float Camp_Crystal_Storage_Max_Percent_Value => 0f;

	public long Camp_Gold_Storage_Max_Value => 0L;

	public float Camp_Gold_Storage_Max_Percent_Value => 0f;

	public long Camp_Wood_Output_Value => 0L;

	public float Camp_Wood_Output_Percent_Value => 0f;

	public long Camp_Food_Output_Value => 0L;

	public float Camp_Food_Output_Percent_Value => 0f;

	public long Camp_Iron_Output_Value => 0L;

	public float Camp_Iron_Output_Percent_Value => 0f;

	public long Camp_Crystal_Output_Value => 0L;

	public float Camp_Crystal_Output_Percent_Value => 0f;

	public float Camp_IronOre_Output_Gold_Rate_Value => 0f;

	public long Camp_Dispatch_Hero_Output_Value => 0L;

	public float Camp_Dispatch_Hero_Output_Percent_Value => 0f;

	public float Camp_Sweep_Output_Percent_Value => 0f;

	public float Camp_MonsterNest_Hit_Percent_Value => 0f;

	public float Camp_Boss_Hit_Percent_Value => 0f;

	public float Camp_HolyPlace_Hit_Percnet_Value => 0f;

	public bool Produce_Arrow => false;

	public float Camp_CityGate_Hit_Percent_Value => 0f;

	public float Camp_Battle_Crystal_Percent_Value => 0f;

	public float Camp_Battle_Coins_Percent_Value => 0f;

	public float Camp_Battle_Equips_Percent_Value => 0f;

	public float Camp_Blessing_Consume_Reduce_Percent_Value => 0f;

	public float Camp_Honor_Output_Percent_Value => 0f;

	public long Camp_Vision_Value => 0L;

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
