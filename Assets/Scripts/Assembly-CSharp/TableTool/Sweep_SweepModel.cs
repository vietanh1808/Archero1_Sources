namespace TableTool
{
	public class Sweep_SweepModel : LocalModel<Sweep_Sweep, int>
	{
		private const string _Filename = "Sweep_Sweep";

		protected override string Filename => null;

		protected override int GetBeanKey(Sweep_Sweep bean)
		{
			return 0;
		}
	}
}
