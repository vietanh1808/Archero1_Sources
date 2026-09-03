using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
[AddComponentMenu("UI/TextWithEvents", 12)]
[RequireComponent(typeof(RectTransform), typeof(CanvasRenderer))]
public class TextWithEvents : Text
{
	[TextArea(3, 10)]
	[SerializeField]
	private string nonParsedStr;

	public AnimationCurve m_CurveData;

	public float curveMultiplier;

	public RectTransform rectT;

	public static int lastClickedIndex;

	public Dictionary<string, List<Link>> linksList;

	private StringBuilder sb;

	private StringBuilder tempShowString;

	private string[] splittedStr;

	private static Regex _regex;

	public new string text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool onlyColorChanged { get; set; }

	protected override void OnEnable()
	{
	}

	private string RemoveInvisibleCharacters(string inputString)
	{
		return null;
	}

	public string RemoveTags(string inputString)
	{
		return null;
	}

	private string OnBeforeValueChange(string strToParse)
	{
		return null;
	}

	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}
}
