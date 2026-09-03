using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

public class EggHatchItem : MonoBehaviour
{
	public DxxText title;

	public Slider slider;

	public ButtonCtrl buttonKill;

	public ButtonCtrl buttonOpen;

	public DxxText killText;

	public DxxText openText;

	public DxxText Text_Progress;

	public GameObject hatching;

	public GameObject opening;

	public GameObject eggNormal;

	public GameObject eggBoss;

	public GameObject eggTopNormal;

	public GameObject eggBottomNormal;

	public GameObject eggTopBoss;

	public GameObject eggBottomBoss;

	public GameObject effect;

	public Slider Slider_Time;

	public DxxText Text_Time;

	public Image Image_Head;

	private LocalSave.EggData data;

	private int monsterid;

	private int Location;

	private ObscuredInt needKill;

	private int currentSecond;

	private int timeSpace;

	private bool flying;

	public DxxText Text_Fly;

	public Vector3 basicFlyPos;

	public ButtonCtrl Button_Help;

	private int testid;

	protected void Awake()
	{
	}

	public void init(int location, LocalSave.EggData data)
	{
	}

	private void calcuteTimeAdd()
	{
	}

	private void FlyText(int count)
	{
	}

	public void OnClosed()
	{
	}

	public void OnButtonGoKill()
	{
	}

	public void onButtonRequestHelp()
	{
	}
}
