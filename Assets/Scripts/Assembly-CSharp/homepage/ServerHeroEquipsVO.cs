using System.Collections.Generic;
using GameProtocol;

namespace homepage
{
	public class ServerHeroEquipsVO : HeroEquipsVO
	{
		public List<LocalSave.EquipOne> equipList;

		public SyncHeroVO syncHeroVO;

		public int wingStar;

		public ServerHeroEquipsVO(HeroVO vo)
			: base(null)
		{
		}

		public void SetEquipList(string wearInfo, CEquipmentItem[] arr, int _wingStar)
		{
		}

		private int getWearIndex(ulong uniqueId)
		{
			return 0;
		}

		private LocalSave.EquipOne getEquipOne(ulong uniqueId)
		{
			return null;
		}

		private int getEquipIconByIndex(int index)
		{
			return 0;
		}

		private bool isHave401Or402Equip()
		{
			return false;
		}

		private bool isHaveMagicBookEquip()
		{
			return false;
		}

		public bool hasGemInSlot(int location)
		{
			return false;
		}

		public List<ulong> getGemsInSlot(int location)
		{
			return null;
		}

		public override void Equip_SetRefresh()
		{
		}

		public override int GetClothId()
		{
			return 0;
		}

		public override int GetEquipProcess()
		{
			return 0;
		}

		public override List<LocalSave.EquipOne> GetHaveEquips(bool havewear)
		{
			return null;
		}

		public override int GetPet0Id()
		{
			return 0;
		}

		public override int GetPet1Id()
		{
			return 0;
		}

		public override int GetWeaponId()
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

		public override int GetCharId()
		{
			return 0;
		}

		public int GetCharId(bool isNeedExpired)
		{
			return 0;
		}

		public override int GetHeroId()
		{
			return 0;
		}

		public override ulong[] GetDragonRowIds()
		{
			return null;
		}

		public override int GetClothEquipId()
		{
			return 0;
		}

		public override int GetGemWearTotalLevel(int location)
		{
			return 0;
		}

		public override bool IsShowGemEntrance(int index)
		{
			return false;
		}

		public override int GetSkinId()
		{
			return 0;
		}

		public int GetSkinIdWithoutExpired()
		{
			return 0;
		}

		public override int GetWearWingId(int index = 1)
		{
			return 0;
		}

		public int GetWearWingWithoutCond(int index = 1)
		{
			return 0;
		}

		public override int GetWearWingStar(int index = 1)
		{
			return 0;
		}

		public override int GetWeaponSkinId()
		{
			return 0;
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
