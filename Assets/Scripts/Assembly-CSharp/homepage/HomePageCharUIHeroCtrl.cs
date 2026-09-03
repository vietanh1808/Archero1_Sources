using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace homepage
{
	public class HomePageCharUIHeroCtrl : CharUIHeroCtrl
	{
		[CompilerGenerated]
		private sealed class _003Cinit_cloth_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HomePageCharUIHeroCtrl _003C_003E4__this;

			public int nPlayerId;

			public int nSkinId;

			public int nWingId;

			public int wingStar;

			private IResourcesLoader _003Ctloader_003E5__2;

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
			public _003Cinit_cloth_003Ed__2(int _003C_003E1__state)
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

		public GameObject goSwitchEffect;

		protected override int GetWeaponHandId(int weaponId)
		{
			return 0;
		}

		public override void InitCloth(int clothid, int nSkinId = 0, int nWingId = 0, int wingStar = 0)
		{
		}

		[IteratorStateMachine(typeof(_003Cinit_cloth_003Ed__2))]
		public override IEnumerator init_cloth(int nPlayerId, int nSkinId, int nWingId, int wingStar = 0)
		{
			return null;
		}

		private void createHeroModel(GameObject o2, int nSkinId, int nWingId, int wingStar)
		{
		}

		private GameObject createHeroShow(GameObject o2, int nSkinId, int nWingId, int wingStar)
		{
			return null;
		}

		public void ShowSwitchEffect()
		{
		}

		public override void show_effect(int playerId)
		{
		}

		public override void InitPet(int index, int petid)
		{
		}
	}
}
