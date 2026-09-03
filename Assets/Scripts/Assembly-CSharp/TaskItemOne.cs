using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class TaskItemOne : MonoBehaviour
{
	public GameObject completedAward_bg;

	public GameObject fill;

	public ButtonCtrl FinishTask_Button;

	public ButtonCtrl ToFinishTask_Button;

	public Slider slider;

	public DxxText awardstext;

	public DxxImage completeImage;

	public DxxText taskText;

	public DxxText finishText;

	public DxxText finishTaskText;

	public DxxText toFinishText;

	public Image Slider_Progress;

	private int count;

	private bool interactable;

	private TaskDailyUICtrl ctrl;

	public Achieve_DailyTask dailyTask { get; private set; }

	private void Awake()
	{
	}

	public void Init(Achieve_DailyTask task, int num, TaskDailyUICtrl tdCtrl)
	{
	}

	public void InitFinishTask(Achieve_DailyTask task)
	{
	}

	private void SetAvailable()
	{
	}

	private void SetGot()
	{
	}

	private void SetUnavailable()
	{
	}

	private void ChangeLanguage()
	{
	}
}
