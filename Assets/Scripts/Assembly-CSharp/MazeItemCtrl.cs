using UnityEngine;

public class MazeItemCtrl : MonoBehaviour
{
	public DxxText titleText;

	public DxxText okText;

	public DxxText leaveText;

	public PropOneEquip leftEquip;

	public PropOneEquip rightEquip;

	public ButtonCtrl buttonEx;

	public DxxText equalSymbol;

	private int id;

	private MazeActManager.ExchangeData data;

	public void init(MazeActManager.ExchangeData data)
	{
	}

	public void OnButtonExchange()
	{
	}

	public void freshItem()
	{
	}
}
