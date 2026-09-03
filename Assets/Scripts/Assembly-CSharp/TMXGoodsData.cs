public class TMXGoodsData
{
	public const int PVP_GRASS_ID = 2016;

	public TMXGoodsType Type;

	public TMXGoodsParentType ParentType;

	private int TypeId;

	public int GoodsID;

	public int x;

	public int y;

	public TMXGoodsData()
	{
	}

	public TMXGoodsData(int goodsid, int typeid)
	{
	}

	public void SetGoodsId(int goodsid)
	{
	}

	public void Init(int typeid)
	{
	}

	public bool IsEmpty()
	{
		return false;
	}

	public bool IsPvpGrass()
	{
		return false;
	}
}
