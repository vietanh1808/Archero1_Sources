using UnityEngine;
using UnityEngine.UI;

public class CharTrainNeedCtrl : MonoBehaviour
{
	public DxxText Text_Title;

	public Transform itemparent;

	public DxxText Text_Info;

	private LocalSave.EquipOne mMaterialData;

	private LocalSave.CharacterOne mCharOne;

	private EquipOneCtrl mMaterial;

	public Slider slider;

	public DxxText progressText;

	public UISliderTween tween;

	public GameObject bottomObj;

	public DxxText Text_MaterialNeed;

	public DxxText Text_GoldNeed;

	public DxxImage Image_Material;

	public GameObject propItem3;

	public DxxText Text_Mat3;

	public GameObject StarObj;

	public GameObject SunObj;

	public void Init(int charid, bool first = false)
	{
	}

	private void init_equip()
	{
	}

	public void OnLanguageChange()
	{
	}
}
