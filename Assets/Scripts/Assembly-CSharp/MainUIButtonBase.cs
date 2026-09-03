using System;
using UnityEngine;
using XLua;

public abstract class MainUIButtonBase : MonoBehaviour
{
	[SerializeField]
	private float Height;

	[SerializeField]
	private int m_nLayoutPriority;

	private static DelegateBridge __Hotfix0_get_LayoutPriority;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnAdd;

	private static DelegateBridge __Hotfix0_GetHeight;

	private static DelegateBridge __Hotfix0_OnDisable;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_isRed;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int LayoutPriority => 0;

	public abstract bool IsShow();

	[Obsolete("4.0.0废弃该方法，显示顺序由LayoutPriority控制")]
	public abstract int GetPriority();

	public abstract RectTransform GetTransform();

	public abstract long GetOpenTime();

	public virtual void OnLanguageChange()
	{
	}

	public virtual void OnAdd()
	{
	}

	public virtual float GetHeight()
	{
		return 0f;
	}

	private void OnDisable()
	{
	}

	public void Close()
	{
	}

	protected virtual void OnClose()
	{
	}

	public virtual bool isRed()
	{
		return false;
	}

	public virtual void UpdateUI()
	{
	}
}
