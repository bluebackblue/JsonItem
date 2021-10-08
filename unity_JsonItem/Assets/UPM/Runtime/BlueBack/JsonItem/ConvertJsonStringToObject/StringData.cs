

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief コンバート。
*/


/** BlueBack.JsonItem.ConvertJsonStringToObject
*/
namespace BlueBack.JsonItem.ConvertJsonStringToObject
{
	/** Json文字列 ==> 文字データ。
	*/
	public static class StringData
	{
		/** Convert
		*/
		public static void Convert(string a_in_jsonstring,System.Text.StringBuilder a_out_stringbuilder)
		{
			{
				if(a_in_jsonstring.Length < 2){
					//不明。

					#if(DEF_BLUEBACK_JSONITEM_ASSERT)
					DebugTool.Assert(false);
					#endif

					return;
				}

				if(a_in_jsonstring[0] != '\"'){
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
					case '\"':
						{
							//終端。

							#if(DEF_BLUEBACK_JSONITEM_ASSERT)
							DebugTool.Assert((t_index + 1) == a_in_jsonstring.Length);
							#endif

							return;
						}break;
					case '\\':
						{
							if((t_index + 1) < a_in_jsonstring.Length){
								int t_use_index = StringConvertTool.EscapeCodeStringToSpecialString.Convert(a_in_jsonstring,t_index + 1,a_out_stringbuilder);
								t_index += (t_use_index + 1);
							}else{
								//不明。

								#if(DEF_BLUEBACK_JSONITEM_ASSERT)
								DebugTool.Assert(false);
								#endif

								return;
							}
						}break;
					default:
						{
							a_out_stringbuilder.Append(a_in_jsonstring[t_index]);
							t_index++;
						}break;
					}
					#pragma warning restore
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

