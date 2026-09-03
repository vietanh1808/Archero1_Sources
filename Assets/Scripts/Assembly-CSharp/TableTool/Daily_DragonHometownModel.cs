namespace TableTool
{
	public class Daily_DragonHometownModel : LocalModel<Daily_DragonHometown, int>
	{
		private const string _Filename = "Daily_DragonHometown";

		protected override string Filename => null;

		protected override int GetBeanKey(Daily_DragonHometown bean)
		{
			return 0;
		}
	}
}
