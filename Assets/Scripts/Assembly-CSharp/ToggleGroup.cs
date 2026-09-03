using UnityEngine;

public class ToggleGroup : MonoBehaviour
{
	[SerializeField]
	private ToggleButton[] buttons;

	[SerializeField]
	private UnityEventInt refreshPage;

	private int curIndex;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void SetToggleButtons(ToggleButton[] buttons)
	{
	}

	public void Refresh(int index)
	{
	}

	private void RefreshPage(int index)
	{
	}

	public void RefreshTab(int index)
	{
	}

	public void InitTab()
	{
	}

	public void SetActive(bool isActive, int Pindex)
	{
	}

	public void SetCurIndex(int index)
	{
	}
}
