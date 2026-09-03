public class Food3201 : FoodClearnessBase
{
	public bool CanShow { get; private set; }

	public override void SetCanShow(bool canShow = true)
	{
	}

	public override bool GetCanShow()
	{
		return false;
	}

	protected override void SetPropClearness(BattlePropClearness clearness)
	{
	}
}
