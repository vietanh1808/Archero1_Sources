using System;
using UnityEngine;

public class CommonTipData
{
	public string title;

	public string contentText;

	public string btnName;

	public Action click;

	public Action open;

	public Action close;

	public Action info;

	public TextAnchor contentLayout;

	public static CommonTipData Create(string title, string contentText, string btnName, Action click, Action open, Action close, Action info, TextAnchor contentLayout = TextAnchor.MiddleCenter)
	{
		return null;
	}

	public static CommonTipData Create(string title, string contentText)
	{
		return null;
	}
}
