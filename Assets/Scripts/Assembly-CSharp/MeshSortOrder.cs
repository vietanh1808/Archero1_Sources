using UnityEngine;

[ExecuteInEditMode]
public class MeshSortOrder : MonoBehaviour
{
	public string sortingLayerName;

	public int sortOrder;

	public int sortingLayer;

	private Renderer[] renderers;

	private int uiLayerId;

	private void Awake()
	{
	}

	private void RestSort()
	{
	}
}
