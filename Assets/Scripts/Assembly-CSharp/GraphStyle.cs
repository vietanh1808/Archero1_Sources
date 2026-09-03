using System;
using UnityEngine;

[Serializable]
public class GraphStyle
{
	[Header("点样式")]
	public Sprite pointSprite;

	public Color pointColor;

	public Vector2 pointSize;

	public bool showPoints;

	[Header("线样式")]
	public Sprite lineSprite;

	public Color lineColor;

	public float lineThickness;

	public bool showLines;

	[Header("X轴设置")]
	public AxisConfig xAxisConfig;

	[Header("Y轴设置")]
	public AxisConfig yAxisConfig;

	[Header("Y轴标签格式")]
	public string pricePrefix;

	public int priceDecimalPlaces;
}
