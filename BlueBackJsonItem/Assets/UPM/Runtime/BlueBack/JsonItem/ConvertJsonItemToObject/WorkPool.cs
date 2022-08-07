

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief オブジェクト化。
*/


/** BlueBack.JsonItem.ConvertJsonItemToObject
*/
namespace BlueBack.JsonItem.ConvertJsonItemToObject
{
	/** WorkPool
	*/
	public sealed class WorkPool
	{
		/** ModeSetList

			List。設定。

		*/
		public enum ModeSetList
		{
			/** 開始。
			*/
			Start = 0,

			/** 反映。
			*/
			Fix = 100,
		}

		/** ModeAddList

			List。追加。

		*/
		public enum ModeAddList
		{
			/** 開始。
			*/
			Start = 1,

			/** 反映。
			*/
			Fix = 101,
		}

		/** ModeAddStringDictionary

			Dictionary。追加。

		*/
		public enum ModeAddStringDictionary
		{
			/** 開始。
			*/
			Start = 2,

			/** 反映。
			*/
			Fix = 102,
		}

		/** ModeAddAnyDictionary

			Dictionary。追加。

		*/
		public enum ModeAddAnyDictionary
		{
			/** 開始。
			*/
			Start = 3,

			/** 反映。
			*/
			Fix = 103,
		}

		/** ModeFieldInfo

			FieldInfo

		*/
		public enum ModeFieldInfo
		{
			/** 開始。
			*/
			Start = 4,

			/** 反映。
			*/
			Fix = 104,
		}

		/** ModeIEnumerableParam1

			Enumerable

		*/
		public enum ModeIEnumerable
		{
			/** 開始。
			*/
			Start_Param1 = 5,
		}

		/** list
		*/
		private System.Collections.Generic.LinkedList<WorkPool_Item> list;

		/** temp_parameter_list_1
		*/
		private System.Object[] temp_parameter_list_1;

		/** constructor
		*/
		public WorkPool()
		{
			//list
			this.list = new System.Collections.Generic.LinkedList<WorkPool_Item>();

			//temp_parameter_list_1
			this.temp_parameter_list_1 = new System.Object[1]{null};
		}

		/** AddFirst

			List。設定。

		*/
		public void AddFirst(ModeSetList a_mode,JsonItem a_from_listitem_json,System.Collections.IList a_to_list,int a_to_index,System.Type a_to_listitem_type)
		{
			WorkPool_Item t_item = new WorkPool_Item();
			{
				//モード。
				t_item.mode = (int)a_mode;

				//設定元。
				t_item.from_value_jsonitem = a_from_listitem_json;
				t_item.from_key_jsonitem = null;

				//設定先。
				t_item.to_value_type = a_to_listitem_type;
				t_item.to_key_type = null;
				t_item.to_value_object = null;
				t_item.to_key_object = null;
				t_item.to_list = a_to_list;
				t_item.to_index = a_to_index;
				t_item.to_dictionary = null;
				t_item.to_fieldinfo = null;
				t_item.to_parent_object = null;
				t_item.to_enumerable = null;
				t_item.to_methodinfo = null;
			}
			this.list.AddFirst(t_item);
		}

		/** AddFirst

			List。追加。

		*/
		public void AddFirst(ModeAddList a_mode,JsonItem a_from_listitem_json,System.Collections.IList a_to_list,System.Type a_to_listitem_type)
		{
			WorkPool_Item t_item = new WorkPool_Item();
			{
				//モード。
				t_item.mode = (int)a_mode;

				//設定元。
				t_item.from_value_jsonitem = a_from_listitem_json;
				t_item.from_key_jsonitem = null;

				//設定先。
				t_item.to_value_type = a_to_listitem_type;
				t_item.to_key_type = null;
				t_item.to_value_object = null;
				t_item.to_key_object = null;
				t_item.to_list = a_to_list;
				t_item.to_index = 0;
				t_item.to_dictionary = null;
				t_item.to_fieldinfo = null;
				t_item.to_parent_object = null;
				t_item.to_enumerable = null;
				t_item.to_methodinfo = null;
			}
			this.list.AddFirst(t_item);
		}

