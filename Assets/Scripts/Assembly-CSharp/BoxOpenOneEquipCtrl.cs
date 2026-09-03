using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class BoxOpenOneEquipCtrl : MonoBehaviour
{
	public GameObject infoparent;

	public DxxText Text_Title;

	public DxxText Text_Name;

	public DxxText Text_Info;

	public Transform equipparent;

	public Image Image_Icon;

	public Image Image_BG;

	public GameObject mAddParent;

	public DxxText Text_Count;

	public Image Image_White;

	public GameObject fx_open;

	private Sequence seq;

	private LocalSave.EquipOne equipdata;

	public Sequence Init(LocalSave.EquipOne equip, int count)
	{
		return null;
	}

	public void DeInit()
	{
	}

	private Color GetColor(int quality)
	{
		return default;
	}
}
