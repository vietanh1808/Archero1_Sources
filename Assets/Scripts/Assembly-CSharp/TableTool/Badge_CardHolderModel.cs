namespace TableTool
{
	public class Badge_CardHolderModel : LocalModel<Badge_CardHolder, int>
	{
		private const string _Filename = "Badge_CardHolder";

		protected override string Filename => null;

		protected override int GetBeanKey(Badge_CardHolder bean)
		{
			return 0;
		}
	}
}
