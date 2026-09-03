namespace TableTool
{
	public class Manor_StealModel : LocalModel<Manor_Steal, int>
	{
		private const string _Filename = "Manor_Steal";

		protected override string Filename => null;

		protected override int GetBeanKey(Manor_Steal bean)
		{
			return 0;
		}
	}
}