		/** AddFirst

			Dictionary。追加。

		*/
		public void AddFirst(ModeAddStringDictionary a_mode,JsonItem a_from_listitem_jsonitem,string a_from_key_string,System.Collections.IDictionary a_to_dictionary,System.Type a_to_listitem_type)
		{
			WorkPool_Item t_item = new WorkPool_Item();
			{
				//モード。
				t_item.mode = (int)a_mode;

				//設定元。
				t_item.from_value_jsonitem = a_from_listitem_jsonitem;
				t_item.from_key_jsonitem = null;

				//設定先。
				t_item.to_value_type = a_to_listitem_type;
				t_item.to_key_type = null;
				t_item.to_value_object = null;
				t_item.to_key_object = a_from_key_string;
				t_item.to_list = null;
				t_item.to_index = 0;
				t_item.to_dictionary = a_to_dictionary;
				t_item.to_fieldinfo = null;
				t_item.to_parent_object = null;
				t_item.to_enumerable = null;
				t_item.to_methodinfo = null;
			}
			this.list.AddFirst(t_item);
		}

		/** AddFirst

			Dictionary。追加。

		*/
		public void AddFirst(ModeAddAnyDictionary a_mode,JsonItem a_from_key_jsonitem,JsonItem a_from_value_jsonitem,System.Collections.IDictionary a_to_dictionary,System.Type a_to_key_type,System.Type a_to_value_type)
		{
			WorkPool_Item t_item = new WorkPool_Item();
			{
				//モード。
				t_item.mode = (int)a_mode;

				//設定元。
				t_item.from_value_jsonitem = a_from_value_jsonitem;
				t_item.from_key_jsonitem = a_from_key_jsonitem;

				//設定先。
				t_item.to_value_type = a_to_value_type;
				t_item.to_key_type = a_to_key_type;
				t_item.to_value_object = null;
				t_item.to_key_object = null;
				t_item.to_list = null;
				t_item.to_index = 0;
				t_item.to_dictionary = a_to_dictionary;
				t_item.to_fieldinfo = null;
				t_item.to_parent_object = null;
				t_item.to_enumerable = null;
				t_item.to_methodinfo = null;
			}
			this.list.AddFirst(t_item);
		}

		/** AddFirst

			FieldInfo

		*/
		public void AddFirst(ModeFieldInfo a_mode,JsonItem a_from_member_jsonitem,System.Reflection.FieldInfo a_to_fieldinfo,System.Object a_to_parent_object)
		{
			WorkPool_Item t_item = new WorkPool_Item();
			{
				//モード。
				t_item.mode = (int)a_mode;

				//設定元。
				t_item.from_value_jsonitem = a_from_member_jsonitem;
				t_item.from_key_jsonitem = null;

				//設定先。
				t_item.to_value_type = a_to_fieldinfo.FieldType;
				t_item.to_key_type = null;
				t_item.to_value_object = null;
				t_item.to_key_object = null;
				t_item.to_list = null;
				t_item.to_index = 0;
				t_item.to_dictionary = null;
				t_item.to_fieldinfo = a_to_fieldinfo;
				t_item.to_parent_object = a_to_parent_object;
				t_item.to_enumerable = null;
				t_item.to_methodinfo = null;
			}
			this.list.AddFirst(t_item);
		}

		/** AddFirst

			Enumerable

		*/
		public void AddFirst(ModeIEnumerable a_mode,JsonItem a_from_member_jsonitem,System.Collections.IEnumerable a_to_enumerable,System.Reflection.MethodInfo a_to_methodinfo,System.Type a_to_listitem_type)
		{
			WorkPool_Item t_item = new WorkPool_Item();
			{
				//モード。
				t_item.mode = (int)a_mode;

				//設定元。
				t_item.from_value_jsonitem = a_from_member_jsonitem;
				t_item.from_key_jsonitem = null;

				//設定先。
				t_item.to_value_type = a_to_listitem_type;
				t_item.to_key_type = null;
				t_item.to_value_object = null;
				t_item.to_key_object = null;
				t_item.to_list = null;
				t_item.to_index = 0;
				t_item.to_dictionary = null;
				t_item.to_fieldinfo = null;
				t_item.to_parent_object = null;
				t_item.to_enumerable = a_to_enumerable;
				t_item.to_methodinfo = a_to_methodinfo;
			}
			this.list.AddFirst(t_item);
		}

		/** 更新。
		*/
		public void Main()
		{
			while(true){
				int t_count = this.list.Count;
				if(t_count > 0){
					WorkPool_Item t_current_work = this.list.First.Value;
					this.list.RemoveFirst();
					this.Main_Item(t_current_work);

					#if(DEF_BLUEBACK_LOG_LOOPLIMIT)
					if(t_count > Config.LOOPLIMIT){
						DebugTool.Log(string.Format("WorkPool : list : {0}",t_count));
					}
					#endif
				}else{
					break;
				}
			}
		}

