using System.Collections.Generic;

public class Act5thHuntingSceneData : RecycleData<Act5thHuntingSceneSourceData>
{
	public int GetCurSelectSceneID => 0;

	public bool HaveEnoughCurrencyStartHunting => false;

	public int[] GetAllSceneID => null;

	public int GetMaxUnlockSceneID => 0;

	public bool IsUnlockScene(int sceneID)
	{
		return false;
	}

	public int SceneUnlockNeedScore(int sceneID)
	{
		return 0;
	}

	public int SceneUnlockDiffNeedScore(int sceneID)
	{
		return 0;
	}

	public int SceneCostHunterTicket(int sceneID)
	{
		return 0;
	}

	public int SceneMaxKillScore(int sceneID)
	{
		return 0;
	}

	public int SceneAllKillScore(int sceneID)
	{
		return 0;
	}

	public int SceneUnlockSweepNeedKillScore(int sceneID)
	{
		return 0;
	}

	public int SceneUnlockSweepDiffNeedKillScore(int sceneID)
	{
		return 0;
	}

	public bool IsUnlockSweep(int sceneID)
	{
		return false;
	}

	public string SceneBackgroundImg(int sceneID)
	{
		return null;
	}

	public void UpdateSelectScene(int sceneID)
	{
	}

	public void UpdateSceneMaxKillScore(Dictionary<int, int> sceneMaxKillScore)
	{
	}

	public void UpdateSceneAllKillScore(Dictionary<int, int> sceneAllKillScore)
	{
	}

	private int GetSceneMaxKillScore(int sceneID)
	{
		return 0;
	}

	private int GetSceneAllKillScore(int sceneID)
	{
		return 0;
	}
}
