using System;
using UnityEngine;

public class SailingShipAttributeItem : MonoBehaviour
{
	public DxxImage imageLine;

	public DxxText textAtt;

	public DxxText textValue;

	public ButtonCtrl btn;

	public void Init(string att, string value, string desc, bool isShowLine = false, Action<Transform, string, bool> onClick = null)
	{
	}

	public void SetLineColor(Color lineColor)
	{
	}
}
