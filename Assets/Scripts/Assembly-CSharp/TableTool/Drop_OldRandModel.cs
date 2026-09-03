namespace TableTool
{
	public class Drop_OldRandModel : LocalModel<Drop_OldRand, int>
	{
		private const string _Filename = "Drop_OldRand";

		protected override string Filename => null;

		protected override int GetBeanKey(Drop_OldRand bean)
		{
			return 0;
		}
	}
}
