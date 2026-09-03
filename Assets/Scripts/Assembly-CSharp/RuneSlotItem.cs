using UnityEngine;

public class RuneSlotItem : MonoBehaviour
{
	[SerializeField]
	private DxxImage imgIcon;

	[SerializeField]
	private GameObject goLock;

	[SerializeField]
	private GameObject goFrame;

	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private PropOneEquip one;

	[SerializeField]
	private Sprite[] sprites;

	private int slotIndex;

	private int pos;

	private RuneSelectUI selectUI;

	private int unlockLevel;

	private int currentLevel;

	private int id => 0;

	private void Awake()
	{
	}

	public void Init(int pos, int slotIndex, RuneSelectUI selectUI)
	{
	}

	private void Refresh()
	{
	}
}
