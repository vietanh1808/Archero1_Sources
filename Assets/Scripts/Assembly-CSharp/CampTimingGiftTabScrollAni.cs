using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampTimingGiftTabScrollAni : MonoBehaviour
{
	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private CanvasGroup canvasGroup;

	private const float AniDuration = 0.3f;

	public const float LevelBtnWidth = 140f;

	public const float LevelBtnInterval = 8.1f;

	private static DelegateBridge __Hotfix0_Stop;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Stop()
	{
	}

	public void PlayAni(int level)
	{
	}
}
