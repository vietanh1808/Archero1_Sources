using UnityEngine;

public class SelectedNpcCardOneCtrl : MonoBehaviour
{
	public delegate void OnClickDelegate(int index);

	public DxxImage CardImage;

	public ButtonCtrl SelectBtn;

	public DxxText RoleLevelText;

	public DxxImage LevelBg;

	private HeroCardInfo CardData;

	private OnClickDelegate onClickAction;

	private int m_nSelectedIndex;

	public HeroCardInfo Data => null;

	public bool IsEmpty => false;

	public int SelectedIndex => 0;

	public bool Selected => false;

	public int Index { get; set; }

	public void Init(int index, HeroCardInfo data, OnClickDelegate onClickAction)
	{
	}

	public void UpdateData(HeroCardInfo data, int index)
	{
	}

	public void UpdateState()
	{
	}

	public void OnClick()
	{
	}
}
