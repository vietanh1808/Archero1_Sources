using UnityEngine;
using UnityEngine.UI;

public class SeasonChooseHeroItem : MonoBehaviour
{
	public CharStarShowItem starItem;

	[SerializeField]
	private DxxImage mRoleImage;

	[SerializeField]
	private ButtonCtrl mSelectBtn;

	[SerializeField]
	private Image mSelected;

	public GameObject BattleObj;

	public DxxText Text_Battle;

	public GameObject AssistObj;

	public DxxText Text_Assist;

	protected int m_nId;

	private int curHeroId;

	private int curAssistId;

	protected virtual bool IsUnlock => false;

	protected void Awake()
	{
	}

	public void init(int id)
	{
	}

	protected virtual void UpdateUI()
	{
	}

	public void freshState(int hid, int aid)
	{
	}

	private void onbuttonClick()
	{
	}
}
