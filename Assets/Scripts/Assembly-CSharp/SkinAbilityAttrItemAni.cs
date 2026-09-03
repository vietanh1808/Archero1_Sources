using DG.Tweening;
using UnityEngine;
using XLua;

public class SkinAbilityAttrItemAni : MonoBehaviour
{
	[SerializeField]
	private Animator upAni;

	[SerializeField]
	private DxxText attrValue;

	private Tweener tweener;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge _c__Hotfix0_ctor;

	public Tweener PlayAni(float startValue, float endValue)
	{
		return null;
	}

	public void StopAni()
	{
	}
}
