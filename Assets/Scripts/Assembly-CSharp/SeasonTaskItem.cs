using UnityEngine;
using UnityEngine.UI;

public class SeasonTaskItem : MonoBehaviour
{
	public GameObject completedAward_bg;

	public ButtonCtrl Btn;

	public Slider slider;

	public DxxImage completeImage;

	public DxxText taskText;

	public DxxText progressText;

	public DxxText btnText;

	public Image Slider_Progress;

	public PropOneEquip prop;

	public DxxImage Image_Left;

	public DxxImage Image_ItemBg;

	private SeasonTaskUi _taskUi;

	public SeasonTaskMgr.SeasonTaskNode _task { get; private set; }

	public void Init(SeasonTaskMgr.SeasonTaskNode task, SeasonTaskUi taskUi)
	{
	}

	public void SetData(SeasonTaskMgr.SeasonTaskNode task)
	{
	}

	private void Refresh()
	{
	}

	public void OnLanguageChange()
	{
	}
}
