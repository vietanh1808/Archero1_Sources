using UnityEngine;

public class GameObjectActivator : MonoBehaviour
{
	[SerializeField]
	private string currentName;

	[SerializeField]
	private ActivateGroup[] activateGroups;

	public void Set(int index, bool reverse = false)
	{
	}

	public void Set(string name, bool reverse = false)
	{
	}

	private void SetGroup(ActivateGroup group, bool reverse = false)
	{
	}
}
