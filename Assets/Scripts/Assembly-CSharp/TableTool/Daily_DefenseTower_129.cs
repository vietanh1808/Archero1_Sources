using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_DefenseTower_129 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _TowerID;

		private ObscuredInt _Level;

		private ObscuredInt _Unlock;

		private ObscuredInt _CharacterSkin;

		private ObscuredInt _Weapon;

		private ObscuredFloat _BodyScale;

		private ObscuredString[] _Attribute;

		private ObscuredInt _Weight;

		private ObscuredInt _QualityColor;

		private ObscuredInt[] _StartSkillsID;

		private ObscuredInt _TowerSkillWeight;

		public int ID => 0;

		public int TowerID => 0;

		public int Level => 0;

		public int Unlock => 0;

		public int CharacterSkin => 0;

		public int Weapon => 0;

		public float BodyScale => 0f;

		public string[] Attribute => null;

		public int Weight => 0;

		public int QualityColor => 0;

		public int[] StartSkillsID => null;

		public int TowerSkillWeight => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_DefenseTower_129 Copy()
		{
			return null;
		}
	}
}
