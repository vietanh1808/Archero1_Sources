namespace TableTool
{
	public class Guild_RedEnvelopeModel : LocalModel<Guild_RedEnvelope, int>
	{
		private const string _Filename = "Guild_RedEnvelope";

		protected override string Filename => null;

		protected override int GetBeanKey(Guild_RedEnvelope bean)
		{
			return 0;
		}
	}
}
