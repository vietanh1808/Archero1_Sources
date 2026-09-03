using System;
using UnityEngine;

public class ItemRender : MonoBehaviour
{
	public Action<object> OnClickEvent;

	public object Data { get; protected set; }

	public int Index { get; set; }

	public int Row { get; set; }

	public int Column { get; set; }

	public string UniqueId { get; private set; }

	public virtual void Init(int index, object data, Action<object> clickEvent)
	{
	}

	protected virtual void OnInit()
	{
	}

	public virtual void Init(string uniqueId, int index, object data, Action<object> clickEvent)
	{
	}

	public virtual void UpdateData(object data)
	{
	}

	protected virtual void OnUpdateData()
	{
	}

	public virtual void UpdateData(object data, int index)
	{
	}

	public virtual void UpdateData(string uniqueId, object data)
	{
	}

	public virtual void UpdateData(string uniqueId, object data, int index)
	{
	}

	public virtual void UpdateWearUI()
	{
	}

	protected virtual void onClickBtn()
	{
	}
}
