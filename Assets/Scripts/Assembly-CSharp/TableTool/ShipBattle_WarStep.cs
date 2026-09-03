using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_WarStep : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt[] _StepArea;

		private ObscuredInt _ViewDistance;

		private ObscuredInt[] _DistanceRankNum;

		private ObscuredFloat[] _SkySpeed;

		private ObscuredFloat[] _CloudSpeed;

		private ObscuredFloat[] _IslandSpeed;

		private ObscuredFloat[] _MountainSpeed;

		private ObscuredFloat[] _WaterSpeed;

		private ObscuredString _SkyPic;

		private ObscuredString _CloudPic;

		private ObscuredString _IslandPic;

		private ObscuredString _MountainPic;

		private ObscuredString _WaterPic;

		private ObscuredInt _ShipNum;

		private ObscuredInt[] _ShipShow;

		private ObscuredString[] _ShipChannel;

		private ObscuredInt _SelfChannel;

		private ObscuredInt _DistancePar1;

		private ObscuredInt _DistancePar2;

		public int ID => 0;

		public int[] StepArea => null;

		public int ViewDistance => 0;

		public int[] DistanceRankNum => null;

		public float[] SkySpeed => null;

		public float[] CloudSpeed => null;

		public float[] IslandSpeed => null;

		public float[] MountainSpeed => null;

		public float[] WaterSpeed => null;

		public string SkyPic => null;

		public string CloudPic => null;

		public string IslandPic => null;

		public string MountainPic => null;

		public string WaterPic => null;

		public int ShipNum => 0;

		public int[] ShipShow => null;

		public string[] ShipChannel => null;

		public int SelfChannel => 0;

		public int DistancePar1 => 0;

		public int DistancePar2 => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_WarStep Copy()
		{
			return null;
		}
	}
}
