

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief MonoBehaviour。
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
		public abstract BlueBack.JsonItem.JsonItem GetJsonItem();
		#endif

		/** [BlueBack.JsonItem.JsonItemViewer_MonoBehaviour]表示するJsonItemの取得。
		*/
		#if(UNITY_EDITOR)
		public abstract BlueBack.JsonItem.JsonItem[] GetMultiJsonItem();
		#endif
	}
}

