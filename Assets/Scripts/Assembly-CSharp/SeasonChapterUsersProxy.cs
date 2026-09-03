using PureMVC.Patterns;

public class SeasonChapterUsersProxy : Proxy
{
	public class Transfer
	{
		public int m_nChapterId;
	}

	public new const string NAME = "SeasonChapterUsersProxy";

	public SeasonChapterUsersProxy(object data)
	{
	}
}
