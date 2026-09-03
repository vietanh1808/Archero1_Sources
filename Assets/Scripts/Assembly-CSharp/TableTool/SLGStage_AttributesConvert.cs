using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLGStage_AttributesConvert : LocalBean
	{
		private ObscuredString _ID;

		private ObscuredFloat _TargetNum;

		public string ID => null;

		public float TargetNum => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLGStage_AttributesConvert Copy()
		{
			return null;
		}
	}
}
