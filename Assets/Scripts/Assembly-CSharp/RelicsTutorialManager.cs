public class RelicsTutorialManager
{
	public const int GUIDE_SHOW_UNLOCK_POP = 1;

	public const int GUIDE_BTN_SHOP = 2;

	public const int GUIDE_BTN_RELIC_BOX = 3;

	public const int GUIDE_BTN_TALENT = 4;

	public const int GUIDE_BTN_RELIC = 5;

	public const string LOG_TAG = "[RelicsTutorial]";

	private static RelicsTutorialManager instance;

	private static object Locker;

	public static RelicsTutorialManager Instance => null;

	private void init()
	{
	}

	public bool IsCurGuide(int guideIndex)
	{
		return false;
	}

	public void FinishGuide(int guideIndex, bool force = false)
	{
	}

	public void FinishGuideWithMask(int guideIndex)
	{
	}

	public bool HasRelicBoxGuide()
	{
		return false;
	}

	public bool HasRelicEntryGuide()
	{
		return false;
	}

	public bool IsRelicGuideFinished()
	{
		return false;
	}

	public int GetCurGuideIndex()
	{
		return 0;
	}
}
