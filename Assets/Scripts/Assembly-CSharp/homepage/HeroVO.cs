using System.Collections.Generic;

namespace homepage
{
	public abstract class HeroVO
	{
		public bool openFromMyCard;

		public HeroEquipsVO heroEquipsVO;

		public abstract int GetHeadId();

		public abstract int GetHeadFrameId();

		public abstract string GetName();

		public abstract string GetUserId();

		public override string ToString()
		{
			return null;
		}

		public abstract int GetCurHeroCount();

		public abstract int GetCurSkinCount();

		public abstract List<HeroListItemVO> GetExistHeroListData();

		public virtual List<HeroListItemVO> GetHeroListData()
		{
			return null;
		}

		public abstract int GetCurMonsterCount();

		public abstract List<MonsterListItemVO> GetMonsterListItemData();

		public abstract int GetCurStage();

		public abstract int GetCurStage_Hell();

		public abstract int GetStageShowMode();

		public abstract int GetStageNormalMaxLayer();

		public abstract int GetStageHellMaxLayer();

		public abstract int GetMaxHeroCount();

		public abstract int GetMaxSkinCount();

		public abstract int GetMaxMonsterCount();

		public abstract int GetMaxStage();

		public abstract int GetMaxStage_Hell();

		public abstract List<int> GetHaveMedals();

		public abstract LocalSave.PetOne[] GetHavePets();

		public abstract List<int> GetHeroAssistList();

		public abstract int GetHeroAssistLeader();

		public abstract int GetHeroAssistLevel(int heroid);

		public abstract List<LocalSave.ArtifactOne> GetArtifactUsedList();

		public abstract int GetBeliefLevel();

		public List<StageChapterListItemVO> GetStageChapterListItemData()
		{
			return null;
		}

		public List<StageChapterListItemVO> GetStageChapterListItemData_Hell()
		{
			return null;
		}

		protected MonsterListItemVO createMonsterListItemVO(int monsterId, int star, bool exist, int type)
		{
			return null;
		}

		protected HeroListItemVO createHeroListItemVO(int Star, int SkinCharacterID, int Rank, bool Exist, int skinId)
		{
			return null;
		}

		protected bool IsDefaultSkin(int skinId)
		{
			return false;
		}

		protected bool HasStageChapterSprite(StageChapterListItemVO itemVO)
		{
			return false;
		}

		protected int GetPassedStageByMaxLayer(ushort maxLayer)
		{
			return 0;
		}

		protected bool HasHeroSprite(HeroListItemVO itemVO)
		{
			return false;
		}
	}
}
