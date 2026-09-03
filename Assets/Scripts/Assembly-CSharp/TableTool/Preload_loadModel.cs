namespace TableTool
{
	public class Preload_loadModel : LocalModel<Preload_load, int>
	{
		private const string _Filename = "Preload_load";

		protected override string Filename => null;

		protected override int GetBeanKey(Preload_load bean)
		{
			return 0;
		}
	}
}
