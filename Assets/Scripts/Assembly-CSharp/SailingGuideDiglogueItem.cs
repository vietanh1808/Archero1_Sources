using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SailingGuideDiglogueItem : SailingGuideItemBase, IPointerDownHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private new Action m_OnEndCallBack;

	public Image leftImage;

	public Image rightImage;

	public TypewriterEffect TypeWriter;

	public GameObject leftName;

	public GameObject rightName;

	public GameObject arrow;

	public DxxText leftNameTex;

	public DxxText rightNameTex;

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

	protected override void OnInit()
	{
	}

	public override GuideType GetGuideType()
	{
		return GuideType.dialogue;
	}

	protected override void OnOpen()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}
}
