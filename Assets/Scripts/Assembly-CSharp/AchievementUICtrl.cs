using System.Collections.Generic;
using Dxx.Util;
using TableTool;
using UnityEngine;

public class AchievementUICtrl : MonoBehaviour
{
	public GameAchievementItem CopyOne;

	public GameAchievementInfinity Infinity;

	public GameAchievementManager AchievementMgr;

	public List<GameAchievementBase.GameAchievementElement> ValidList;

	public GameObject GameAchievementPart;

	private LocalUnityObjctPool mPool;

	private LocalUnityObjctPool cPool;

	private List<Achieve_DailyTaskReward> rewardlist;

	private Dictionary<Achieve_DailyTask, int> cancompletetaskdic;

	private Dictionary<Achieve_DailyTask, int> taskdic;

	private List<Achieve_DailyTask> completedtask;

	private List<TaskItemOne> tlist;

	private SequencePool mSeqPool;

	private float height;

	private static int xp;

	private static bool haveChange;

	private static Achieve_DailyTask finishtask;

	private float itemheight;

	private float countdown;

	public void init()
	{
	}

	protected void OnInit()
	{
	}

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	private void OnInitAchievement()
	{
	}

	private void OnOpenAchievement()
	{
	}

	private void UpdateList()
	{
	}

	private void UpdateChildCallBack(int index, GameAchievementItem one)
	{
	}
}
