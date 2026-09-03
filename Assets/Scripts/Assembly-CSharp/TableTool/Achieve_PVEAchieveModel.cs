namespace TableTool
{
	public class Achieve_PVEAchieveModel : LocalModel<Achieve_PVEAchieve, int>
	{
		private const string _Filename = "Achieve_PVEAchieve";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_PVEAchieve bean)
		{
			return 0;
		}
	}
}
