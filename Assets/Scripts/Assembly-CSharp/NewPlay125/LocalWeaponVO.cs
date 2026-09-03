using System;

namespace NewPlay125
{
	[Serializable]
	public class LocalWeaponVO : BaseLocalVO, LocalSave.ICloneable<LocalWeaponVO>
	{
		public int needAddCoinCount;

		public void Clone(LocalWeaponVO source)
		{
		}

		public void SetAddBagCoinCount(int needAddCoinCount)
		{
		}

		public void UpdateNeedAddBagCoinCount(int changeCount)
		{
		}

		public override void Clear()
		{
		}
	}
}
