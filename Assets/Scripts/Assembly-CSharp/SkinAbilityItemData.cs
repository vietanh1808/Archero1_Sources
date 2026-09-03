using TableTool;
using XLua;

public class SkinAbilityItemData
{
	private static DelegateBridge __Hotfix0_get_SkinID;

	private static DelegateBridge __Hotfix0_set_SkinID;

	private static DelegateBridge __Hotfix0_get_CurLevel;

	private static DelegateBridge __Hotfix0_set_CurLevel;

	private static DelegateBridge __Hotfix0_get_EffectDesc;

	private static DelegateBridge __Hotfix0_set_EffectDesc;

	private static DelegateBridge __Hotfix0_get_IsUnlock;

	private static DelegateBridge __Hotfix0_get_NeedLevel;

	private static DelegateBridge __Hotfix0_get_GoodData;

	private static DelegateBridge __Hotfix0_get_GoodShowData;

	private static DelegateBridge __Hotfix0_get_IsAllHeroAttr;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_GetNeedLevel;

	private static DelegateBridge __Hotfix0_GetGoodData;

	private static DelegateBridge __Hotfix0_GetGoodShowData;

	private static DelegateBridge __Hotfix0_GetIsAllHeroAttr;

	private static DelegateBridge _c__Hotfix0_ctor;

	private int SkinID { get; set; }

	private int CurLevel { get; set; }

	private string EffectDesc { get; set; }

	public bool IsUnlock => false;

	public int NeedLevel => 0;

	public Goods_goods.GoodData GoodData => null;

	public Goods_goods.GoodShowData GoodShowData => null;

	public bool IsAllHeroAttr => false;

	public static SkinAbilityItemData Create(int skinID, int curLevel, string effectDesc)
	{
		return null;
	}

	private int GetNeedLevel()
	{
		return 0;
	}

	private Goods_goods.GoodData GetGoodData()
	{
		return null;
	}

	private Goods_goods.GoodShowData GetGoodShowData()
	{
		return null;
	}

	private bool GetIsAllHeroAttr()
	{
		return false;
	}
}
