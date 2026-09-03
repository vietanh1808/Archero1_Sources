public class OfficialPayEntanceMgr
{
	public class OfficialPayEntanceConfig
	{
		public int Tag;

		public int Version;

		public long OpenTime;

		public long EndTime;

		public int Animation;
	}

	private static OfficialPayEntanceMgr instance;

	public OfficialPayEntanceConfig[] S3Config;

	public const string guideKey = "OfficialPayEntanceGuide";

	public static OfficialPayEntanceMgr Instance => null;

	public OfficialPayEntanceConfig S3BaseConfig => null;

	public bool isOpen => false;

	public long StartTime => 0L;

	public long EndTime => 0L;

	public long leftTime => 0L;

	public int Tag => 0;

	public bool Animation => false;

	private OfficialPayEntanceMgr()
	{
	}

	public void ReqS3()
	{
	}

	private void ParseJson()
	{
	}

	public bool isRed()
	{
		return false;
	}

	public void SetClicked()
	{
	}
}
