using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using XLua;

public class ActRedEnvelopeTab : MonoBehaviour
{
	public GameObject selectObj;

	public GameObject unSelectObj;

	public DxxText selectTex;

	public DxxText unSelectTex;

	public RedNodeCtrl redNode;

	public ButtonCtrl clickBtn;

	[CompilerGenerated]
	private Func<int, bool> m_ClickCallBack;

	private int Index;

	private static DelegateBridge __Hotfix0_add_ClickCallBack;

	private static DelegateBridge __Hotfix0_remove_ClickCallBack;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge __Hotfix0_Select;

	private static DelegateBridge _c__Hotfix0_ctor;

	public event Func<int, bool> ClickCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Init(int _index)
	{
	}

	public void OnLanguageChange(string desc)
	{
	}

	public void Click()
	{
	}

	public void Select(bool isSelect)
	{
	}
}
