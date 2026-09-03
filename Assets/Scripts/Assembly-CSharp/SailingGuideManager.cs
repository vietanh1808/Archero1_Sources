using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TableTool;

public class SailingGuideManager
{
	public enum GuideModule
	{
		None = 0,
		TreasureMap = 1,
		FirstVoyage = 2,
		ShipLevelUp = 3,
		ShipLevelUp2 = 4,
		Salvage = 5,
		MonsterIsland = 6,
		GhostFleet = 7,
		ArenaIcon = 8,
		ArenaUI = 9,
		MonsterBossShow = 10,
		MonsterBossAttack = 11,
		MonsterIsland2 = 12,
		DeepSeaMonster = 13
	}

	public class GuideDataOne
	{
		private int stepCount;

		private int[] _windowIds;

		private int[] _focusOnWindowIds;

		private static Dictionary<int, int> m_dicGuideSchedules;

		public int groupId { get; private set; }

		public string ModuleName => null;

		public bool Auto { get; private set; }

		public int dependencyId { get; private set; }

		public string DependencyName => null;

		public int windowId => 0;

		public int FocusOnWindowId => 0;

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

		public bool IsUnGuided => false;

		public ShipBattle_NewHand NextGuideConfig => null;

		public GuideDataOne(int _groupId)
		{
		}

		public void CheckReOrder()
		{
		}
	}

	public const int GuideIdBase = 3000;

	private static SailingGuideManager instance;

	[CompilerGenerated]
	private Func<GuideModule, bool> m_OnGuideCheckEvent;

	public static SailingGuideManager Instance => null;

	public GuideDataOne CurGuide { get; private set; }

	public event Func<GuideModule, bool> OnGuideCheckEvent
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

	private bool InvokeOnGuideCheckEvent(GuideModule guideModule)
	{
		return false;
	}

	private SailingGuideManager()
	{
	}

	private GuideDataOne ShowGuide(GuideDataOne data)
	{
		return null;
	}

	public GuideDataOne ShowGuide(GuideModule module)
	{
		return null;
	}

	public void StopGuide()
	{
	}

	public int GetGuideCurStep(GuideModule module)
	{
		return 0;
	}

	private void OnGuideEnd()
	{
	}

	private void OnShowWindowAction(WindowID obj)
	{
	}

	private void OnShowWindowEnd(WindowID id)
	{
	}

	private void OnCloseWindowAction(WindowID obj)
	{
	}

	private void CheckGuide(int id)
	{
	}

	[Conditional("EnableLog")]
	private void Log(string log)
	{
	}

	[Conditional("EnableLog")]
	private void LogWarning(string warning)
	{
	}

	[Conditional("EnableLog")]
	private void LogError(string error)
	{
	}
}
