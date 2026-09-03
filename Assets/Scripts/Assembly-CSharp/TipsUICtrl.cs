using DG.Tweening;
using UnityEngine;

public class TipsUICtrl : MonoBehaviour
{
	public RectTransform mTransform;

	public DxxText text1;

	public CanvasGroup canvasgroup;

	private const float time = 1.5f;

	private static Vector3 endpos;

	private Sequence seq;

	private const float longTime = 3.5f;

	public void Init(string value)
	{
	}

	public void Init(string value, Color color)
	{
	}

	public void InitNotAni(string value)
	{
	}

	public void Init()
	{
	}

	public void InitLongTime()
	{
	}
}
