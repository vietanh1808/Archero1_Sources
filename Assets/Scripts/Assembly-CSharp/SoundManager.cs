using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
	public class SoundData
	{
		public GameObject obj;

		public AudioSource audio;

		public bool Valid => false;
	}

	public enum BackgroundMusicType
	{
		eMain = 0,
		eBattle = 1
	}

	private class BGMusicData
	{
		public string path;

		public float volume;
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SoundManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CStart_003Ed__16(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private Dictionary<string, AudioClip> _soundDictionary;

	private Dictionary<string, Queue<SoundData>> _soundObjDic;

	private AudioSource audioSourceEffect;

	private const string SoundPath = "Sound/";

	private AnimationCurve animationCurve;

	private bool bSound;

	private float m_fBackgroundVolume;

	private int walk_walk;

	private string walk_path;

	private float walk_Time;

	private bool walk_Start;

	private int m_nBackgroundMusicCnt;

	private static Dictionary<BackgroundMusicType, BGMusicData> mBGList;

	private Coroutine m_coroutine1;

	private Coroutine m_coroutine2;

	private bool bMusic => false;

	private int BackgroundMusicCnt
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsBackgroundPlaying => false;

	private void InitSound()
	{
	}

	public bool GetSound()
	{
		return false;
	}

	private bool GetSoundLocal()
	{
		return false;
	}

	public void SetSound(bool sound)
	{
	}

	public bool ChangeSound()
	{
		return false;
	}

	public void DeInit()
	{
	}

	private void Awake()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__16))]
	private IEnumerator Start()
	{
		return null;
	}

	public void PreloadSound(string path)
	{
	}

	private GameObject PlayAtPoint(string audioEffectName, Vector3 pos, float volume = 1f)
	{
		return null;
	}

	private void PlayAtPointLoop(string audioEffectName, Vector3 pos, float volume = 1f, Action<SoundData> CallBack = null)
	{
	}

	public GameObject PlayEntityDead(int id, Vector3 pos)
	{
		return null;
	}

	public GameObject PlayBodyHit(int id, Vector3 pos)
	{
		return null;
	}

	public GameObject PlayBattleSpecial(int id, Vector3 pos)
	{
		return null;
	}

	public GameObject PlayGetGoods(int id, Vector3 pos)
	{
		return null;
	}

	public GameObject PlayBulletHitWall(int id, Vector3 pos)
	{
		return null;
	}

	public GameObject PlayBulletDead(int id, Vector3 pos)
	{
		return null;
	}

	public void PlayUI(SoundUIType type)
	{
	}

	public void PlayUI(int id)
	{
	}

	public void PlayUILoop(int id, Action<SoundData> callback)
	{
	}

	public void StopUILoop(int id, SoundData data)
	{
	}

	public GameObject PlayUISound(int id)
	{
		return null;
	}

	public GameObject PlayBulletCreate(int id, Vector3 pos)
	{
		return null;
	}

	public GameObject PlayHitted(int id, Vector3 pos, float volumn = -1f)
	{
		return null;
	}

	public GameObject PlayMonsterSkill(int id, Vector3 pos)
	{
		return null;
	}

	public void PlayAudioSource(string audioEffectName, float volumn = 1f)
	{
	}

	private GameObject PlayAudio(string sound, Vector3 pos, float volume)
	{
		return null;
	}

	private SoundData PlayAudioLoop(string sound, Vector3 pos, float volume)
	{
		return null;
	}

	public void StopAudioLoop(string sound, SoundData data)
	{
	}

	private void DespawnSoundCallback(string sound, SoundData data)
	{
	}

	public GameObject PlayAudioAttack(string path, Vector3 pos, float volumn = 1f)
	{
		return null;
	}

	public void PlayWalk()
	{
	}

	public void StopWalk()
	{
	}

	private void WalkUpdate()
	{
	}

	private void Update()
	{
	}

	private void InitMusic()
	{
	}

	public bool GetMusic()
	{
		return false;
	}

	private bool GetMusicLocal()
	{
		return false;
	}

	public void ChangeMusic()
	{
	}

	public void ChangeMusic(bool bPlay)
	{
	}

	private void UpdateMusicVolume()
	{
	}

	private void SetMusic()
	{
	}

	public void PlayBackgroundMusic(BackgroundMusicType type)
	{
	}

	private void StopCoroutine()
	{
	}

	public void PlayBackgroundMusic(string path, float volume, bool loop = true, Action endCallback = null, bool fadeOut = false, float fadeOutTime = 5f)
	{
	}

	public void PauseBackgroundMusic()
	{
	}

	public void ResumeBackgroundMusic()
	{
	}

	public void SetBackgroundVolume(float volume)
	{
	}
}
