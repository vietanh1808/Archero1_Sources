using System.Collections.Generic;
using TableTool;

public class PetManager : CInstance<PetManager>
{
	public enum PetRare
	{
		B = 0,
		A = 1,
		S = 2,
		SS = 3
	}

	public enum PetSkillPosIndex
	{
		Battle = 0,
		Talent1 = 1,
		Talent2 = 2,
		Inherit1 = 3,
		Inherit2 = 4
	}

	public const int PetExchangeCoinID = 33078;

	public bool forceBulletThroughWall;

	public const string LOG_TAG = "[Battle_Pet]";

	private PetAttrVO petAttrVO;

	private PetSkillVO petSkillVO;

	private List<BattlePetVO> battlePetVOs;

	public PetAttrVO PetAttrVO => null;

	public PetSkillVO PetSkillVO => null;

	public List<BattlePetVO> BattlePetVOs => null;

	public int PetCountInScene => 0;

	protected override void Init()
	{
	}

	protected override void LateInit()
	{
	}

	protected override void ReLogin()
	{
	}

	protected override void Clear()
	{
	}

	public void InitBattlePetVOs()
	{
	}

	public void DeInitBattlePetVOs()
	{
	}

	public LocalSave.PetOne[] GetExistedPets()
	{
		return null;
	}

	public LocalSave.PetOne[] GetUpWarPets()
	{
		return null;
	}

	public LocalSave.PetOne[] GetHelpWarPets()
	{
		return null;
	}

	public LocalSave.PetOne[] GetNonWarPets()
	{
		return null;
	}

	public List<Goods_goods.GoodData> GetUnlockedAttrList(int curValue, int[] allValues, string[] attrs)
	{
		return null;
	}

	public List<int> GetUnlockedSkillIds(int curValue, int[] allValues, string[] attrs)
	{
		return null;
	}

	public List<string> GetUnlockedStrs(int unlockIndex, string[] allUnlockAttrs)
	{
		return null;
	}

	public List<PetSkillVO.MetaSkillVO> GetPetMetaSkillVOs(LocalSave.PetOne petOne)
	{
		return null;
	}

	public List<int> GetPetSkillIds(LocalSave.PetOne petOne)
	{
		return null;
	}

	public int GetUnlockIndex(int curLevel, int[] unlockLevels)
	{
		return 0;
	}

	public string[] GetSkillUpgradeAttr(BattlePetVO battlePet, Skill_skill skillData)
	{
		return null;
	}

	public BattlePetVO GetDebugBattlePetVO(int petId, int petStar, int petLevel)
	{
		return null;
	}

	public List<BattlePetVO.SkillVO> GetDebugSinglePetSkillVOs(LocalSave.PetOne petOne)
	{
		return null;
	}

	public (int, int, int) GetPetSkillCastCount()
	{
		return default;
	}
}
