namespace TableTool
{
	public class Achieve_AchieveModel : LocalModel<Achieve_Achieve, int>
	{
		private const string _Filename = "Achieve_Achieve";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_Achieve bean)
		{
			return 0;
		}
	}
}
