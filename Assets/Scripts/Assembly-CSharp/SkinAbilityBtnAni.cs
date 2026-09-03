using System;
using DG.Tweening;
using UnityEngine;
using XLua;

public class SkinAbilityBtnAni : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup canvasGroup;

	private Sequence sequence;

	private Tweener tweener;

	private Action onComplete;

	private static DelegateBridge __Hotfix0_PlayShowAni;

	private static DelegateBridge __Hotfix0_PlayHideAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void PlayShowAni(Action onComplete)
	{
	}

	public void PlayHideAni()
	{
	}

	public void StopAni()
	{
	}
}
