using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuneTotalBlockCtrl : MonoBehaviour
{
	public DxxText title;

	public RuneTotalItemCtrl ItemCopy;

	public VerticalLayoutGroup LayoutGroup;

	public RectTransform BgTrans;

	private List<RuneTotalItemCtrl> items;

	private RuneGroup data;

	private const int headHeight = 100;

	private const int bgExtraHeight = 10;

	private float totalHeight;

	public void SetData(RuneGroup data)
	{
	}

	public float GetHeight()
	{
		return 0f;
	}
}
