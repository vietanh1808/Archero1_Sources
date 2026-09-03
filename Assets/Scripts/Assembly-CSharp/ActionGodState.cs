using UnityEngine;

public class ActionGodState
{
	private const string TAG = "ActionGodState";

	private const string UPDATE_NAME = "ActionGodState-UPDATE";

	public string ExternalTag;

	public EntityBase m_Entity;

	public int BuffId;

	public float FlashChainInterval;

	public FlashChainArgs FlashChainArgs;

	public float AliveTime;

	private ConditionTime flashChainTime;

	private ConditionTime timeInterval;

	private GameObject goEffect;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void onUpdate(float delta)
	{
	}

	private void sendBuff()
	{
	}

	private void removeBuff()
	{
	}

	private void initEffect()
	{
	}

	private void deinitEffect()
	{
	}

	private void updateFlashChain()
	{
	}
}
