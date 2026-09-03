using System.Collections.Generic;
using ThinkingAnalytics;
using UnityEngine;

public class TAExample : MonoBehaviour, IDynamicSuperProperties
{
	public GUISkin skin;

	private Vector2 scrollPosition;

	private static Color MainColor;

	private static Color TextColor;

	private static int Margin;

	private static int Height;

	private static float ContainerWidth;

	public Dictionary<string, object> GetDynamicSuperProperties()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnGUI()
	{
	}
}
