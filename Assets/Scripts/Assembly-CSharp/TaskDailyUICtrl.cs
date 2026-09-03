using System.Collections.Generic;
using Dxx.Net;
using Dxx.Util;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class TaskDailyUICtrl : MonoBehaviour
{
	[SerializeField]
	private DxxText XP_Text;

	[SerializeField]
	private Image XP_Image;

	[SerializeField]
	private Image Slider_Fill;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private XPBoxItem[] XPBoxItems;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private UISliderTween tween;

	[SerializeField]
	private TaskItemOne taskItem;

	[SerializeField]
	private AwardsItemOne awardItem;

	private bool addXp;

	private bool haveChange;

	private int battlePassXpCount;

	private int xp;

	private float itemHeight;

	private float contentHeight;

	private Achieve_DailyTask[] finishedTasks;

	private LocalUnityObjctPool mPool;

	private LocalUnityObjctPool cPool;

	private List<Achieve_DailyTaskReward> rewards;

	private readonly List<TaskItemOne> taskItems;

	private readonly SequencePool mSeqPool;

	private int curLevel;

	private long curDiamond;

	private bool interactable;

	private Dictionary<Achieve_DailyTask, int> taskToNum => null;

	private Dictionary<Achieve_DailyTask, int> availableTaskToNum => null;

	private List<Achieve_DailyTask> completedTasks => null;

	public void Init()
	{
	}

	public void OnDestroy()
	{
	}

	private void OnInitDailyTask()
	{
	}

	private void OnOpenDailyTask()
	{
	}

	private void OnCloseDailyTask()
	{
	}

	private void ShowDailyTask()
	{
	}

	private void ChangeDailyTask(Achieve_DailyTask[] claimedTasks)
	{
	}

	private void ShowXPBoxItem()
	{
	}

	private void Update()
	{
	}

	private float GetSliderValue()
	{
		return 0f;
	}

	public object OnGetEvent(string eventName)
	{
		return null;
	}

	public void UpdateGetReward()
	{
	}

	private void ChangeShowItem(Achieve_DailyTask[] tasks)
	{
	}

	private void UpdateSlider(int count, Achieve_DailyTask[] tasks)
	{
	}

	private Vector3 GetUseStartPos(CurrencyType type)
	{
		return default;
	}

	public void RequestTaskRewardAll()
	{
	}

	private void OnRequestTaskRewardAllResponse(NetResponse response)
	{
	}

	public void RequestChestRewardAll(int number)
	{
	}

	private void OnRequestChestRewardAllResponse(NetResponse response, int curLevel, long curDiamond, int number)
	{
	}

	public void HideAllXPBoxTipsExcept(XPBoxItem item)
	{
	}
}
