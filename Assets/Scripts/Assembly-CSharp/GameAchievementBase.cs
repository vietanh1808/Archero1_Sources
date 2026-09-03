using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class GameAchievementBase
{
	public enum AchieveState
	{
		eLocked = 0,
		eUnlocked = 1,
		eFinished = 2,
		eClosed = 3
	}

	public class GameAchievementElement
	{
		public GameAchievementBase AchieveRoot;

		public Achieve_Achieve Data;

		public int AchieveId;

		public int Index;

		public AchieveState CurrentState;

		public int CurrentStep;

		public int TotalStep;

		private List<int> ShowImageTypeList;

		public bool IfFinish => false;

		public bool IfClosed => false;

		public bool IfUnlock => false;

		public bool IsNeedShowStar => false;

		public Sprite ShowImageIcon => null;

		public void Refresh()
		{
		}

		public void UpdateConditons()
		{
		}

		public string ToDebugString()
		{
			return null;
		}

		public List<Drop_DropModel.DropData> GetDrops()
		{
			return null;
		}

		public string GetTitle()
		{
			return null;
		}

		public bool IfUnlockModule(UnlockModule module)
		{
			return false;
		}
	}

	public int NotGetIndex;

	public bool IfUnlock;

	public List<GameAchievementElement> AchievementList;

	public virtual int TypeId { get; private set; }

	public GameAchievementElement GetFirstValid()
	{
		return null;
	}

	public virtual void UpdateElement(GameAchievementElement element)
	{
	}

	public virtual string GetTitle(GameAchievementElement element)
	{
		return null;
	}

	private int GetRealStar(int star)
	{
		return 0;
	}

	public virtual void Refresh()
	{
	}

	public virtual string ToDebugString()
	{
		return null;
	}
}
