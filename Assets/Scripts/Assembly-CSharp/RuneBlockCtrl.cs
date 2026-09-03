using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuneBlockCtrl : MonoBehaviour
{
	public static readonly float HeadHeight;

	public static readonly float BeginPosY;

	public static readonly float DeltaPosY;

	public static readonly float EndPosY;

	public RuneItemCtrl2 RuneItemCopy;

	public RuneGroup RuneData;

	public Image RuneIcon;

	public Text RuneTitle;

	private List<RuneItemCtrl2> RuneItems;

	public RectTransform BgTrans;

	private float totalHeight;

	public bool IfAutoLayout { get; set; }

	public float GetTotalHeight()
	{
		return 0f;
	}

	public void SetData(RuneGroup data)
	{
	}

	public void UpdateUI()
	{
	}
}
