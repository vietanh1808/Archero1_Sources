using System.Collections.Generic;
using TableTool;
using UnityEngine;

public abstract class ChallengeModeBase
{
	private int _id;

	protected Stage_Level_activity mActivity;

	protected string mData;

	protected Transform mParent;

	private List<ChallengeConditionBase> mConditions;

	private PropType rewardtype;

	private int rewardid;

	private int rewardcount;

	private bool bMonsterHide;

	private float mHideRange;

	public int ID => 0;

	public bool RecoverHP { get; set; }

	public bool DropExp { get; set; }

	public bool AttackEnable { get; set; }

	public bool BombermanEnable { get; set; }

	public float BombermanTime { get; set; }

	public void Init(Stage_Level_activity activity)
	{
	}

	public void Start()
	{
	}

	protected abstract void OnStart();

	public void SetUIParent(Transform parent)
	{
	}

	public void SendEvent(string eventname, object body = null)
	{
	}

	protected virtual void OnSendEvent(string eventname, object body)
	{
	}

	public object GetEvent(string eventname)
	{
		return null;
	}

	protected virtual object OnGetEvent(string eventname)
	{
		return null;
	}

	protected abstract void OnInit();

	protected void OnFailure()
	{
	}

	protected void OnSuccess()
	{
	}

	public void DeInit()
	{
	}

	protected abstract void OnDeInit();

	private void InitRewards()
	{
	}

	public void GetRewards()
	{
	}

	public string GetSuccessString()
	{
		return null;
	}

	protected abstract string OnGetSuccessString();

	public List<string> GetConditions()
	{
		return null;
	}

	public void CheckCondition()
	{
	}

	public void MonsterDead()
	{
	}

	protected virtual void OnMonsterDead()
	{
	}

	public bool GetMonsterHide()
	{
		return false;
	}

	public void SetMonsterHide(float range)
	{
	}

	public float GetMonsterHideRange()
	{
		return 0f;
	}
}
