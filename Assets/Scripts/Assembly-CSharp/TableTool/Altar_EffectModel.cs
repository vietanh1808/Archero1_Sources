namespace TableTool
{
	public class Altar_EffectModel : LocalModel<Altar_Effect, int>
	{
		private const string _Filename = "Altar_Effect";

		protected override string Filename => null;

		protected override int GetBeanKey(Altar_Effect bean)
		{
			return 0;
		}
	}
}
