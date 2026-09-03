using System;
using UnityEngine;
using UnityEngine.UI;

public class EntityItem : MonoBehaviour
{
	[SerializeField]
	private Image bg;

	[SerializeField]
	private Text id;

	[SerializeField]
	private ButtonCtrl btn;

	private EntityBase entity;

	private Action<EntityBase> OnClickEvent;

	private void Awake()
	{
	}

	public void Init(EntityBase entity, EntityBase selected, Action<EntityBase> OnClickEvent)
	{
	}

	public void UpdateSelected(EntityBase selected)
	{
	}

	private void OnClick()
	{
	}
}
