using UnityEngine;
using UnityEngine.UI;

public class PetSkillIcon : MonoBehaviour
{
	public Image Image_BG;

	public Image Image_Icon;

	public Material Mat_Gray;

	public GameObject AddObj;

	public GameObject LockerObj;

	public Image Img_Flag;

	public GameObject RedPoint;

	private LocalSave.PetOne petOne;

	private int skiId;

	private int position;

	public void init(LocalSave.PetOne pet, int skill, int pos)
	{
	}

	public void onButtonClick()
	{
	}
}
