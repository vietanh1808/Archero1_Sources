using System.Collections.Generic;

namespace Emoji
{
	public class EmojiNormal : IEmoji
	{
		public EntityBase entity { get; protected set; }

		public Dictionary<int, EmojiObject> emojiMap { get; protected set; }

		public void SetEntity(EntityBase owner)
		{
		}

		public virtual void PlayIndex(int pIndex)
		{
		}

		public virtual void PlayById(int pId)
		{
		}
	}
}
