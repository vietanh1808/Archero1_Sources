using System.Collections.Generic;

namespace homepage
{
	public class LocalHeroVO : HeroVO
	{
		private const int DEFAULT_SKIN_ID = 110000;

		public override int GetCurHeroCount()
		{
			return 0;
		}

		public override int GetCurMonsterCount()
		{
			return 0;
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

		private bool hasDefaultArcheroSkin()
		{
			return false;
		}

		public override List<HeroListItemVO> GetExistHeroListData()
		{
			return null;
		}

		private List<int> getDiffSkinIds()
		{
			return null;
		}

		private LocalSave.CharacterOne getCharacterOneBySkinID(int _skinId)
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

		public override int GetBeliefLevel()
		{
			return 0;
		}

		public override LocalSave.PetOne[] GetHavePets()
		{
			return null;
		}
	}
}
