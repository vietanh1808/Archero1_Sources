using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Artifact_Artifact : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Quality;

		private ObscuredInt _Rarity;

		private ObscuredString[] _Model;

		private ObscuredInt _FragmentId;

		private ObscuredInt _FragmentNum;

		private ObscuredString[] _Attributes;

		private ObscuredInt[] _SkillID;

		private ObscuredString[] _StarUnlock_Attributes;

		private ObscuredString[] _StarUnlock_Language;

		private ObscuredInt _MaxStar;

		private ObscuredInt _DivideVersion;

		private ObscuredFloat _ATK_Attributes_Ratio;

		private ObscuredFloat _HP_Attributes_Ratio;

		private ObscuredInt[] _TrialBonus;

		private ObscuredFloat[] _BaseEffect;

		private ObscuredFloat[] _BaseEffect1;

		private ObscuredFloat[] _Rotate1;

		private ObscuredFloat _ModelSize;

		private ObscuredFloat[] _Position;

		private ObscuredFloat[] _Rotate;

		private ObscuredInt[] _InnerSkill;

		private ObscuredInt[] _TrialInnerSkill;

		private ObscuredString[] _PlayStar;

		public int Id => 0;

		public int Quality => 0;

		public int Rarity => 0;

		public string[] Model => null;

		public int FragmentId => 0;

		public int FragmentNum => 0;

		public string[] Attributes => null;

		public int[] SkillID => null;

		public string[] StarUnlock_Attributes => null;

		public string[] StarUnlock_Language => null;

		public int MaxStar => 0;

		public int DivideVersion => 0;

		public float ATK_Attributes_Ratio => 0f;

		public float HP_Attributes_Ratio => 0f;

		public int[] TrialBonus => null;

		public float[] BaseEffect => null;

		public float[] BaseEffect1 => null;

		public float[] Rotate1 => null;

		public float ModelSize => 0f;

		public float[] Position => null;

		public float[] Rotate => null;

		public int[] InnerSkill => null;

		public int[] TrialInnerSkill => null;

		public string[] PlayStar => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Artifact_Artifact Copy()
		{
			return null;
		}
	}
}
