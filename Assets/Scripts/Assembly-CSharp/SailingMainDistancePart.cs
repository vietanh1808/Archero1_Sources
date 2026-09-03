using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class SailingMainDistancePart : MonoBehaviour
{
	public Slider disSlider;

	public DxxText disText;

	public DxxText dayText;

	public DxxText rateText;

	private ShipBattle_WarStep m_Config;

	private float maxDistance => 0f;

	public void Open()
	{
	}
}
