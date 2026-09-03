namespace TableTool
{
	public class Sound_soundModel : LocalModel<Sound_sound, int>
	{
		private const string _Filename = "Sound_sound";

		protected override string Filename => null;

		protected override int GetBeanKey(Sound_sound bean)
		{
			return 0;
		}
	}
}
