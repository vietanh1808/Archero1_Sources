using UnityEngine;
using UnityEngine.UI;
using XLua;

public class AdHarvestLevelScrollAni : MonoBehaviour
{
	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private CanvasGroup canvasGroup;

	private const float AniDuration = 0.3f;

	public const float LevelBtnWidth = 157.4638f;

	public const float LevelBtnInterval = 15.8f;

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
