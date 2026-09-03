using System;
using System.Collections.Generic;

public class ActNewReChargeManager
{
	public class ActivityChargeRewardData
	{
		public long activityEndTime;

		public long activityAllEndTime;

		public ActivityChargeItem[] showItems;

		public int TotalCharge;

		public List<int> receiveDayCount;

		public int tag;

		public bool IsOpen => false;

		public bool IsNeedChargeCount => false;

		public bool GetIsHasGetById(int id)
		{
			return false;
		}

		public bool GetIsCanGetById(int id)
		{
			return false;
		}

		public bool GetIsCanShowById(int id)
		{
			return false;
		}

		public ActivityChargeItem GetChargeItem(int id)
		{
			return null;
		}
	}

	public class ActivityChargeItem
	{
		public int id;

		public int show_cond;

		public int[][] reward;

		public int param;
	}

	public class ActivitySingleCharge
	{
		public long activityEndTime;

		public Dictionary<int, int> RewardGetCount;

		public ActivitySingleChargeItem[] chargeItems;

		public int Tag;

		public bool isOpen => false;

		public int GetIsHasGetById(int id)
		{
			return 0;
		}

		public bool GetIsCanShowById(int id)
		{
			return false;
		}

		public ActivitySingleChargeItem GetChargeItem(int id)
		{
			return null;
		}
	}

	public class ActivitySingleChargeItem
	{
		public int id;

		public int show_cond;

		public string Product_id;

		public int Quota;

		public int[][] Optional;

		public int discount;
	}

	public class ActivityChargeDayRewardData
	{
		public long activityEndTime;

		public long activityAllEndTime;

		public ActivityChargeItem[] showItems;

		public bool TodayIsComplete;

		private int toDayTotalCharge;

		public int CompleteDayCount;

		public List<int> receiveDayCount;

		public ushort[] dayNeedRecharge;

		public int tag;

		public bool IsOpen => false;

		public bool IsNeedChargeCount => false;

		public int TaDayTotalCharge
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int CurDay => 0;

		public int ToDayRewardId => 0;

		public bool GetIsHasGetById(int id)
		{
			return false;
		}

		public bool GetIsCanGetById(int id)
		{
			return false;
		}

		public int GetToDayNeedCharge()
		{
			return 0;
		}

		public int GetToDayNeedChargeDay()
		{
			return 0;
		}

		public ActivityChargeItem GetChargeItem(int id)
		{
			return null;
		}

		public int GetNeedCharge(int day)
		{
			return 0;
		}
	}

	private static ActNewReChargeManager instance;

	private static object Locker;

	public ActivityChargeRewardData activityChargeReward;

	public ActivitySingleCharge activitySingleCharge;

	public ActivityChargeDayRewardData activityChargeDayReward;

	public static ActNewReChargeManager Instance => null;

	public bool ChargeRewardIsOpen => false;

	public bool ChargeRewardIsNeedCount => false;

	public bool AnyRechargeCanGet => false;

	public long ChargeRewardTimeDown => 0L;

	public bool SingleChargeIsOpen => false;

	public long SingleChargeTimeDown => 0L;

	public bool ChargeRewardDayIsOpen => false;

	public bool ChargeRewardDayIsNeedCount => false;

	public bool AnyRechargeDayCanGet => false;

	public long ChargeDayRewardTimeDown => 0L;

	public void RequestReCharge()
	{
	}

	public void ReceviceReChargeReward(int id, Action CallBack)
	{
	}

	public void RequestSingleCharge()
	{
	}

	public void RequestReChargeDay()
	{
	}

	public void ReceviceReChargeDayReward(int id, Action CallBack)
	{
	}

	public void ResetChargeDay()
	{
	}

	public void Clear()
	{
	}
}
