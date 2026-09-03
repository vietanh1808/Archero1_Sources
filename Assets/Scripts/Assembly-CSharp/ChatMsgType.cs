using System;

[Flags]
public enum ChatMsgType
{
	Unknown = 0,
	Loading = 1,
	Guild = 2,
	Text = Loading | Guild,
	Smile = 4,
	Help = Loading | Smile,
	Gift = Guild | Smile,
	Combine = Text | Smile,
	Battle = 8,
	Chat = Loading | Battle
}
