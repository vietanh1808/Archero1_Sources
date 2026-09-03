public abstract class MaterialBuyNotification
{
	public abstract CleverBuyType BuyType { get; }

	public CleverShowType ShowType => CleverShowType.eDialog;

	protected abstract bool RateDebug();
}
