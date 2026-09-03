using System.Collections.Generic;
using UnityEngine;

public class SailingRankShowItem : MonoBehaviour
{
	public ButtonCtrl btnRank;

	public List<SailingRankHeadItem> rankList;

	public SailingRankHeadItem myRank;

	private RankType _rType;

	public void Init(List<SailingRankShowItemData> data, RankType rType)
	{
	}

	public void Close()
	{
	}
}
