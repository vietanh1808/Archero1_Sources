using System.Collections.Generic;
using UnityEngine;

public class ToxicfogCtrl
{
	private const string TAG = "ToxicfogCtrl";

	private const int GOOD_ID = 3001;

	private LocalUnityObjctPool _pool;

	private ToxicfogManager _toxicfogManager;

	private List<Transform> _lsitFogs;

	private List<Vector3> _listFogStartPoses;

	private float _fTime;

	private const float INTERVAL = 0.1f;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void OnOpenDoor()
	{
	}

	public void OnCacheLastRoomMapBefore()
	{
	}

	public void OnGotoNextDoorAfter()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void CreateToxicFogInGrid(int x, int y)
	{
	}
}
