using System.Collections.Generic;

public class PetSkillVO
{
	public class MetaSkillVO
	{
		public LocalSave.PetOne petOne;

		public int index;

		public int skillId;

		public int skillLevel => 0;
	}

	public PetManager manager;

	public PetSkillVO(PetManager petManager)
	{
	}

	public List<BattlePetVO.SkillVO> GetSkillVOsOfUpWarPets()
	{
		return null;
	}

	public List<BattlePetVO.SkillVO> GetSinglePetSkillVOs(LocalSave.PetOne petOne)
	{
		return null;
	}

	private int getInGameSkillId(LocalSave.PetOne petOne, MetaSkillVO metaSkillVO)
	{
		return 0;
	}

	private int getInGameSkillId(LocalSave.PetOne petOne, int petSkillId)
	{
		return 0;
	}
}
