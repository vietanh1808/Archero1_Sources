namespace TableTool
{
	public class PVEtalent_nodeModel : LocalModel<PVEtalent_node, int>
	{
		private const string _Filename = "PVEtalent_node";

		protected override string Filename => null;

		protected override int GetBeanKey(PVEtalent_node bean)
		{
			return 0;
		}
	}
}
