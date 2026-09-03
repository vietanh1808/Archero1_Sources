namespace TableTool
{
	public class Manor_ManorLVModel : LocalModel<Manor_ManorLV, int>
	{
		private const string _Filename = "Manor_ManorLV";

		protected override string Filename => null;

		protected override int GetBeanKey(Manor_ManorLV bean)
		{
			return 0;
		}
	}
}
