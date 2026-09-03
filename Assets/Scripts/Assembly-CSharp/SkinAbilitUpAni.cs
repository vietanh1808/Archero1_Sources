using System;
using DG.Tweening;
using UnityEngine;
using XLua;

public class SkinAbilitUpAni : MonoBehaviour
{
	[SerializeField]
	private SkinAbilityAttrItemAni attackAttr;

	[SerializeField]
	private SkinAbilityAttrItemAni bloodAttr;

	private Sequence sequence;

	private Action onComplete;

	private static DelegateBridge __Hotfix0_PlaAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void PlaAni(float startAttack, float endAttack, float startBlood, float endBlood, Action onComplete)
	{
	}

	public void StopAni()
	{
	}
}
