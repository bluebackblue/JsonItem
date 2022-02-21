

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief コンバート。
*/


/** BlueBack.JsonItem.ConvertJsonStringToObject
*/
namespace BlueBack.JsonItem.ConvertJsonStringToObject
{
	/** Json文字列 ==> インデックス配列。
	*/
	public static class IndexArray
	{
		/** Create
		*/
		public static void Convert(string a_in_jsonstring,System.Collections.Generic.List<JsonItem> a_out_list)
		{
			{
				if(a_in_jsonstring.Length < 2){
					//不明。

					#if(DEF_BLUEBACK_JSONITEM_ASSERT)
					DebugTool.Assert(false);
					#endif

					return;
				}

				if(a_in_jsonstring[0] != '['){
					//不明。

					#if(DEF_BLUEBACK_JSONITEM_ASSERT)
					DebugTool.Assert(false);
					#endif

					return;
				}

				int t_index = 1;
				while(t_index < a_in_jsonstring.Length){

					#pragma warning disable 0162
					switch(a_in_jsonstring[t_index]){
					case ']':
						{
							//終端。

							#if(DEF_BLUEBACK_JSONITEM_ASSERT)
							DebugTool.Assert(t_index + 1 == a_in_jsonstring.Length);
							#endif

							return;
						}break;
					case ',':
						{
							//次の項目あり。
							t_index++;
						}break;
					}
					#pragma warning restore

					//値。
					int t_value_size = 0;
					{
						#pragma warning disable 0162
						switch(ValueType_FirstCharValueType.Get(a_in_jsonstring[t_index])){
						case ValueType.StringData:
							{
								t_value_size = JsonStringLength.StringData.GetLength(a_in_jsonstring,t_index,a_in_jsonstring.Length);
							}break;
						case ValueType.Calc_UnknownNumber:
						case ValueType.SignedNumber:
						case ValueType.UnsignedNumber:
						case ValueType.FloatingNumber:
							{
								t_value_size = JsonStringLength.Number.GetLength(a_in_jsonstring,t_index,a_in_jsonstring.Length);
							}break;
						case ValueType.AssociativeArray:
							{
								t_value_size = JsonStringLength.AssociateArray.GetLength(a_in_jsonstring,t_index,a_in_jsonstring.Length);
							}break;
						case ValueType.IndexArray:
							{
								t_value_size = JsonStringLength.IndexArray.GetLength(a_in_jsonstring,t_index,a_in_jsonstring.Length);
							}break;
						case ValueType.Calc_TrueBoolData:
							{
								t_value_size = JsonStringLength.TrueBoolData.GetLength(a_in_jsonstring,t_index,a_in_jsonstring.Length);
							}break;
						case ValueType.Calc_FalseBoolData:
							{
								t_value_size = JsonStringLength.FalseBoolData.GetLength(a_in_jsonstring,t_index,a_in_jsonstring.Length);
							}break;
						case ValueType.BinaryData:
							{
								t_value_size = JsonStringLength.BinaryData.GetLength(a_in_jsonstring,t_index,a_in_jsonstring.Length);
							}break;
						case ValueType.Null:
							{
								t_value_size = JsonStringLength.Null.GetLength(a_in_jsonstring,t_index,a_in_jsonstring.Length);
							}break;
						default:
							{
								//不明。

								#if(DEF_BLUEBACK_JSONITEM_ASSERT)
								DebugTool.Assert(false);
								#endif

								return;
							}break;
						}
						#pragma warning restore
					}
			
					//リストに追加。
					if(t_value_size > 0){
						JsonItem t_additem = new JsonItem();
						{
							t_additem.SetJsonString(a_in_jsonstring.Substring(t_index,t_value_size));
						}

						a_out_list.Add(t_additem);
						t_index += t_value_size;
					}else{
						//不明。

						#if(DEF_BLUEBACK_JSONITEM_ASSERT)
						DebugTool.Assert(false);
						#endif

						return;
					}
				}
			}
		
			//不明。

			#if(DEF_BLUEBACK_JSONITEM_ASSERT)
			DebugTool.Assert(false);
			#endif

			return;
		}
	}
}

