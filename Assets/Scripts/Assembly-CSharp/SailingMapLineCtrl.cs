using System.Collections.Generic;
using UnityEngine;

public class SailingMapLineCtrl : MonoBehaviour
{
	public Transform goodParent;

	private List<SailingMapGoodCtrl> goods;

	[HideInInspector]
	public bool IsShip;

	[HideInInspector]
	public int lineIndex;

	public void Init(float[] args, int index)
	{
	}

	public int GetCountInLine()
	{
		return 0;
	}

	public void AddGood(SailingMapGoodCtrl good)
	{
	}

	public void OnCloseCtrl(SailingMapGoodCtrl good)
	{
	}

	public void OnInitGoodView(SailingMapGoodView view)
	{
	}

	public SailingMapGoodCtrl GetLastGood()
	{
		return null;
	}
}
