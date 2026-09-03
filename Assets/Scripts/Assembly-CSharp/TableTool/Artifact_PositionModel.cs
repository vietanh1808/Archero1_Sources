namespace TableTool
{
	public class Artifact_PositionModel : LocalModel<Artifact_Position, int>
	{
		private const string _Filename = "Artifact_Position";

		protected override string Filename => null;

		protected override int GetBeanKey(Artifact_Position bean)
		{
			return 0;
		}
	}
}
