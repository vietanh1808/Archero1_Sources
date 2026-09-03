using UnityEngine;
using UnityEngine.UI;

public class WeekGiftDayItem : MonoBehaviour
{
	public Image noImage;

	public Image shineImage;

	public Image chooseImage;

	public DxxText dayText;

	public GameObject goMask;

	public GameObject goRedNode;

	[HideInInspector]
	public PropOneEquip[] propArray;

	[HideInInspector]
	public int day;

	public void init(int day)
	{
	}

	public void freshUI()
	{
	}
}
