using TableTool;

public class CampGuideManager
{
	public class CampGuideData
	{
		private int stepCount;

		public int groupId { get; private set; }

		public int Schedule
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsComplete => false;

		public SLG_NewHand NextGuideConfig => null;

		public CampGuideData(int _groupId)
		{
		}
	}

	public const int GuideIdBase = 1000;

	private static CampGuideManager instance;

	public static CampGuideManager Instance => null;

	public CampGuideData CurGuide { get; private set; }

	private CampGuideManager()
	{
	}

	public void ShowGuide(int groupId)
	{
	}

	public void StopGuide()
	{
	}

	private void OnGuideEnd()
	{
	}

	private void OnShowWindowAction(WindowID obj)
	{
	}

	private void OnCloseWindowAction(WindowID obj)
	{
	}

	private void OnClickTitleBtn(int titleId, int operate)
	{
	}
}
