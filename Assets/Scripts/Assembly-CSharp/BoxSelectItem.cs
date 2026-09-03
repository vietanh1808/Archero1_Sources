using UnityEngine;

public class BoxSelectItem : MonoBehaviour
{
	public PropOneEquip propItem;

	public ButtonCtrl Button_Reduce;

	public ButtonCtrl Button_Plus;

	public DxxText Text_Count;

	public GameObject Mask;

	public BoxSelectItemData data;

	private TimeLineContainer timeLine;

	public void Awake()
	{
	}

	public void init(BoxSelectItemData data)
	{
	}

	private void onButtonReduce()
	{
	}

	private void onButtonPlus()
	{
	}

	private void ClickLongAdd()
	{
	}

	private void ClickLongReduce()
	{
	}

	public void freshItemState(bool show, int left)
	{
	}
}
