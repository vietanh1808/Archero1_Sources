using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class WeeklyTaskItemOne : MonoBehaviour
{
	[SerializeField]
	private GameObject completedAward_bg;

	[SerializeField]
	private GameObject fill;

	[SerializeField]
	private GameObject goCompleteMask;

	[SerializeField]
	private ButtonCtrl FinishTask_Button;

	[SerializeField]
	private ButtonCtrl ToFinishTask_Button;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private RectTransform rewardRoot;

	[SerializeField]
	private DxxText awardstext;

	[SerializeField]
	private DxxText taskText;

	[SerializeField]
	private DxxText finishText;

	[SerializeField]
	private DxxText finishTaskText;

	[SerializeField]
	private DxxText toFinishText;

	[SerializeField]
	private DxxImage completeImage;

	[SerializeField]
	private Image Slider_Progress;

	[SerializeField]
	private Sprite blue;

	[SerializeField]
	private Sprite green;

	[SerializeField]
	private PropOneEquip rewardItem;

	public Achieve_WeeklyTask task;

	private int count;

	private bool finish;

	private bool canClick;

	private string sourceName => null;

	public void Init(Achieve_WeeklyTask task, int num, TaskWeeklyUICtrl tdCtrl)
	{
	}

	public void InitFinishTask(Achieve_WeeklyTask task)
	{
	}

	private void SetCanGet()
	{
	}

	private void SetGot()
	{
	}

	private void SetCanNotGet()
	{
	}

	private void OnLanguageChange()
	{
	}
}
