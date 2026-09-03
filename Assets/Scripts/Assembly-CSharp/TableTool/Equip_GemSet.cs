using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_GemSet : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Name;

		private ObscuredInt[] _GemType;

		private ObscuredString[] _GreenAdditionSkills;

		private ObscuredString[] _BlueAdditionSkills;

		private ObscuredString[] _PurpleAdditionSkills;

		private ObscuredString[] _GoldAdditionSkills;

		private ObscuredString[] _UnlockCondition;

		public int Id => 0;

		public string Name => null;

		public int[] GemType => null;

		public string[] GreenAdditionSkills => null;

		public string[] BlueAdditionSkills => null;

		public string[] PurpleAdditionSkills => null;

		public string[] GoldAdditionSkills => null;

		public string[] UnlockCondition => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_GemSet Copy()
		{
			return null;
		}
	}
}
