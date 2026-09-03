using PureMVC.Patterns;
using XLua;

public class CampTileRefreshProxy : Proxy
{
	public class Transfer
	{
		public (int, int) position;

		public CampID occupyCamp;

		public bool needRefreshResetTime;

		public int[] occupyValue;

		public int attackCount;

		public int bossStage;

		public int[] bossMonsterOccupyValue;

		public int[] bossCampRank;

		public int[] bossCampScore;

		public long bossDeadTime;
	}

	public new const string NAME = "CampTileRefreshProxy";

	private static DelegateBridge _c__Hotfix0_ctor;

	public CampTileRefreshProxy(object data)
	{
	}
}
