using System.Collections.Generic;
using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class BraveCampRankPart : MonoBehaviour
{
	public ScrollRect scrollRect;

	public RectTransform itemParent;

	public BraveCampRankItem copyOne;

	public DxxText descText;

	[Header("左边距离")]
	public float left;

	[Header("上边距离")]
	public float top;

	[Header("左右间隔")]
	public float spaceX;

	[Header("上下间隔")]
	public float spaceY;

	[Header("元素宽度")]
	public float cellWidth;

	[Header("元素高度")]
	public float cellHight;

	[Header("每行个数")]
	public int rowCount;

	private List<BraveCampRankItem> rankItems;

	private Dictionary<int, STActivitySummonArchersRank> pairs;

	private TimeLineContainer timeLine;

	public void Init()
	{
	}

	public void Open(int rewardId)
	{
	}

	private void Refresh(STActivitySummonArchersRank rankData)
	{
	}

	public void Close()
	{
	}
}
