using System;

namespace NewPlay125
{
	[Serializable]
	public class LocalInGameVO : BaseLocalVO, LocalSave.ICloneable<LocalInGameVO>
	{
		public int WeaponId;

		public int WeaponSkinId;

		public int FinishedWave;

		public void Clone(LocalInGameVO source)
		{
		}

		public void Sync2FinishedWave(int wave)
		{
		}

		public void Sync2WeaponId(int id)
		{
		}

		public void Sync2WeaponSkinId(int id)
		{
		}

		public override void Clear()
		{
		}
	}
}
