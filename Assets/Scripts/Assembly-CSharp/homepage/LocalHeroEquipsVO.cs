using System.Collections.Generic;

namespace homepage
{
	public class LocalHeroEquipsVO : HeroEquipsVO
	{
		public LocalHeroEquipsVO(HeroVO vo)
			: base(null)
		{
		}

		public override void Equip_SetRefresh()
		{
		}

		public override int GetCharId()
		{
			return 0;
		}

		public override int GetClothEquipId()
		{
			return 0;
		}

		public override int GetClothId()
		{
			return 0;
		}

		public override int GetEquipProcess()
		{
			return 0;
		}

		public override int GetGemWearTotalLevel(int location)
		{
			return 0;
		}

		public override List<LocalSave.EquipOne> GetHaveEquips(bool havewear)
		{
			return null;
		}

		public override int GetHeroId()
		{
			return 0;
		}

		public override int GetPet0Id()
		{
			return 0;
		}

		public override int GetPet1Id()
		{
			return 0;
		}

		public override int GetSkinId()
		{
			return 0;
		}

		public override int GetWeaponSkinId()
		{
			return 0;
		}

		public override int GetWeaponId()
		{
			return 0;
		}

		public override bool IsShowGemEntrance(int index)
		{
			return false;
		}

		public override int GetWearWingId(int index = 1)
		{
			return 0;
		}

		public override int GetWearWingStar(int index = 1)
		{
			return 0;
		}

		public override bool Show()
		{
			return false;
		}

		public override bool ShowMagicBook()
		{
			return false;
		}

		public override ulong[] GetDragonRowIds()
		{
			return null;
		}

		public override int[] GetCarvingIds(int pos)
		{
			return null;
		}

		public override bool IsCarvingEffectVisible(int pos)
		{
			return false;
		}

		public override int GetColorID()
		{
			return 0;
		}
	}
}
