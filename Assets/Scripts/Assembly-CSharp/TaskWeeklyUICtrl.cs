using System.Collections.Generic;
using Dxx.Util;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class TaskWeeklyUICtrl : MonoBehaviour
{
	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private TaskRewardBox[] boxItems;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private UISliderTween tween;

	[SerializeField]
	private WeeklyTaskItemOne taskItem;

	[SerializeField]
	private DxxText txtDesc;

	private LocalUnityObjctPool mPool;

	private LocalUnityObjctPool cPool;

	private List<WeeklyTaskItemOne> tList;

	private SequencePool mSeqPool;

	private float contentHeight;

	private bool haveChange;

	private Achieve_WeeklyTask finishTask;

	private float itemHeight;

	private float countDown;

	[SerializeField]
	private Sprite green;

	[SerializeField]
	private Sprite blue;

	[SerializeField]
	private Image sliderFill;

	private List<Achieve_WeeklyTaskReward> rewardList => null;

	private Dictionary<Achieve_WeeklyTask, int> canCompleteTaskDic => null;

	private Dictionary<Achieve_WeeklyTask, int> taskDic => null;

	private List<Achieve_WeeklyTask> completedTasks => null;

	private int finishedTaskCount => 0;

	public void Init()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnInitWeeklyTask()
	{
	}

	private void OnOpenWeeklyTask()
	{
	}

	public void ShowBoxItems()
	{
	}

	public void HideAllXPBoxTipsExcept(TaskRewardBox item)
	{
	}

	private void Update()
	{
	}

	public void UpdateGetReward()
	{
	}

	private void ChangeShowItem(Achieve_WeeklyTask task)
	{
	}

	private void ChangeWeeklyTask(Achieve_WeeklyTask task)
	{
	}

	public void UpdateSlider(Achieve_WeeklyTask weeklyTask)
	{
	}

	private void OnCloseWeeklyTask()
	{
	}

	private void ShowWeeklyTask()
	{
	}

	private float GetSliderValue()
	{
		return 0f;
	}
}
