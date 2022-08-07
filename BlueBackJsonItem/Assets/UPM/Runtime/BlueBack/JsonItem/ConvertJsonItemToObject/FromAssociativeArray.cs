

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief オブジェクト化。
*/


/** BlueBack.JsonItem.ConvertJsonItemToObject
*/
namespace BlueBack.JsonItem.ConvertJsonItemToObject
{
	/** オブジェクト化。

		ValueType.AssociativeArray

	*/
	public static class FromAssociativeArray
	{
		/** Convert
		*/
		public static void Convert(ref System.Object a_to_refobject,System.Type a_to_type,JsonItem a_from_jsonitem,WorkPool a_workpool)
		{
			//IDictionary
			{
				System.Collections.IDictionary t_to_dictionary = a_to_refobject as System.Collections.IDictionary;
				if(t_to_dictionary != null){

					System.Type t_list_key_type = ReflectionTool.ReflectionTool.GetDictionaryKeyType(a_to_type);
					if(t_list_key_type == typeof(string)){
						//Generic.Dictionary<string.*>
						//Generic.SortedDictionary<string,*>
						//Generic.SortedList<string,*>

						//リスト型の値型。取得。
						System.Type t_list_value_type = ReflectionTool.ReflectionTool.GetListValueType(a_to_type);

						System.Collections.Generic.Dictionary<string,JsonItem>.KeyCollection t_keylist = a_from_jsonitem.GetAssociativeKeyList();

						//ワークに追加。
						foreach(string t_listitem_key_string in t_keylist){
							JsonItem t_listitem_jsonitem = a_from_jsonitem.GetItem(t_listitem_key_string);
							a_workpool.AddFirst(WorkPool.ModeAddStringDictionary.Start,t_listitem_jsonitem,t_listitem_key_string,t_to_dictionary,t_list_value_type);
						}

						//完了。
						return;
					}else{
						//Generic.Dictionary<xxxx.>
						//Generic.SortedDictionary<xxxx,>
						//Generic.SortedList<xxxx,>

						//未対応。
					}
				}
			}

			//class,struct
			if(a_to_refobject != null){
				System.Collections.Generic.List<System.Reflection.FieldInfo> t_fieldinfo_list = new System.Collections.Generic.List<System.Reflection.FieldInfo>();
				ConvertTool.GetMemberListAll(a_to_type,t_fieldinfo_list);

				//ワークに追加。
				foreach(System.Reflection.FieldInfo t_fieldinfo in t_fieldinfo_list){
					if(a_from_jsonitem.IsExistItem(t_fieldinfo.Name) == true){
						JsonItem t_jsonitem_classmember = a_from_jsonitem.GetItem(t_fieldinfo.Name);
						a_workpool.AddFirst(WorkPool.ModeFieldInfo.Start,t_jsonitem_classmember,t_fieldinfo,a_to_refobject);
					}
				}

				//完了。
				return;
			}

			//失敗。

			#if(DEF_BLUEBACK_ASSERT)
			DebugTool.Assert(false);
			#endif
		}
	}
}

