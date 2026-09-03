using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Probability_DropShow : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _BoxType;

		private ObscuredString _EquipId;

		private ObscuredInt _Quality;

		private ObscuredInt _DragonRarity;

		private ObscuredFloat _Probability;

		private ObscuredFloat _GuaranteedProbability;

		private ObscuredInt _ItemType;

		private ObscuredString _Img;

		public int ID => 0;

		public int BoxType => 0;

		public string EquipId => null;

		public int Quality => 0;

		public int DragonRarity => 0;

		public float Probability => 0f;

		public float GuaranteedProbability => 0f;

		public int ItemType => 0;

		public string Img => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Probability_DropShow Copy()
		{
			return null;
		}
	}
}
