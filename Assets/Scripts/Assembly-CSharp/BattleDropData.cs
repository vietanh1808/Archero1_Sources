public class BattleDropData
{
	public class CustomDropHp
	{
		public int hp;

		public EntityHero entity;
	}

	public FoodType type;

	public FoodOneType childtype;

	public object data;

	public BattleDropData(FoodType type, object data)
	{
	}

	public BattleDropData(FoodType type, FoodOneType childtype, object data)
	{
	}

	public BattleDropData(FoodType type, FoodOneType childtype, int hp, EntityHero entity)
	{
	}

	private void Init(FoodType type, FoodOneType childtype, object data)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
