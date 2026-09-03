using System.Collections.Generic;
using TableTool;

public class WeaponSkinLevelUpRewardData
{
	public int Lv;

	public int RewardType;

	public Goods_goods.GoodData Attr;

	public Drop_DropModel.DropData Reward;

	public bool IsSpecial;

	public List<Drop_DropModel.DropData> Material;

	public int SkillID;

	public string SkillDes;
}
