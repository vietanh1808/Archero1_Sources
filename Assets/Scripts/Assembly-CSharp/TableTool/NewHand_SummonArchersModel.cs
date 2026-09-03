namespace TableTool
{
	public class NewHand_SummonArchersModel : LocalModel<NewHand_SummonArchers, int>
	{
		private const string _Filename = "NewHand_SummonArchers";

		protected override string Filename => null;

		protected override int GetBeanKey(NewHand_SummonArchers bean)
		{
			return 0;
		}
	}
}
