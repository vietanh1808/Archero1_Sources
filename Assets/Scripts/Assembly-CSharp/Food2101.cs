public class Food2101 : FoodClearnessBase
{
	public bool CanShow { get; private set; }

	public override void SetCanShow(bool canShow = true)
	{
	}

	public override bool GetCanShow()
	{
		return false;
	}
}
