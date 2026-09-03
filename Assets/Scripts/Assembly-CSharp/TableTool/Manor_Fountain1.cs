using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_Fountain1 : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Dew;

		private ObscuredInt[] _Drawing;

		private ObscuredString[] _Ability;

		private ObscuredString[] _DropID;

		public int Id => 0;

		public int Dew => 0;

		public int[] Drawing => null;

		public string[] Ability => null;

		public string[] DropID => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_Fountain1 Copy()
		{
			return null;
		}
	}
}
