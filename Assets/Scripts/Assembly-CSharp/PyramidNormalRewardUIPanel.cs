using System.Collections.Generic;
using UnityEngine;

public class PyramidNormalRewardUIPanel : MonoBehaviour
{
	[SerializeField]
	private DxxText text_Title;

	[SerializeField]
	private ButtonCtrl btn_Close;

	public PyramidPreviewRewardItem cellItem;

	public RectTransform rt_Content;

	public ScrollRectBase scroll;

	private List<int> dataList;

	private LocalUnityObjctPool pool;

	private ActPyramidTreasureMgr ptMgr => null;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void OnOpen()
	{
	}

	public void InitRewardItems()
	{
	}

	private void Esc()
	{
	}

	public void OnBtnCloseClick()
	{
	}
}
