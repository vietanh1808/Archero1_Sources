using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CardLevelUpAttCtrl : MonoBehaviour
{
	[SerializeField]
	private DxxText Text_Name;

	[SerializeField]
	private DxxText Text_Before;

	[SerializeField]
	private DxxText Text_After;

	[SerializeField]
	private Image Image_Arrow;

	private LocalSave.CardOne mData;

	public void UpdateUI(LocalSave.CardOne data, int index)
	{
	}

	public Sequence GetTweener()
	{
		return null;
	}
}
