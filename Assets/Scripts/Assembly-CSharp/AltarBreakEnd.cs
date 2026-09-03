using System.Collections.Generic;
using UnityEngine;

public class AltarBreakEnd : MonoBehaviour
{
	public RectTransform iconparent;

	public GameObject effect_thunder;

	public GameObject effect_rotate;

	public GameObject effect_bomb;

	public ParticleSystem ps1;

	private LocalUnityObjctPool mPool;

	private AnimationCurve curve_move;

	private AnimationCurve curve_sin;

	private GameObject[] effectcombinings;

	private UISortOrder effectend;

	private UISortOrder effectlight;

	private Dictionary<int, UISortOrder> effect_fronts;

	public void OnInit()
	{
	}

	public void InitUI(List<int> equipList)
	{
	}

	public void show_effect_front(bool value)
	{
	}

	private void show_effect_combining(bool value, EquipOneCtrl left = null, EquipOneCtrl right = null, EquipOneCtrl middle = null)
	{
	}

	private void show_effect_end(bool value, EquipOneCtrl middle)
	{
	}

	private void show_effect_light(bool value, EquipOneCtrl middle)
	{
	}

	private void update_canvas(GameObject o, bool add)
	{
	}

	protected void OnClose()
	{
	}
}
