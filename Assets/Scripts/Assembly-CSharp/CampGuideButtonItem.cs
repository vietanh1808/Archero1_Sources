using System;
using System.Runtime.CompilerServices;

public class CampGuideButtonItem : CampGuideItemBase
{
	[CompilerGenerated]
	private new Action m_OnEndCallBack;

	private ButtonCtrl[] Btns;

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

	public override CampGuideType GetGuideType()
	{
		return CampGuideType.dialogue;
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
}
