namespace TableTool
{
	public class Achieve_CelebrationModel : LocalModel<Achieve_Celebration, int>
	{
		private const string _Filename = "Achieve_Celebration";

		protected override string Filename => null;

		protected override int GetBeanKey(Achieve_Celebration bean)
		{
			return 0;
		}
	}
}
