public class StageBuyNotification
{
	public sealed class StageBuyCond
	{
		public bool IfNewRecord;

		public int NewStageId;
	}

	public CleverBuyType BuyType => CleverBuyType.none;

	public CleverShowType ShowType => CleverShowType.eDialog;
}
