using System;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SailingGuideButtonItem : SailingGuideItemBase
{
	[CompilerGenerated]
	private new Action m_OnEndCallBack;

	private ButtonCtrl[] Btns;

	private Button[] Btns2;

	private GraphicRaycaster RaycastInCanvas;

	private bool isCheck;

	private EventSystem eventSystem;

	public override event Action OnEndCallBack
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

	public override GuideType GetGuideType()
	{
		return GuideType.dialogue;
	}

	protected override void OnOpen()
	{
	}

	public void Click()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
