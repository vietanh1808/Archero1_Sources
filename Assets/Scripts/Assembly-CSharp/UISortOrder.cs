using UnityEngine;
using UnityEngine.UI;

public class UISortOrder : MonoBehaviour
{
	public Graphic target;

	public GameObject particleParent;

	public Canvas canvas;

	public int orderOffset;

	public bool isUseSelfOffset;

	private int _cur_order;

	private Canvas parentCanvas;

	[SerializeField]
	private bool _parentIsUIRoot;

	private int curOrder
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private Canvas targetCanvas => null;

	public void ReStart()
	{
	}

	public void SetTargetGraphic(Graphic target)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateSortOrder()
	{
	}

	public void forceUpdateSortOrder()
	{
	}
}
