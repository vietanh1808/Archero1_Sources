namespace TableTool
{
	public class Wings_AnimationModel : LocalModel<Wings_Animation, int>
	{
		private const string _Filename = "Wings_Animation";

		protected override string Filename => null;

		protected override int GetBeanKey(Wings_Animation bean)
		{
			return 0;
		}
	}
}
