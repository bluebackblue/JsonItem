

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
		/** 表示するJsonItemの取得。
		*/
		public abstract BlueBack.JsonItem.JsonItem GetJsonItem();
	}
}


