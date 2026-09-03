using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntityAttributeUICtrl : MediatorCtrlBase
{
	public DxxInput input_propName;

	public DxxText txt_propValue;

	public ButtonCtrl btn_checkProp;

	[SerializeField]
	private ScrollRect mScrollRect;

	[SerializeField]
	private RectTransform Content_1;

	[SerializeField]
	private EntityItem CopyOne_1;

	[SerializeField]
	private RectTransform Content_2;

	[SerializeField]
	private EntityAttributeItem CopyOne_2;

	[SerializeField]
	private ButtonCtrl CloseBtn;

	private LocalUnityObjctPool ItemPool_1;

	private LocalUnityObjctPool ItemPool_2;

	private List<EntityItem> entities;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void OnClickItem(EntityBase entity)
	{
	}

	private void InitEntities()
	{
	}

	private void CreateAttrItem(string name, float value, string valueName)
	{
	}

	private void CreateAttrItem(string name, EntityAttributeBase.ValueBase value, string valueName)
	{
	}

	private void CreateAttrItem(string name, EntityAttributeBase.ValueFloatBase value, string valueName)
	{
	}

	private void CreateAttrItem(string name, EntityAttributeBase.ValueFloatBase value)
	{
	}

	private void CreateAttrItem(string name, EntityAttributeBase.ValueFloatReduce value, string valueName)
	{
	}

	private void CreateAttrItem(string name, EntityAttributeBase.ValueFloatRange value, string valueName)
	{
	}

	private void CreateAttrItem(string name, long value, string valueName)
	{
	}

	private void CreateAttrItem(string name, bool value, string valueName)
	{
	}

	private void CreateAttrItem(string name, EntityAttributeBase.ValueMult value, string valueName)
	{
	}

	private void CreateAttrItem(string value)
	{
	}

	private void InitLabels(EntityAttributeBase data)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
