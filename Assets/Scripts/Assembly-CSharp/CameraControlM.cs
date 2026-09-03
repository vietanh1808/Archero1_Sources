using System;
using UnityEngine;

public class CameraControlM : PauseObject
{
	public enum FollowType
	{
		eFormal = 0,
		eFree = 1,
		eFroze = 2,
		eCenter = 3
	}

	public enum ViewType
	{
		eFormal = 0,
		ePerspective = 1
	}

	public static CameraControlM Instance;

	public static FollowType CameraFollow;

	public static ViewType CameraView;

	private EntityBase target;

	private float m_fScale;

	private const float Speed = 30f;

	private float speed;

	[SerializeField]
	private float minx;

	[SerializeField]
	private float maxx;

	[SerializeField]
	private float miny;

	[SerializeField]
	private float maxy;

	private const float OffsetY = -5f;

	private int RoomStateBoss;

	private float RoomStateBoss_Time;

	private Camera m_Camera;

	private Camera m_FormalCamera;

	private Camera m_MeadowBattleCamera;

	private Camera m_PerspectiveCamera;

	private float mCameraStartSize;

	private CameraStartCtrl mStartCtrl;

	public const float CameraStartSize = 6f;

	public const float CameraEndSize = 10.5f;

	[SerializeField]
	private Camera uiCamera;

	private bool isPosInit;

	private Vector3 startPos;

	private Vector3 startRot;

	private bool isInit;

	public Camera FormalCamera => null;

	public Camera MeadowBattleCamera => null;

	private EntityBase GetTarget()
	{
		return null;
	}

	private void Start()
	{
	}

	private void InitCamera()
	{
	}

	public void Revert(bool pRev)
	{
	}

	public void DeInit()
	{
	}

	public void SetTarget(EntityBase entity)
	{
	}

	public void SetViewType(ViewType viewType)
	{
	}

	public void ResetCameraSize()
	{
	}

	private void RemoveStartAnimate()
	{
	}

	public void PlayStartAnimate(Action callback = null)
	{
	}

	private void LateUpdate()
	{
	}

	private void Update_Running()
	{
	}

	private void Update_Runnings()
	{
	}

	public void SetCameraRound()
	{
	}

	public Vector3 GetClampCameraPos(Vector3 pos)
	{
		return default;
	}

	public void ResetCameraPosition()
	{
	}

	public void SetCameraSpeed(float speed)
	{
	}

	public void ResetCameraSpeed()
	{
	}

	public void SetCameraPosition(Vector3 pos)
	{
	}

	public Vector3 GetCameraPosition()
	{
		return default;
	}

	public Vector3 GetCameraEndPosition()
	{
		return default;
	}

	public void CameraPositionZero()
	{
	}

	public void SetCurrentRoom(int roomid)
	{
	}

	public void FrozeCamera()
	{
	}

	public void SetCameraPos(Vector3 pos)
	{
	}

	public void ResetCameraFollowType()
	{
	}

	public void ResetCameraFollowType(int roomdId)
	{
	}

	public float GetScaleFactor()
	{
		return 0f;
	}

	private bool use15Times21CameraSize()
	{
		return false;
	}

	public void SetCameraFree(float s, int roomdId)
	{
	}
}
