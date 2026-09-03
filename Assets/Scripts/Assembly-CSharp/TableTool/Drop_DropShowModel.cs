namespace TableTool
{
	public class Drop_DropShowModel : LocalModel<Drop_DropShow, int>
	{
		private const string _Filename = "Drop_DropShow";

		protected override string Filename => null;

		protected override int GetBeanKey(Drop_DropShow bean)
		{
			return 0;
		}
	}
}
