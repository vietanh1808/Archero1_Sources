public class EquipDoubleBuyNotification
{
	public sealed class EquipDoubleBuyCond
	{
		public bool IfNewRecord;

		public int StageId;
	}

	public class PromoteItem
	{
		public int id;

		public int num;
	}

	public class PromoteItemPlus
	{
		public int type;

		public int id;

		public int num;

		public int days;
	}

	public class IapInfo
	{
		public int iap_count;
	}
}
