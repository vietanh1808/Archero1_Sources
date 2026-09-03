using System;
using UnityEngine;
using UnityEngine.UI;

public class SeasonHeroCardOne : MonoBehaviour
{
	public CharStarShowItem starItem;

	[SerializeField]
	private DxxImage mRoleImage;

	[SerializeField]
	private ButtonCtrl mSelectBtn;

	[SerializeField]
	private Image mSelected;

	[SerializeField]
	private Image mProfessionImg;

	[SerializeField]
	private ButtonCtrl mProfessionBtn;

	protected int m_nId;

	private int m_nProfessionId;

	protected Action<SeasonHeroCardOne> OnClick;

	public int ProfessionId => 0;

	protected virtual bool IsUnlock => false;

	public int ID => 0;

	protected virtual bool SelectState => false;

	public void Init(int id, Action<SeasonHeroCardOne> OnClick = null, Action<SeasonHeroCardOne, Vector3> OnClickProfesson = null)
	{
	}

	protected virtual void OnClickSelectBtn()
	{
	}

	protected virtual bool CheckHasCharacter(int id)
	{
		return false;
	}

	public void Init(int id, int nProfessionId)
	{
	}

	protected virtual void UpdateUI()
	{
	}

	public void UpdateSelectState()
	{
	}
}
