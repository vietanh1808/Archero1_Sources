using UnityEngine;
using UnityEngine.UI;

public class WingAttributeItem : MonoBehaviour
{
	public GameObject skillObj;

	public PauseUISkillIconCtrl iconCtrl;

	public DxxText skillDesc;

	public ButtonCtrl skillDetailTip;

	public GameObject attributeObj;

	public DxxText attributeDesc;

	public GameObject allObj;

	public DxxText allDesc;

	public DxxText allAttributeDesc;

	public ScrollRect m_scroll_Desc;

	public RectTransform m_rect_content;

	public void Open(LocalSave.WingOne wing, string attributeStr)
	{
	}
}
