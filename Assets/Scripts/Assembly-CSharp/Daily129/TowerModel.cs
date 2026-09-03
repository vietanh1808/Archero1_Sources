namespace Daily129
{
	public class TowerModel
	{
		private TowerData[] _vecTowerDatas;

		private TowerData _curTowerData;

		public readonly string Guid;

		public TowerData CurTowerData => null;

		public int TowerId => 0;

		public int Level => 0;

		public TowerModel(TowerData[] towerDatas, string guid)
		{
		}

		public bool Upgrade()
		{
			return false;
		}

		public bool IsMaxLevel()
		{
			return false;
		}

		public new string ToString()
		{
			return null;
		}
	}
}
