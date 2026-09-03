using System.Collections.Generic;
using DG.Tweening;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class Act5thHuntingGameAnimalCreator : MonoBehaviour, IUILifeCycle
{
	private RectTransform gameScene;

	private List<Act5thHuntingAnimalData> curWaveAnimalData;

	private Dictionary<int, List<Act5thHuntingAnimalData>> allWaveAnimalData;

	private Tween delayCall;

	private Tween waveCreateDelayCall;

	private SequencePool sequencePool;

	private bool isCreating;

	private Act5thHuntingManager HuntingManager => null;

	private Act5thHuntingEntityManager HuntingEntityManager => null;

	private Act5thHuntingAnimalCreatorData HuntingAnimalCreatorData => null;

	private float GameSceneWidth => 0f;

	private float GameSceneLength => 0f;

	private float AnimalTopCreatePosRange(float animalRadius)
	{
		return 0f;
	}

	private float AnimalLeftRightCreatePosRange(float animalRadius)
	{
		return 0f;
	}

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void GameStar(RectTransform gameScene)
	{
	}

	public void GameEnd()
	{
	}

	private void Refresh()
	{
	}

	private bool AllowCreateWaveAnimal(int animalWave)
	{
		return false;
	}

	private void CreateWaveAnimal(bool createPerAnimalNeedInterval)
	{
	}

	private void CreateAnimal(Act5thHuntingAnimalData animalData, float createAnimalAngle, Vector2 createAnimalPos, int animalWave)
	{
	}

	private (int, List<Act5thHuntingAnimalData>) CreatePoolAnimalData(Act5thHuntingAnimalPoolType poolType, int needCreateCount)
	{
		return default;
	}

	private void UpdateAnimalCreateStatus()
	{
	}
}
