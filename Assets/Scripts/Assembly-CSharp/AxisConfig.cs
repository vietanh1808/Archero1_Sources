using System;
using UnityEngine;

[Serializable]
public class AxisConfig
{
	[Header("显示设置")]
	public bool showAxis;

	public bool showTicks;

	public bool showLabels;

	[Header("样式设置")]
	public Color axisColor;

	public float axisThickness;

	public Sprite axisSprite;

	[Header("刻度设置")]
	public Color tickColor;

	public float tickLength;

	public float tickThickness;

	public Sprite tickSprite;

	[Header("标签设置")]
	public Color labelColor;

	public int labelFontSize;
}
