

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief MonoBehaviour。
*/


/** BlueBack.JsonItem
*/
namespace BlueBack.JsonItem
{
	/** InspectorViewer_MonoBehaviour
	*/
	public abstract class InspectorViewer_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** [BlueBack.JsonItem.JsonItemViewer_MonoBehaviour]表示するJsonItemの取得。
		*/
		#if(UNITY_EDITOR)
		public virtual BlueBack.JsonItem.JsonItem GetJsonItem()
		{
			return null;
		}
		#endif

		/** [BlueBack.JsonItem.JsonItemViewer_MonoBehaviour]表示するJsonItemの取得。
		*/
		#if(UNITY_EDITOR)
		public virtual BlueBack.JsonItem.JsonItem[] GetMultiJsonItem()
		{
			return null;
		}
		#endif
	}
}


