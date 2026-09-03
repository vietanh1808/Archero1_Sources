using System.Collections.Generic;

namespace homepage
{
	public abstract class HeroEquipsVO
	{
		protected HeroVO _heroVO;

		public HeroVO heroVO => null;

		public abstract int GetEquipProcess();

		public abstract int GetWeaponId();

		public abstract int GetClothId();

		public abstract int GetPet0Id();

		public abstract int GetPet1Id();

		public abstract void Equip_SetRefresh();

		public abstract bool Show();

		public abstract bool ShowMagicBook();

		public abstract List<LocalSave.EquipOne> GetHaveEquips(bool havewear);

		public abstract int GetCharId();

		public abstract int GetHeroId();

		public abstract int GetSkinId();

		public abstract int GetWeaponSkinId();

		public abstract int GetClothEquipId();

		public abstract int GetGemWearTotalLevel(int location);

		public abstract int GetWearWingId(int index = 1);

		public abstract int GetWearWingStar(int index = 1);

		public abstract ulong[] GetDragonRowIds();

		public int GetGemTotalLevelToQuality(int totalLevel)
		{
			return 0;
		}

		public abstract bool IsShowGemEntrance(int index);

		public abstract int[] GetCarvingIds(int pos);

		public abstract bool IsCarvingEffectVisible(int pos);

		public abstract int GetColorID();

		public HeroEquipsVO(HeroVO vo)
		{
		}
	}
}
