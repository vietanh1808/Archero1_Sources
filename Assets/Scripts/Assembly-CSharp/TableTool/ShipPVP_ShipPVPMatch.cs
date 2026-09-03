using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipPVP_ShipPVPMatch : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredFloat[] _MatchRange;

		private ObscuredInt _Win;

		private ObscuredInt _Lose;

		private ObscuredInt[] _First;

		private ObscuredInt[] _Second;

		private ObscuredInt[] _Third;

		public int ID => 0;

		public float[] MatchRange => null;

		public int Win => 0;

		public int Lose => 0;

		public int[] First => null;

		public int[] Second => null;

		public int[] Third => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipPVP_ShipPVPMatch Copy()
		{
			return null;
		}
	}
}
