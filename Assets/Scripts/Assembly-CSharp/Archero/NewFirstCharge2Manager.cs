using System;

namespace Archero
{
	public sealed class NewFirstCharge2Manager : CInstance<NewFirstCharge2Manager>
	{
		public const int ConfigID = 5018;

		public bool isFailureFromBattle;

		public NewFirstChargeData2 Data { get; private set; }

		public void OnNewFirstChargeConfigDownload()
		{
		}

		public new void Clear()
		{
		}

		public bool IsOpen()
		{
			return false;
		}

		public bool IsBuyTimeOver()
		{
			return false;
		}

		public bool Paid(int actIndex)
		{
			return false;
		}

		public void SetPaid(int actIndex)
		{
		}

		public bool IsAllPaid()
		{
			return false;
		}

		public bool HasAnyPaid()
		{
			return false;
		}

		public int LoginDays(int actIndex)
		{
			return 0;
		}

		public bool CanClaim(int actIndex, int dayCount)
		{
			return false;
		}

		public bool Claimed(int actIndex, int dayCount)
		{
			return false;
		}

		public bool ClaimedAll(int actIndex)
		{
			return false;
		}

		public bool ClaimedAll()
		{
			return false;
		}

		public int ClaimableIndex(int actIndex)
		{
			return 0;
		}

		public bool HasClaimable(int actIndex)
		{
			return false;
		}

		public long Time2NextClaim(int actIndex, int dayCount)
		{
			return 0L;
		}

		public void RequestNewFirstCharge2(bool showMask, int type, int actIndex = 0, int day = 0, Action callBack = null)
		{
		}

		public void ShowPopping()
		{
		}

		public bool CanPopping()
		{
			return false;
		}

		public bool IsAllowPopping()
		{
			return false;
		}

		public bool HavePopping()
		{
			return false;
		}

		public bool CanRepeatPopping()
		{
			return false;
		}

		public bool IsAllowRepeatPopping()
		{
			return false;
		}

		public bool NewTryPop()
		{
			return false;
		}
	}
}