		/** 更新。
		*/
		private void Main_Item(WorkPool_Item a_item)
		{
			switch(a_item.mode){
			case (int)ModeSetList.Start:
				{
					//List。設定。

					//JsonItemから型を決める。
					if(a_item.to_value_type == typeof(System.Object)){
						a_item.to_value_type = ValueType_ConvertToType.Get(a_item.from_value_jsonitem);
					}

					//インスタンス作成。
					CreateInstance.Create(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem);

					if(a_item.to_value_type.IsClass == true){

						//メンバーの設定。
						ConvertJsonItemToObject.Convert(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem,this);

						//リストに設定。
						a_item.to_list[a_item.to_index] = a_item.to_value_object;
					}else{

						//差し込み位置。
						System.Collections.Generic.LinkedListNode<WorkPool_Item> t_first_node = this.list.First;

						//メンバーの設定。
						ConvertJsonItemToObject.Convert(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem,this);

						//再登録。
						a_item.mode = (int)ModeSetList.Fix;

						//差し込み。
						if(t_first_node != null){
							this.list.AddBefore(t_first_node,a_item);
						}else{
							this.list.AddLast(a_item);
						}
					}
				}break;
			case (int)ModeSetList.Fix:
				{
					//List。設定。

					//リストに設定。
					a_item.to_list[a_item.to_index] = a_item.to_value_object;
				}break;
			case (int)ModeAddList.Start:
				{
					//List。追加。

					//JsonItemから型を決める。
					if(a_item.to_value_type == typeof(System.Object)){
						a_item.to_value_type = ValueType_ConvertToType.Get(a_item.from_value_jsonitem);
					}

					//インスタンス作成。
					CreateInstance.Create(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem);

					if(a_item.to_value_type.IsClass == true){

						//メンバーの設定。
						ConvertJsonItemToObject.Convert(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem,this);

						//リストに設定。
						a_item.to_list.Add(a_item.to_value_object);
					}else{

						//差し込み位置。
						System.Collections.Generic.LinkedListNode<WorkPool_Item> t_first_node = this.list.First;

						//メンバーの設定。
						ConvertJsonItemToObject.Convert(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem,this);

						//再登録。
						a_item.mode = (int)ModeAddList.Fix;

						//差し込み。
						if(t_first_node != null){
							this.list.AddBefore(t_first_node,a_item);
						}else{
							this.list.AddLast(a_item);
						}
					}
				}break;
			case (int)ModeAddList.Fix:
				{
					//List。追加。

					//リストに追加。
					a_item.to_list.Add(a_item.to_value_object);
				}break;
			case (int)ModeAddStringDictionary.Start:
				{
					//Dictionary。追加。

					//JsonItemから型を決める。
					if(a_item.to_value_type == typeof(System.Object)){
						a_item.to_value_type = ValueType_ConvertToType.Get(a_item.from_value_jsonitem);
					}

					//インスタンス作成。
					CreateInstance.Create(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem);

					if(a_item.to_value_type.IsClass == true){

						//メンバーの設定。
						ConvertJsonItemToObject.Convert(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem,this);

						//リストに設定。
						a_item.to_dictionary.Add(a_item.to_key_object,a_item.to_value_object);
					}else{

						//差し込み位置。
						System.Collections.Generic.LinkedListNode<WorkPool_Item> t_first_node = this.list.First;

						//メンバーの設定。
						ConvertJsonItemToObject.Convert(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem,this);

						//再登録。
						a_item.mode = (int)ModeAddStringDictionary.Fix;

						//差し込み。
						if(t_first_node != null){
							this.list.AddBefore(t_first_node,a_item);
						}else{
							this.list.AddLast(a_item);
						}
					}
				}break;
			case (int)ModeAddStringDictionary.Fix:
				{
					//Dictionary。追加。

					//リストに追加。
					{
						a_item.to_dictionary.Add(a_item.to_key_object,a_item.to_value_object);
					}
				}break;
			case (int)ModeAddAnyDictionary.Start:
				{
					//Dictionary。追加。

					//JsonItemから型を決める。
					if(a_item.to_key_type == typeof(System.Object)){
						a_item.to_key_type = ValueType_ConvertToType.Get(a_item.from_key_jsonitem);
					}

					//JsonItemから型を決める。
					if(a_item.to_value_type == typeof(System.Object)){
						a_item.to_value_type = ValueType_ConvertToType.Get(a_item.from_value_jsonitem);
					}

					if((a_item.to_key_type.IsClass == true)&&(a_item.to_value_type.IsClass == true)){

						//キーの作成。
						CreateInstance.Create(ref a_item.to_key_object,a_item.to_key_type,a_item.from_key_jsonitem);
						ConvertJsonItemToObject.Convert(ref a_item.to_key_object,a_item.to_key_type,a_item.from_key_jsonitem,this);

						//値の作成。
						CreateInstance.Create(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem);
						ConvertJsonItemToObject.Convert(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem,this);

						//リストに設定。
						a_item.to_dictionary.Add(a_item.to_key_object,a_item.to_value_object);

					}else{
						//差し込み位置。
						System.Collections.Generic.LinkedListNode<WorkPool_Item> t_first_node = this.list.First;

						//キーの作成。
						CreateInstance.Create(ref a_item.to_key_object,a_item.to_key_type,a_item.from_key_jsonitem);
						ConvertJsonItemToObject.Convert(ref a_item.to_key_object,a_item.to_key_type,a_item.from_key_jsonitem,this);

						//値の作成。
						CreateInstance.Create(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem);
						ConvertJsonItemToObject.Convert(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem,this);

						//再登録。
						a_item.mode = (int)ModeAddAnyDictionary.Fix;

						//差し込み。
						if(t_first_node != null){
							this.list.AddBefore(t_first_node,a_item);
						}else{
							this.list.AddLast(a_item);
						}
					}
				}break;
			case (int)ModeAddAnyDictionary.Fix:
				{
					//Dictionary。追加。

					//リストに追加。
					{
						a_item.to_dictionary.Add(a_item.to_key_object,a_item.to_value_object);
					}
				}break;
			case (int)ModeFieldInfo.Start:
				{
					//FieldInfo。

					//JsonItemから型を決める。
					if(a_item.to_value_type == typeof(System.Object)){
						a_item.to_value_type = ValueType_ConvertToType.Get(a_item.from_value_jsonitem);
					}

					//インスタンスの作成。
					CreateInstance.Create(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem);

					if(a_item.to_value_type.IsClass == true){

						//メンバーの設定。
						ConvertJsonItemToObject.Convert(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem,this);

						//フィールドに設定。
						a_item.to_fieldinfo.SetValue(a_item.to_parent_object,a_item.to_value_object);
					}else{

						//差し込み位置。
						System.Collections.Generic.LinkedListNode<WorkPool_Item> t_first_node = this.list.First;

						//メンバーの設定。
						ConvertJsonItemToObject.Convert(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem,this);

						//再登録。
						a_item.mode = (int)ModeFieldInfo.Fix;

						//差し込み。
						if(t_first_node != null){
							this.list.AddBefore(t_first_node,a_item);
						}else{
							this.list.AddLast(a_item);
						}
					}
				}break;
			case (int)ModeFieldInfo.Fix:
				{
					//FieldInfo。

					//フィールドに設定。
					a_item.to_fieldinfo.SetValue(a_item.to_parent_object,a_item.to_value_object);
				}break;
			case (int)ModeIEnumerable.Start_Param1:
				{
					//Generic.Stack
					//Generic.LinkedList
					//Generic.HashSet
					//Generic.Queue
					//Generic.SortedSet

					//JsonItemから型を決める。
					if(a_item.to_value_type == typeof(System.Object)){
						a_item.to_value_type = ValueType_ConvertToType.Get(a_item.from_value_jsonitem);
					}

					System.Type t_generic_type = ReflectionTool.ReflectionTool.GetGenericTypeDefinition(a_item.to_enumerable.GetType());

					//インスタンス作成。
					CreateInstance.Create(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem);

					//■メンバーの設定。
					ConvertJsonItemToObject.Convert(ref a_item.to_value_object,a_item.to_value_type,a_item.from_value_jsonitem,this);

					//パラメータリスト。
					this.temp_parameter_list_1[0] = a_item.to_value_object;

					//呼び出し。
					{
						a_item.to_methodinfo.Invoke(a_item.to_enumerable,this.temp_parameter_list_1);
					}
				}break;
			}
		}
	}
}

