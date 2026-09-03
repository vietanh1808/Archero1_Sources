using TableTool;

public class SailingShipBattleAttributeItemData
{
	public SailingShipBattleFighter Fighter { get; set; }

	public int SlotPos { get; set; }

	public string AttrName { get; set; }

	public long AttrValue { get; set; }

	public Goods_goods.GoodData AttrGoodData => null;

	public bool IsAllAttr => false;

	public static SailingShipBattleAttributeItemData Create(SailingShipBattleFighter fighter, int slotPos, string attrName, long attrValue)
	{
		return null;
	}

	private Goods_goods.GoodData GetAttrGoodData()
	{
		return null;
	}
}
