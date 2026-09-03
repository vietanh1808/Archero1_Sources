using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class HarvestTaskItemCell : UITableViewCell
{
	public GameObject completedAward_bg;

	public ButtonCtrl FinishTask_Button;

	public DxxText completeText;

	public DxxText taskText;

	public DxxText finishTaskText;

	public DxxText underWayText;

	public GameObject underWay;

	public Slider slider;

	public PropOneEquip[] props;

	private int taskId;

	public void Init(int tid)
	{
	}

	private void onButtonClick()
	{
	}
}
