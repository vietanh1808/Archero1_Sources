namespace TableTool
{
	public class Guild_MessageEmojiModel : LocalModel<Guild_MessageEmoji, int>
	{
		private const string _Filename = "Guild_MessageEmoji";

		protected override string Filename => null;

		protected override int GetBeanKey(Guild_MessageEmoji bean)
		{
			return 0;
		}
	}
}
