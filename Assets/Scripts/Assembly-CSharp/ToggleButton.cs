using UnityEngine;

public class ToggleButton : MonoBehaviour
{
	[SerializeField]
	private GameObject selectImg;

	[SerializeField]
	private GameObject unselectImg;

	[SerializeField]
	private int index;

	[SerializeField]
	private ButtonCtrl clickBtn;

	private ToggleGroup toggleGroup;

	public void Init(ToggleGroup toggleGroup)
	{
	}

	public void SetIndex(int index)
	{
	}

	public void Refresh(int selectIndex)
	{
	}

	public void SetActive(bool isActive, int Pindex)
	{
	}

	private void OnClick()
	{
	}
}
