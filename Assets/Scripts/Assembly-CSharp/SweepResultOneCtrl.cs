using System.Collections.Generic;
using Dxx.Util;
using TableTool;
using UnityEngine;

public class SweepResultOneCtrl : MonoBehaviour
{
	public UILineCtrl lineCtrl;

	public RectTransform content;

	public GameObject iconObj;

	private LocalUnityObjctPool mPool;

	private SequencePool mSeqPool;

	private const int LineCount = 5;

	private const float WidthOne = 136f;

	private const float HeightOne = 136f;

	private void Awake()
	{
	}

	public void initProps(List<Drop_DropModel.DropData> datas)
	{
	}

	public void initEggs(Dictionary<int, int> datas, Color c)
	{
	}

	public void initMonsters(Dictionary<int, int> datas, Color c)
	{
	}
}
