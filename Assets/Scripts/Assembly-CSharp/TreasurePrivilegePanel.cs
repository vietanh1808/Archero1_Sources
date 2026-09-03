using System.Collections.Generic;
using UnityEngine;

public class TreasurePrivilegePanel : MonoBehaviour
{
	public DxxText titleText;

	public DxxText subTitleText;

	public ButtonCtrl closeBtn;

	public ButtonCtrl bgBtn;

	public InfiniteListView levelListView;

	public RectTransform sliderFill;

	public RectTransform sliderBg;

	public RectTransform taskParent;

	public TreasureTaskItem taskItemTemplate;

	public RectTransform privilegeParent;

	public TreasurePrivilegeItem privilegeItemTemplate;

	private int selectedLevel;

	private List<TreasurePrivilegeItem> privilegeItems;

	private List<ViewCellData> showList;

	public void Init()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void Refresh()
	{
	}

	private void RefreshLevelProgress()
	{
	}

	public void SelectLevel(int level)
	{
	}

	private void RefreshTasks(int level)
	{
	}

	private void RefreshPrivileges(int level)
	{
	}

	public void OnLanguageChange()
	{
	}
}
