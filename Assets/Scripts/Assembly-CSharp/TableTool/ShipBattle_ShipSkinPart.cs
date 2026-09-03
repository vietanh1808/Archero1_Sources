using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_ShipSkinPart : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Desc;

		private ObscuredInt _Type;

		private ObscuredInt _Round;

		private ObscuredString _Icon;

		private ObscuredString _Img;

		private ObscuredString[] _ShipAbility;

		private ObscuredString[] _Ability;

		private ObscuredFloat[] _Ratio;

		private ObscuredFloat _PowerRatio;

		private ObscuredString _SkillDesc;

		private ObscuredString[] _Effect;

		private ObscuredString[] _EffectPos;

		public int ID => 0;

		public string Desc => null;

		public int Type => 0;

		public int Round => 0;

		public string Icon => null;

		public string Img => null;

		public string[] ShipAbility => null;

		public string[] Ability => null;

		public float[] Ratio => null;

		public float PowerRatio => 0f;

		public string SkillDesc => null;

		public string[] Effect => null;

		public string[] EffectPos => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_ShipSkinPart Copy()
		{
			return null;
		}
	}
}
