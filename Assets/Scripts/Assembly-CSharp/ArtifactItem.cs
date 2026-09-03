using UnityEngine;

public class ArtifactItem : MonoBehaviour
{
	public GameObject focus;

	public PropOneEquip equipOne;

	public GameObject Mask;

	public GameObject Weared;

	public DxxText Text_Wear;

	public GameObject RedPoint;

	private LocalSave.ArtifactOne artiOne;

	private int index;

	public void init(LocalSave.ArtifactOne one, int index, int current)
	{
	}

	private void onButtonClick(PropOneBase prop, object o)
	{
	}

	public void setFocus(bool show)
	{
	}
}
