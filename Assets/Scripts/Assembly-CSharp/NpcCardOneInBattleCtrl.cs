using UnityEngine;

public class NpcCardOneInBattleCtrl : MonoBehaviour
{
	public delegate int OnClickDelegate(NpcCardOneInBattleCtrl card);

	private static Material _gray;

	public DxxImage CardImage;

	public ButtonCtrl SelectBtn;

	public DxxText RoleLevelText;

	public DxxImage LevelBg;

	public DxxImage SelectImg;

	private HeroCardInfo CardData;

	private OnClickDelegate onClickAction;

	private int m_nSelectedIndex;

	public static Material GrayMaterial => null;

	public HeroCardInfo Data => null;

	public bool IsEmpty => false;

	public int SelectedIndex => 0;

	public bool Selected => false;

	public int Index { get; set; }

	public void Init(int index, HeroCardInfo data, OnClickDelegate onClickAction)
	{
	}

	public void UnSelect()
	{
	}

	private void SetGray(bool ifGray)
	{
	}

	public void UpdateState()
	{
	}

	public void OnClick()
	{
	}
}
