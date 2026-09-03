using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI.CoroutineTween;

[Serializable]
public class Link : UIBehaviour
{
	private Color linkColor;

	[SerializeField]
	[HideInInspector]
	private TextWithEvents targetText;

	[HideInInspector]
	public int[] linkStartAt;

	[HideInInspector]
	public int[] linkStartAtInShownText;

	public TweenRunner<ColorTween> ColorTweener;

	public void SetColor(Color color)
	{
	}

	private string ColorToHex(Color32 color)
	{
		return null;
	}

	private new void Awake()
	{
	}

	public void CrossFadeColor(Color targetColor, bool ignoreTimeScale, bool useAlpha, bool useRGB)
	{
	}

	public void Reset()
	{
	}
}
