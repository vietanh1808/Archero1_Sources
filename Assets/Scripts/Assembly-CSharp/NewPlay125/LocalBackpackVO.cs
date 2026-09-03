using System;
using System.Collections.Generic;

namespace NewPlay125
{
	[Serializable]
	public class LocalBackpackVO : BaseLocalVO, LocalSave.ICloneable<LocalBackpackVO>
	{
		public int PreTetrisUid;

		public int UnlockedUnitRowIndex;

		public int UnlockedUnitColumnIndex;

		public int RefreshWave;

		public int RefreshTimes;

		public int RefreshPrice;

		public int[,] PackGridsLayoutForSave;

		public int[,] UnlockedPackGridsLayoutForSave;

		public List<int> weaponsIn;

		public List<int> UnderUnitsList;

		public Dictionary<int, TetrisUnit.CoreData> InPackUnitDatasDict;

		public void Clone(LocalBackpackVO source)
		{
		}

		public void Refresh()
		{
		}

		public void Sync2UnlockedUnitRowIndex(int index)
		{
		}

		public void Sync2UnlockedUnitColumnIndex(int index)
		{
		}

		public void SynRefreshAction(int wave, int refreshTimes)
		{
		}

		public void SyncRefreshPrice(int price)
		{
		}

		public override void Clear()
		{
		}
	}
}
