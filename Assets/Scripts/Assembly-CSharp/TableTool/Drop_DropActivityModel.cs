namespace TableTool
{
	public class Drop_DropActivityModel : LocalModel<Drop_DropActivity, int>
	{
		private const string _Filename = "Drop_DropActivity";

		protected override string Filename => null;

		protected override int GetBeanKey(Drop_DropActivity bean)
		{
			return 0;
		}
	}
}
