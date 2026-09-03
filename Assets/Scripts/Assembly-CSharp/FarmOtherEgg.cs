using UnityEngine;
using UnityEngine.UI;

public class FarmOtherEgg : MonoBehaviour
{
	public Slider slider;

	public ButtonCtrl ButtonSpeed;

	public DxxText Text_Speed;

	public DxxText Text_HaveSpeed;

	public DxxText Text_Progress;

	public GameObject eggNormal;

	public GameObject eggBoss;

	public Image Image_Head;

	private LocalSave.EggData data;

	private int Location;

	private int needKill;

	protected void Awake()
	{
	}

	public void init(int location, LocalSave.EggData data)
	{
	}

	public void finishVisitAddSpeed()
	{
	}
}
