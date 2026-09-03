namespace TableTool
{
	public class SLG_TreasureBoxModel : LocalModel<SLG_TreasureBox, int>
	{
		private const string _Filename = "SLG_TreasureBox";

		protected override string Filename => null;

		protected override int GetBeanKey(SLG_TreasureBox bean)
		{
			return 0;
		}
	}
}
