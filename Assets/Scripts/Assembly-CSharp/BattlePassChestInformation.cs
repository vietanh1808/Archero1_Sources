using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class BattlePassChestInformation : MonoBehaviour
{
	public enum TipPosition
	{
		LEFT = 0,
		CENTER = 1,
		RIGHT = 2
	}

	public RectTransform tipPosition;

	public RectTransform tipBg;

	public RectTransform tipBgTip;

	public DxxText textTitle;

	public BattlePass_ChestPropOne propTemplate;

	public Action<bool> onShow;

	protected List<BattlePass_ChestPropOne> props;

	protected const int GRID_X_LEFT = 60;

	protected const int GRID_X_RIGHT = 60;

	protected const int GRID_Y_TOP = 70;

	protected const int GRID_Y_BOTTOM = 60;

	protected const int GRID_X_SIZE = 120;

	protected const int GRID_Y_SIZE = 120;

	protected const int GRID_X_SPACING = 5;

	protected const int GRID_Y_SPACING = 5;

	protected const int MARGIN_X_LEFT = 100;

	protected const int MARGIN_X_RIGHT = 100;

	protected const int SCREEN_WIDTH = 720;

	protected const int PANEL_MIN_WIDTH = 250;

	protected const int PANEL_MAX_WIDTH = 520;

	protected const int MIN_COUNT_IN_ROW = 1;

	protected const int MAX_COUNT_IN_ROW = 3;

	protected const int TIP_LEFT_POS = 100;

	protected const int TIP_RIGHT_POS = 50;

	public int xLeftOffset;

	public int xCenterOffset;

	public int xRightOffset;

	public void OnClick()
	{
	}

	protected int SelectStep(int[] steps)
	{
		return 0;
	}

	public void InitPosition(TipPosition tipPos, Vector3 point, int giftBoxId, bool headUp = true)
	{
	}

	public void InitChainGiftPosition(TipPosition tipPos, Vector3 point, List<string> rewardList, bool headUp = true)
	{
	}

	public void InitBubble(TipPosition tipPos, Vector3 point, string[] rewards, string tipTex, bool headUp = true)
	{
	}

	public bool DecideShow(TipPosition tipPos, Vector3 point, string data)
	{
		return false;
	}

	public bool DecideShow(TipPosition tipPosition, Vector3 point, Drop_DropModel.DropData data)
	{
		return false;
	}

	public void DecideChainGiftShow(TipPosition tipPosition, Vector3 point, List<string> data)
	{
	}
}
