using UnityEngine;

public class VisionMistCtrlV2
{
	private const string TAG = "VisionMistCtrlV2";

	private readonly VisionMistManager _manager;

	private VisionMistCameraV2 _cameraCtrl;

	private GameObject _brightCircleEffect;

	private VisionMistManager.MistPhase _lastPhase;

	private const int BRIGHT_CIRCLE_EFFECT_ID = 3000058;

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

	public void OnRoomCleared()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void CreateBrightCircleEffect()
	{
	}

	private void ClearEffects()
	{
	}
}
