using System.Collections.Generic;

public class ActionRotateEmerald
{
	private const string UPDATE_NAME = "ActionRotateEmerald-UPDATE";

	private const float EMERALD_RADIUS = 2.5f;

	private List<ActionBezierCurveForObj> bezierActionList;

	private float AddTime;

	private float AddTimeInterval;

	public EntityBase m_Entity;

	public float TotalTime;

	public int EmeraldCount;

	private bool emeraldsCreated;

	private bool emeraldsStarted;

	private int curEmeraldCount;

	private float curTime;

	private float lastTimeStamp;

	private float deltaScalePercent;

	private bool isInit;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void onChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void onEmeraldDestroyed(EntityEmerald emerald)
	{
	}

	private long GetRecoverHP()
	{
		return 0L;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void createEmeralds()
	{
	}
}
