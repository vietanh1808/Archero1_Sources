using System.Collections.Generic;
using TableTool;

public class PetAttrVO
{
	private SelfAttributeData selfAttributeData;

	private PetManager manager;

	private float helpWarPetFactor;

	public PetAttrVO(PetManager petManager)
	{
	}

	private void initConfig()
	{
	}

	public void SetSelfAttributeData(SelfAttributeData selfAttributeData)
	{
	}

	public Dictionary<string, Goods_goods.GoodData> GetPetAttrDictWithPreprocessAttr()
	{
		return null;
	}

	public Dictionary<string, Goods_goods.GoodData> GetPetAttrDictWithoutPreprocessAttr()
	{
		return null;
	}

	public List<int> GetPetStarSkillIds()
	{
		return null;
	}

	public List<Goods_goods.GoodData> GetAllPetBasicAttr()
	{
		return null;
	}

	private List<Goods_goods.GoodData> getPreprocessedSinglePetAttr(LocalSave.PetOne petOne)
	{
		return null;
	}

	private bool isPreprocessedAttr(Goods_goods.GoodData one)
	{
		return false;
	}

	private bool isSinglePetBasicAttrUpPercent(Goods_goods.GoodData one)
	{
		return false;
	}

	private List<Goods_goods.GoodData> getPetAttrsWithPreprocess()
	{
		return null;
	}

	private List<Goods_goods.GoodData> getPetAttrsWithoutPreprocess()
	{
		return null;
	}

	private Dictionary<string, Goods_goods.GoodData> mergeAttrList(List<Goods_goods.GoodData> list)
	{
		return null;
	}

	private void modifyNonAllPetDict(ref Dictionary<string, Goods_goods.GoodData> dict, LocalSave.PetOne petOne)
	{
	}

	private List<Goods_goods.GoodData> getSinglePetAttrOnesWithoutPreprocess(List<Goods_goods.GoodData> list, LocalSave.PetOne petOne, bool exclude = true)
	{
		return null;
	}

	private float getAttrValue(List<Goods_goods.GoodData> list, string attr)
	{
		return 0f;
	}

	private List<Goods_goods.GoodData> getSingleUpWarPetAttrOnes(LocalSave.PetOne petOne)
	{
		return null;
	}

	private List<Goods_goods.GoodData> getSingleHelpWarPetAttrOnes(LocalSave.PetOne petOne)
	{
		return null;
	}

	private List<Goods_goods.GoodData> getSingleNonWarPetAttrOnes(LocalSave.PetOne petOne)
	{
		return null;
	}

	private List<int> getSinglePetStarSkillIds(LocalSave.PetOne petOne)
	{
		return null;
	}

	private List<Goods_goods.GoodData> getSinglePetBasicAttrs(LocalSave.PetOne petOne)
	{
		return null;
	}

	private List<Goods_goods.GoodData> getSinglePetStarAttrs(LocalSave.PetOne petOne)
	{
		return null;
	}

	private List<Goods_goods.GoodData> getSinglePetLevelAttrs(LocalSave.PetOne petOne)
	{
		return null;
	}

	private List<Goods_goods.GoodData> getSinglePetSkillAttrs(LocalSave.PetOne petOne)
	{
		return null;
	}

	private float getLevelCoefficient(Pet_Pet meta, Pet_UpGrade upGradeMeta)
	{
		return 0f;
	}

	private float getStarCoefficient(Pet_Pet meta, Pet_UpStar upStarMeta)
	{
		return 0f;
	}

	private void printAttrInfo(List<Goods_goods.GoodData> list, string Tag, string Desc = "")
	{
	}
}
