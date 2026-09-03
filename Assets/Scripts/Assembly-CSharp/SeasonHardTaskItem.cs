using UnityEngine;
using UnityEngine.UI;

public class SeasonHardTaskItem : MonoBehaviour
{
	public ButtonCtrl Btn;

	public ButtonCtrl Btn_Unfinish;

	public DxxImage completeImage;

	public DxxText taskText;

	public DxxText progressText;

	public DxxText btnText;

	public DxxText btnUnfinishText;

	public PropOneEquip prop;

	public RectTransform propParent;

	public ScrollRect Scroll;

	private SeasonHardTaskUI _taskUi;

	private LocalUnityObjctPool _pool;

	private bool _isInit;

	public SeasonTaskMgr.SeasonTaskNode _task { get; private set; }

	public void Init(SeasonTaskMgr.SeasonTaskNode task, SeasonHardTaskUI taskUi)
	{
	}

	public void SetData(SeasonTaskMgr.SeasonTaskNode task)
	{
	}

	private void Refresh()
	{
	}

	private void RefreshRewards()
	{
	}

	private void OnButtonGetClick()
	{
	}

	public void OnLanguageChange()
	{
	}
}
