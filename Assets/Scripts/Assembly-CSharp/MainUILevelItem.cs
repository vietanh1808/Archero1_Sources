using System;
using System.Collections.Generic;
using UnityEngine;

public class MainUILevelItem : MonoBehaviour
{
	public ButtonCtrl Button_Click;

	public GameObject stageparent;

	public Action OnButtonClick;

	public NewWorldEffect newWorldEffect;

	private int stageId;

	private int stageChapterId;

	private GameObject stageitem;

	private long mCount;

	private List<Color> mHeroColors;

	private TimeLineContainer timeLine;

	private bool isInit;

	public static bool isGuild;

	public int StageID => 0;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void Init(int stageId, int stageChapterId = 0)
	{
	}

	private void InitStage()
	{
	}

	public void RefreshEfect()
	{
	}

	private void OnDestroy()
	{
	}

	private void Guild(CommonGuideManager.CommonGuideData guideData, int step)
	{
	}

	private void StopGuild(CommonGuideManager.CommonGuideData guideData, int step)
	{
	}
}
