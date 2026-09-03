using UnityEngine;
using UnityEngine.UI;

public class WeaponSkinModelPart : MonoBehaviour
{
	public WeaponSkinHeroItem weaponSkinHeroItem;

	public WeaponSkinWeaponItem weaponSkinWeaponItem;

	public ButtonCtrl changeButton;

	public DxxText btnTex;

	public Image btnImage;

	private bool isHeroModel;

	private int curWeaponType;

	private int CurSkinId;

	private int curColorId;

	public void Init()
	{
	}

	public void ShowWeaponSkinModel(int weaponType, int skinId, int colorId)
	{
	}

	private void Show()
	{
	}

	public void ShowWeaponSkinColor(int colorID)
	{
	}
}
