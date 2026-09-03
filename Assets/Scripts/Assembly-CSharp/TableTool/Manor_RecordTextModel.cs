namespace TableTool
{
	public class Manor_RecordTextModel : LocalModel<Manor_RecordText, int>
	{
		private const string _Filename = "Manor_RecordText";

		protected override string Filename => null;

		protected override int GetBeanKey(Manor_RecordText bean)
		{
			return 0;
		}
	}
}
