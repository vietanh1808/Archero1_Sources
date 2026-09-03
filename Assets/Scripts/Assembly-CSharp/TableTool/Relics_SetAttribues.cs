using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Relics_SetAttribues : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt[] _Args;

		private ObscuredInt[] _SkillEffects;

		private ObscuredString[] _SkillEffectsNum;

		public int Id => 0;

		public int[] Args => null;

		public int[] SkillEffects => null;

		public string[] SkillEffectsNum => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Relics_SetAttribues Copy()
		{
			return null;
		}
	}
}
