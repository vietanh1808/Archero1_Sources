using UnityEngine;
using UnityEngine.UI;

public class EggPlate : MonoBehaviour
{
	public Button Button_Icon;

	public ButtonCtrl Button_Unlock;

	public DxxText Text_Unlock;

	public DxxText Text_Diamond;

	public GameObject hatchRoot;

	public Image Image_Locker;

	[HideInInspector]
	public EggHatchItem hatching;

	public int Location;

	public void init(int location)
	{
	}

	public void addHatchingEgg(LocalSave.EggData data)
	{
	}

	public void OnButtonUnlockPlate()
	{
	}

	public bool isUnlock()
	{
		return false;
	}

	public void buySuccess()
	{
	}

	private void freshPlate()
	{
	}

	public void finishHatch()
	{
	}

	public void freshHatchProgress(LocalSave.EggData data)
	{
	}
}
