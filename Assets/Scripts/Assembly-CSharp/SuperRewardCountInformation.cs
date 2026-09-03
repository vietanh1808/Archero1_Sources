using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class SuperRewardCountInformation : MonoBehaviour
{
	public RectTransform tipPosition;

	public RectTransform tipBg;

	public RectTransform tipBgTip;

	protected const int GRID_X_LEFT = 60;

	protected const int GRID_X_RIGHT = 60;

	protected const int GRID_Y_TOP = 50;

	protected const int GRID_Y_BOTTOM = 60;

	protected const int GRID_X_SIZE = 120;

	protected const int GRID_Y_SIZE = 120;

	protected const int GRID_X_SPACING = 5;

	protected const int GRID_Y_SPACING = 5;

	protected const int MARGIN_X_LEFT = 0;

	protected const int MARGIN_X_RIGHT = 0;

	protected const int SCREEN_WIDTH = 720;

	protected const int PANEL_MIN_WIDTH = 250;

	protected const int PANEL_MAX_WIDTH = 720;

	protected const int MIN_COUNT_IN_ROW = 1;

	protected const int MAX_COUNT_IN_ROW = 4;

	protected const int TIP_LEFT_POS = 120;

	protected const int TIP_RIGHT_POS = 40;

	private Vector3 prePoint;

	private LocalUnityObjctPool mPool;

	protected List<PropOneEquip> props;

	public void Init()
	{
	}

	public void OnClick()
	{
	}

	public virtual void DecideShow(Vector3 point, List<Drop_DropModel.DropData> rewards)
	{
	}

	public virtual void OnLanguageChange()
	{
	}
}
