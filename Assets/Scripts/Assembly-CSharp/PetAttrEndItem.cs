using UnityEngine;
using UnityEngine.UI;

public class PetAttrEndItem : MonoBehaviour
{
	[SerializeField]
	private DxxText Text_Name;

	[SerializeField]
	private DxxText Text_Before;

	[SerializeField]
	private DxxText Text_After;

	[SerializeField]
	private Image Image_Arrow;

	public GameObject baseatt;

	public GameObject skills;

	public DxxText Text_Down;

	public Animator mArrowAni;

	public Animation mAfterAni;

	private int type;

	private LocalSave.EquipOne mAfter;

	private LocalSave.EquipOne mBefore;

	private string infoformat;

	private float infostart;

	private float infoend;

	private float endRealValue;

	private bool isFloat;

	public void UpdateUI(string title, string content)
	{
	}

	public void UpdateUI(string title, string infoformat, float infostart, float infoend, bool isFloat, float beginRealValue = 0f, float endRealValue = 0f)
	{
	}

	private void set_text_before(string value)
	{
	}

	private void set_text_after(string value)
	{
	}

	public void DoAnimation()
	{
	}
}
