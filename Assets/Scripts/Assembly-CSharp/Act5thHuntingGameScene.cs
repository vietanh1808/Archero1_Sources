using System;
using UnityEngine;

public class Act5thHuntingGameScene : MonoBehaviour
{
	[SerializeField]
	private Act5thHuntingGameSceneTrigger sceneTrigger;

	[SerializeField]
	private RectTransform sceneTriggerRect;

	public void Refresh(Action<Vector2> pointerClick)
	{
	}

	public RectTransform GetSceneTriggerRect()
	{
		return null;
	}
}
