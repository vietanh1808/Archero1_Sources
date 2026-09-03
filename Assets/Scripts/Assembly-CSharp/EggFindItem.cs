using UnityEngine;
using UnityEngine.Events;

public class EggFindItem : ViewCell
{
	public ButtonCtrl buttonGo;

	public DxxText buttonGoText;

	public DxxText title;

	public DxxText recommendText;

	public GameObject recommendObj;

	public UnityAction action;

	private EggFindItemData itemData;

	protected override void OnRefresh()
	{
	}

	public void init(int monsterid, int mode, int chapter, int rc, bool find)
	{
	}
}
