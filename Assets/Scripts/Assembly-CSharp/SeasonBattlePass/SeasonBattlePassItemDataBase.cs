using UnityEngine;

namespace SeasonBattlePass
{
	public class SeasonBattlePassItemDataBase
	{
		public Vector3 localPosition;

		public Vector2 size;

		public SeasonBattlePassItemBase itemCtl;

		public SeasonBattlePassCtl uiCtl;

		public int Index { get; private set; }

		public bool IsLock { get; protected set; }

		public bool isShow { get; protected set; }

		public SeasonBattlePassItemDataBase(int pIndex, Vector2 pSize)
		{
		}

		public virtual void SetData(SeasonBattlePassData pData)
		{
		}

		public virtual bool HasReward()
		{
			return false;
		}

		public virtual void Show(bool pShow)
		{
		}

		public virtual bool IsGotPayItemReward()
		{
			return false;
		}
	}
}
