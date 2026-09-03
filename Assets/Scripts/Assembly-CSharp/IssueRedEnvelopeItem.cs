using System;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class IssueRedEnvelopeItem : MonoBehaviour
{
	public DxxText ReciveCountTex;

	public DxxText HaveCountTex;

	public Image icon1;

	public Image icon2;

	public ButtonCtrl clickBtn;

	public ActRedEnvelopeMgr.RedEnvelopeItem mData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Init(Action<ActRedEnvelopeMgr.RedEnvelopeItem> clickDo)
	{
	}

	public void Refresh(ActRedEnvelopeMgr.RedEnvelopeItem data)
	{
	}
}
