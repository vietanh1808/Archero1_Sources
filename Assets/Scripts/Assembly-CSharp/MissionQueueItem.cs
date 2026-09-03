using UnityEngine;
using UnityEngine.UI;

public class MissionQueueItem : MonoBehaviour
{
	public Image BG;

	public DxxText Text_Title;

	public Image Image_IconBG;

	public Image Icon;

	public DxxText Text_Tips;

	public Image Locker;

	public MissionQueueItemData data;

	public Color color1;

	public void init(MissionQueueItemData data)
	{
	}

	public void onButtonClick()
	{
	}

	public Vector3 GetFlyPosition()
	{
		return default;
	}
}
