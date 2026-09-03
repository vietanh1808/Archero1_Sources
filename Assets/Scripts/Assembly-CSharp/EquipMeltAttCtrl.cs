using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class EquipMeltAttCtrl : MonoBehaviour
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

	private bool isFloat;

	public void updateAttribute(string effect)
	{
	}

	private void refreshEffectSkill(int skillid)
	{
	}

	private int find_same_index(string before, string after)
	{
		return 0;
	}

	public void UpdateMaxLevel(LocalSave.EquipOne mBefore, LocalSave.EquipOne mAfter)
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

	public float GetHeight()
	{
		return 0f;
	}

	public Sequence GetTweener()
	{
		return null;
	}
}
