namespace TableTool
{
	public class Beat_beatModel : LocalModel<Beat_beat, int>
	{
		private const string _Filename = "Beat_beat";

		protected override string Filename => null;

		protected override int GetBeanKey(Beat_beat bean)
		{
			return 0;
		}

		public string GetBeat(int layer)
		{
			return null;
		}

		private Beat_beat GetBeatOne(long score, int start, int end)
		{
			return null;
		}
	}
}
