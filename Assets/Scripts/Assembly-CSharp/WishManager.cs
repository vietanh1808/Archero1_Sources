using System.Collections.Generic;

public sealed class WishManager : CInstance<WishManager>
{
	public class EquipWish
	{
		public int ID;

		public int LockLevel;

		public int Order;

		public int BoxRate;

		public int DropRate;

		public int DisplayRate;

		public int IfNew;

		public int IsReduce;

		public int BoxReduceRate;

		public int DropReduceRate;

		public int ReduceDisplayRate;
	}

	public List<int> wishedEquipList;

	public List<int> reducedEquipList;

	public List<EquipWish> downList;

	public bool haveGetServerData;

	public int[] LockLevel;

	public bool isReduce;

	public string tempConfigJosn;

	public void init()
	{
	}

	public bool isOpen()
	{
		return false;
	}

	public bool IsReduceOpen()
	{
		return false;
	}

	public int getReachLevel()
	{
		return 0;
	}

	public void requestList(int type, string s)
	{
	}

	public float getEquipWeight(int eid)
	{
		return 0f;
	}

	public bool isInWishEquipBox(int eid)
	{
		return false;
	}

	public bool getWishRedPointEquipShown(int level)
	{
		return false;
	}

	public void setWishRedPointEquipShown(int level)
	{
	}

	public bool GetWishEntranceShown(int level)
	{
		return false;
	}

	public void SetWishEntranceShown(int level)
	{
	}

	public bool GetReduceShown()
	{
		return false;
	}

	private void setReduceRedPointEntrance(int value)
	{
	}

	public bool getWishRedPointBattleShown()
	{
		return false;
	}

	public void setWishRedPointBattleShown()
	{
	}

	public bool canEquipRedPoint(int eid)
	{
		return false;
	}

	public void setEquipRedPointHaveShow()
	{
	}

	public bool AnyWishRedPointNotShown()
	{
		return false;
	}

	public void SetWishShown()
	{
	}

	public void SetReduceShown()
	{
	}

	public bool ShouldPopBeforeBattle()
	{
		return false;
	}
}
