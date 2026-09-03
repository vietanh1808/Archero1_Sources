using System.Collections.Generic;
using GameProtocol;

namespace homepage
{
	public class ServerHeroVO : HeroVO
	{
		private CRespQueryOtherUser serverData;

		private ulong userId;

		private CHeroItem[] m_arrayHeroData;

		private CHeroSkin[] m_arrayHeroSkin;

		public Dictionary<int, int[]> carvingDict;

		private SyncHeroVO serverHeroVO;

		private int m_WingStar;

		private const int DEFAULT_SKIN_ID = 110000;

		private const uint DEFAULT_HERO_ID = 10000u;

		public void SetUserId(ulong _userId)
		{
		}

		public void SetServerData(CRespQueryOtherUser _serverData)
		{
		}

		public override int GetCurHeroCount()
		{
			return 0;
		}

		public override int GetCurMonsterCount()
		{
			return 0;
		}

		private bool hasDefaultArcheroSkin()
		{
			return false;
		}

		public override int GetCurSkinCount()
		{
			return 0;
		}

		public override int GetCurStage()
		{
			return 0;
		}

		public override int GetCurStage_Hell()
		{
			return 0;
		}

		public override int GetStageNormalMaxLayer()
		{
			return 0;
		}

		public override int GetStageHellMaxLayer()
		{
			return 0;
		}

		public override int GetStageShowMode()
		{
			return 0;
		}

		public override int GetHeadFrameId()
		{
			return 0;
		}

		public override int GetHeadId()
		{
			return 0;
		}

		private CHeroItem[] getHeroDatas()
		{
			return null;
		}

		private CHeroSkin[] getHeroSkinDatas()
		{
			return null;
		}

		public override List<HeroListItemVO> GetExistHeroListData()
		{
			return null;
		}

		private CHeroItem getHeroItemBySkinID(int skinId)
		{
			return null;
		}

		public override int GetMaxHeroCount()
		{
			return 0;
		}

		public override int GetMaxSkinCount()
		{
			return 0;
		}

		public override int GetMaxMonsterCount()
		{
			return 0;
		}

		public override int GetMaxStage()
		{
			return 0;
		}

		public override int GetMaxStage_Hell()
		{
			return 0;
		}

		protected bool HasMonsterSprite(MonsterListItemVO itemVO)
		{
			return false;
		}

		public List<MonsterListItemVO> GetExistMonsterListItemData()
		{
			return null;
		}

		public override List<MonsterListItemVO> GetMonsterListItemData()
		{
			return null;
		}

		public override string GetName()
		{
			return null;
		}

		public override string GetUserId()
		{
			return null;
		}

		public bool isSkinExpired(int skinId)
		{
			return false;
		}

		public bool IsSkinUnlock(int skinId)
		{
			return false;
		}

		public override List<int> GetHaveMedals()
		{
			return null;
		}

		public override List<int> GetHeroAssistList()
		{
			return null;
		}

		public override int GetHeroAssistLeader()
		{
			return 0;
		}

		public override int GetHeroAssistLevel(int heroid)
		{
			return 0;
		}

		public override List<LocalSave.ArtifactOne> GetArtifactUsedList()
		{
			return null;
		}

		public override LocalSave.PetOne[] GetHavePets()
		{
			return null;
		}

		public override int GetBeliefLevel()
		{
			return 0;
		}
	}
}
