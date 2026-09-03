using System.Collections.Generic;
using UnityEngine;

public class VisionMistManager : Singleton<VisionMistManager>
{
	public enum MistPhase
	{
		None = 0,
		Delay = 1,
		FadeIn = 2,
		Active = 3,
		Cleared = 4
	}

	public const string TAG = "VisionMistManager";

	private const int CONFIG_FOG_DELAY = 3676;

	private const int CONFIG_FOG_FADE_DURATION = 3677;

	private const int CONFIG_INIT_VISION_RADIUS = 3678;

	private const int CONFIG_BRIGHT_CIRCLE_RADIUS = 3679;

	private const int CONFIG_VISION_SPEED = 3680;

	private const int CONFIG_VISION_MAX_COEFF = 3681;

	private const int CONFIG_ABSOLUTE_MISS = 3682;

	private bool _bActive;

	private float _fRoomStartTime;

	private float _fFogDelay;

	private float _fFogFadeDuration;

	private float _fInitVisionRadius;

	private float _fCurVisionRadius;

	private float _fMaxVisionRadius;

	private float _fVisionExpandSpeed;

	private float _fVisionShrinkSpeed;

	private float _fBrightCircleRadius;

	private Vector3 _vBrightCircleCenter;

	private float _fAbsoluteMissRate;

	private bool _bWasInBrightCircle;

	public Dictionary<int, bool> m_dictMistRooms;

	private MistPhase _phase;

	public MistPhase Phase => MistPhase.None;

	public float FogAlpha => 0f;

	public bool HaveVisionMistInCurRoom => false;

	public float CD => 0f;

	public bool IsActive => false;

	public float CurVisionRadius => 0f;

	public float BrightCircleRadius => 0f;

	public Vector3 BrightCircleCenter => default;

	public float AbsoluteMissRate => 0f;

	public bool ShowVisionMist => false;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void LoadConfigs()
	{
	}

	private float GetConfigFloat(int configId)
	{
		return 0f;
	}

	public void OnOpenDoor()
	{
	}

	public bool OnGotoNextDoorAfter()
	{
		return false;
	}

	public void OnRoomCleared()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	private void UpdateVisionRadius(float deltaTime)
	{
	}

	public bool IsInBrightCircle(Vector3 worldPos)
	{
		return false;
	}

	public bool IsInPlayerVision(Vector3 worldPos)
	{
		return false;
	}

	public bool IsVisible(Vector3 worldPos)
	{
		return false;
	}

	public bool CheckAbsoluteMiss(EntityBase target)
	{
		return false;
	}

	public void RegisterSilhouette(EntityBase entity)
	{
	}

	public void UnregisterSilhouette(EntityBase entity)
	{
	}

	public void ClearAllSilhouettes()
	{
	}

	private CameraVisionMistCtrl GetCameraCtrl()
	{
		return null;
	}

	private VisionMistCameraV2 GetCameraCtrlV2()
	{
		return null;
	}

	private void RandomBrightCirclePosition(int width, int height)
	{
	}

	private void RandomMistRoom(int nCurRoomId)
	{
	}

	private void AddMistRoom(int roomId, bool hasMist)
	{
	}
}
