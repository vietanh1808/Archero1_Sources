using UnityEngine;

public interface IResourcesLoader
{
	string resPath { get; }

	bool IsDone { get; }

	bool IsStart { get; }

	Object res { get; }

	void Update();

	bool StartLoad();
}
