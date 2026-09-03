using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainChapterCtrl : MonoBehaviour
{
	public GameObject copychapter;

	public ScrollRectBase mScrollRect;

	public ButtonCtrl Button_Left;

	public ButtonCtrl Button_Right;

	public GridLayoutGroup mLayoutGroup;

	public Action OnStageUpdate;

	private LocalUnityObjctPool mPool;

	private List<MainUILevelItem> mList;

	private int currentstage;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private void OnClickItem()
	{
	}

	private void update_current()
	{
	}

	private void update_button()
	{
	}
}
