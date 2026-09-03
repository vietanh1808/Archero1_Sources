using System.Collections.Generic;

public sealed class EquipShopPushMgr
{
	public static EquipShopPushMgr Instance;

	private Dictionary<int, List<int>> equipIdToPushIds;

	static EquipShopPushMgr()
	{
	}

	private EquipShopPushMgr()
	{
	}

	public bool TryGetPushIdByEquipId(int equipId, out int pushId)
	{
		pushId = default;
		return false;
	}
}
