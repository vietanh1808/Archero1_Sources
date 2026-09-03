using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ActiveOneCtrl : MonoBehaviour
{
	public DxxText Text_Name;

	public Image Image_Icon;

	public DxxText Text_Count;

	public Stage_Level_activityModel.ActivityTypeData activedata { get; private set; }

	public void Init(Stage_Level_activityModel.ActivityTypeData one)
	{
	}
}
