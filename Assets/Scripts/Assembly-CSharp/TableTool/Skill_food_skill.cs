using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_food_skill : LocalBean
	{
		private ObscuredInt _FoodID;

		private ObscuredInt _Weight;

		private ObscuredInt _Sale;

		private ObscuredInt _Skillid;

		public int FoodID => 0;

		public int Weight => 0;

		public int Sale => 0;

		public int Skillid => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_food_skill Copy()
		{
			return null;
		}
	}
}
