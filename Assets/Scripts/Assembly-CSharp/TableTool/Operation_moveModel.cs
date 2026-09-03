namespace TableTool
{
	public class Operation_moveModel : LocalModel<Operation_move, int>
	{
		private const string _Filename = "Operation_move";

		protected override string Filename => null;

		protected override int GetBeanKey(Operation_move bean)
		{
			return 0;
		}
	}
}
