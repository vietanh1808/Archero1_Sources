using Dxx.Util;
using UnityEngine;

public class NewPlay125GuideUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private RectTransform particleParentRect;

	[SerializeField]
	private RectTransform pointParentRect;

	[SerializeField]
	private RectTransform pointRect;

	[SerializeField]
	private RectTransform guideContent;

	private SequencePool sequencePool;

	private (Vector2, Vector2) guidePos;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void StepGuideAni(Vector2 startPos, Vector2 endPos)
	{
	}
}
