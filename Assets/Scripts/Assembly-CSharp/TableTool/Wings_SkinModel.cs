namespace TableTool
{
	public class Wings_SkinModel : LocalModel<Wings_Skin, int>
	{
		private const string _Filename = "Wings_Skin";

		protected override string Filename => null;

		protected override int GetBeanKey(Wings_Skin bean)
		{
			return 0;
		}
	}
}
