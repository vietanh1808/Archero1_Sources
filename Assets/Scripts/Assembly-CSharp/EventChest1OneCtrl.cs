using UnityEngine;
using UnityEngine.UI;

public class EventChest1OneCtrl : MonoBehaviour
{
	public Transform child;

	public Image Image_Icon;

	public DxxText Text_Value;

	private PropOneEquip _equipone;

	private PropOneEquip equipone => null;

	public TurnTableData mData { get; private set; }

	public void Init(TurnTableData data)
	{
	}
}
