

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief MonoBehaviour。
*/


/** BlueBack.JsonItem
*/
namespace BlueBack.JsonItem
{
	/** JsonItemViewer_MonoBehaviour
	*/
	public abstract class JsonItemViewer_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** [BlueBack.JsonItem.JsonItemViewer_MonoBehaviour]表示するJsonItemの取得。
		*/
		public virtual BlueBack.JsonItem.JsonItem GetJsonItem()
		{
			return null;
		}

		/** [BlueBack.JsonItem.JsonItemViewer_MonoBehaviour]表示するJsonItemの取得。
		*/
		public virtual BlueBack.JsonItem.JsonItem[] GetMultiJsonItem()
		{
			return null;
		}
	}
}


