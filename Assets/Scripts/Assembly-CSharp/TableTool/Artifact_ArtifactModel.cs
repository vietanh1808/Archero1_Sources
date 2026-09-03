namespace TableTool
{
	public class Artifact_ArtifactModel : LocalModel<Artifact_Artifact, int>
	{
		private const string _Filename = "Artifact_Artifact";

		protected override string Filename => null;

		protected override int GetBeanKey(Artifact_Artifact bean)
		{
			return 0;
		}
	}
}
