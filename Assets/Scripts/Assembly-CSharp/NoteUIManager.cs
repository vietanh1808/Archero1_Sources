using System.Collections.Generic;

public sealed class NoteUIManager
{
	private static NoteUIManager instance;

	private static object Locker;

	public bool isHavePullNote;

	public List<NoteItemData> notesList;

	public static NoteUIManager Instance => null;

	private void init()
	{
	}

	public void pullNoteList()
	{
	}

	private long GetTimeStamp(string times)
	{
		return 0L;
	}

	public int getNotReadNoteNum()
	{
		return 0;
	}
}
