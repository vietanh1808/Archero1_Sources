using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TableTool;

public class CommonGuideManager
{
	public enum GuideEnum
	{
		BraveCampStart = 1,
		BraveCampPanel = 2,
		TotemSystemStar = 3,
		NewWorldComics = 4,
		AlarRelics = 5,
		PushPillarChoice = 6,
		PushPillarPlay = 7,
		PushPillarRefresh = 8,
		ChapterGift = 9
	}

	public class CommonGuideData
	{
		private int stepCount;

		private List<NewHand_SummonArchers> showGuideList;

		public int groupId { get; private set; }

		public virtual int Schedule
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

		public CommonGuideData(int _groupId)
		{
		}

		public List<NewHand_SummonArchers> GetShowGuideList()
		{
			return null;
		}

		private List<NewHand_SummonArchers> GetGuideList()
		{
			return null;
		}
	}

	public class ActivityGuideData : CommonGuideData
	{
		private int ActivityTag;

		public override int Schedule
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ActivityGuideData(int _activityTag, int _groupId)
			: base(0)
		{
		}
	}

	public class SeverGuideData : CommonGuideData
	{
		public const int GuideIdBase = 4000;

		public override int Schedule
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public SeverGuideData(int _groupId)
			: base(0)
		{
		}
	}

	public const string GuideKey = "CommonGuideKey";

	private static CommonGuideManager instance;

	private CommonGuideData CurGuide;

	public Action<int> OnGroupGuideEnd;

	[CompilerGenerated]
	private Action<CommonGuideData, int> m_OnStartGuideStep;

	[CompilerGenerated]
	private Action<CommonGuideData, int> m_OnEndGuideStep;

	public static CommonGuideManager Instance => null;

	public event Action<CommonGuideData, int> OnStartGuideStep
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<CommonGuideData, int> OnEndGuideStep
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private CommonGuideManager()
	{
	}

	private void OnShowWindowAction(WindowID iD)
	{
	}

	private void OnCloseWindowAction(WindowID iD)
	{
	}

	public void StartGuide(GuideEnum guideEnum)
	{
	}

	public void StopGuide()
	{
	}

	public int GetGuideSchedule(GuideEnum guideEnum)
	{
		return 0;
	}

	public bool GetGuideIsComplete(GuideEnum guideEnum)
	{
		return false;
	}

	public void StartGuideStep(CommonGuideData guideData, int step)
	{
	}

	public void EndGuideStep(CommonGuideData guideData, int step)
	{
	}

	private CommonGuideData GetGuideData(GuideEnum guideEnum)
	{
		return null;
	}
}
