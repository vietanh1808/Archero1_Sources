namespace TableTool
{
	public class Fishing_TimeModel : LocalModel<Fishing_Time, int>
	{
		private const string _Filename = "Fishing_Time";

		protected override string Filename => null;

		protected override int GetBeanKey(Fishing_Time bean)
		{
			return 0;
		}
	}
}
