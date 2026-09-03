using Habby.Guild.Data;

public class ChatMsgDataChat : ChatMsgDataBase
{
	public int chatId;

	public int grade;

	public string text;

	public bool translated;

	public bool appealed;

	public bool complainted;

	public GuildMessageEntity gme;
}
