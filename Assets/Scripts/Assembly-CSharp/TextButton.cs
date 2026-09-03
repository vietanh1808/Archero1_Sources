using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[AddComponentMenu("UI/TextButton", 10)]
[RequireComponent(typeof(RectTransform), typeof(CanvasRenderer), typeof(Image))]
public class TextButton : Button, ICanvasRaycastFilter
{
	public TextWithEvents targetText;

	private int hoverId;

	private Canvas canvasInParent;

	private CanvasScaler cScaler;

	private new void Start()
	{
	}

	protected override void DoStateTransition(SelectionState state, bool instant)
	{
	}

	private void InternalDoStateTransition(int id, SelectionState state, bool instant)
	{
	}

	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return false;
	}
}
