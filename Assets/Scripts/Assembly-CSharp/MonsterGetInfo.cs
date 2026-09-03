using UnityEngine;
using UnityEngine.UI;

public class MonsterGetInfo : MonoBehaviour
{
	public DxxText Text_Title;

	public Slider slider;

	public DxxText Text_Progress;

	public Image Slider_Light;

	public Image Image_Arrow;

	public DxxText Text_New;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	public MonsterStarShow starShow;

	private LocalSave.MonsterData data;

	public void Awake()
	{
	}

	public void init(LocalSave.MonsterData data)
	{
	}
}
