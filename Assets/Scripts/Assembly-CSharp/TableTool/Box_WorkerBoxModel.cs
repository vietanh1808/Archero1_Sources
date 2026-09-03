namespace TableTool
{
	public class Box_WorkerBoxModel : LocalModel<Box_WorkerBox, int>
	{
		private const string _Filename = "Box_WorkerBox";

		protected override string Filename => null;

		protected override int GetBeanKey(Box_WorkerBox bean)
		{
			return 0;
		}
	}
}
