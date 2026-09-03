using UnityEngine;

public class SeasonBattlePassItemBase : MonoBehaviour
{
	public RectTransform rectTrans;

	public bool IsLock { get; protected set; }

	public int Index { get; protected set; }

	public virtual void Init()
	{
	}

	public virtual void SetData(SeasonBattlePassData pData, int pIndex)
	{
	}

	public virtual void OnLanguageChange()
	{
	}

	public virtual void RestUI()
	{
	}

	public virtual bool HasReward()
	{
		return false;
	}

	public virtual bool IsGotPayItemReward()
	{
		return false;
	}
}
