namespace TableTool
{
	public class Badge_BaseModel : LocalModel<Badge_Base, int>
	{
		private const string _Filename = "Badge_Base";

		protected override string Filename => null;

		protected override int GetBeanKey(Badge_Base bean)
		{
			return 0;
		}
	}
}
