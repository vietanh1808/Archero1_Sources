using System.Collections.Generic;
using UnityEngine;

public class ActionPortal
{
	public EntityBase m_Entity;

	private const int EFFECT_SKILL_ALONE_ID = 1127;

	private const string UPDATE_NAME = "ActionPortal-Update";

	private const string TIMER_NAME = "ActionPortal-Timer";

	private const float TIME_INTERVAL = 0.5f;

	private const float MONSTER_RADIUS = 6f;

	private int timerId;

	private int curPortalCount;

	private bool canCreatePortal;

	private bool allPortalsCreated;

	private List<Vector2Int> AllPortalGrids;

	private List<GoodVirtualDragonPortalCtrl> m_listPortals;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void onTimer()
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room obj)
	{
	}

	private void onUpdate(float deltaTime)
	{
	}

	private void addPortalGrid(Vector2Int colRow)
	{
	}

	private List<Vector2Int> clone(List<Vector2Int> value)
	{
		return null;
	}

	private void populateAllPortalGrids()
	{
	}

	private bool isBeyondGridRadius(Vector2Int colRow, int portalRadius)
	{
		return false;
	}

	public void Start()
	{
	}

	private void createSinglePortal()
	{
	}

	private GoodVirtualDragonPortalCtrl getBestPortal(GoodVirtualDragonPortalCtrl startCtrl)
	{
		return null;
	}

	private List<Vector2Int> getValidPortalGridList(List<Vector2Int> _list)
	{
		return null;
	}

	private void OnTriggerPortal(GoodVirtualDragonPortalCtrl one, GoodVirtualDragonPortalCtrl two)
	{
	}

	private void InitDragonPortals()
	{
	}

	private void AddDragonPortal(GoodVirtualDragonPortalCtrl ctrl)
	{
	}

	public List<GoodVirtualDragonPortalCtrl> GetDragonPortals()
	{
		return null;
	}

	private void EnableAllDragonPortals()
	{
	}

	private void RemovePortals()
	{
	}
}
