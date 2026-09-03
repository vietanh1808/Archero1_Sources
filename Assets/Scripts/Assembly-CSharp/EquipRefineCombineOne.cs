using System;
using UnityEngine;
using UnityEngine.Serialization;

public class EquipRefineCombineOne : MonoBehaviour
{
	[Flags]
	public enum EquipRefineCombineOneState
	{
		Normal = 0,
		SelectedAsFirst = 1,
		Selected = 2,
		Locked = 4,
		CanCombine = 8
	}

	[SerializeField]
	private GameObject goTagFirst;

	[SerializeField]
	private GameObject goTagSecond;

	[SerializeField]
	private GameObject goLock;

	[SerializeField]
	private GameObject goEquipped;

	[FormerlySerializedAs("goCanSelect")]
	[SerializeField]
	private GameObject goCanCombine;

	[SerializeField]
	private DxxText txtEquipped;

	public PropOneEquip propOne;

	public Action<EquipRefineCombineOne> OnClick;

	private int index;

	private bool equipped;

	public void SetState(EquipRefineCombineOneState states)
	{
	}

	public void Init(EquipRefineCombinePanel.Candidate candidate)
	{
	}

	public int GetIndex()
	{
		return 0;
	}
}
