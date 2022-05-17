

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
	public class InspectorViewer_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** editor_view_list
		*/
		#if(UNITY_EDITOR)
		public System.Collections.Generic.List<BlueBack.JsonItem.JsonItem> editor_view_list;
		#endif
	}
}

