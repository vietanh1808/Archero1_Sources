using System.Collections.Generic;

public class LevelProgressTipVO
{
	public class BoxChapterVO
	{
		public int Layer;

		public int RoomId;

		public int Level;

		public bool HasGotBoxReward()
		{
			return false;
		}
	}

	public List<BoxChapterVO> BoxChapterList;

	private int curStartLevel;

	private int curMaxLevel;

	private bool isInitialized;

	private BoxChapterVO createBoxChapterVO(int layer, int level)
	{
		return null;
	}

	public BoxChapterVO GetBoxChapterVO(int roomId)
	{
		return null;
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}
}
