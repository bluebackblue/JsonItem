

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief ノーマライズ。
*/


/** BlueBack.JsonItem.NormalizeJsonString
*/
namespace BlueBack.JsonItem.NormalizeJsonString
{
	/** 文字データ。
	*/
	public class StringData
	{
		/** Normalize
		*/
		public static int Normalize(string a_jsonstring,int a_index,int a_length,System.Text.StringBuilder a_out_stringbuilder)
		{
			int t_index = a_index;

			if(t_index < a_length){
				if((a_jsonstring[t_index] == '"')||(a_jsonstring[t_index] == '\'')){
					int t_length = JsonStringLength.StringData.GetLength(a_jsonstring,t_index,a_jsonstring.Length);
					if(t_length > 0){
						a_out_stringbuilder.Append(a_jsonstring.Substring(t_index,t_length));
						return t_length;
					}else{
						//サイズの取得に失敗。

						#if(DEF_BLUEBACK_JSONITEM_ASSERT)
						DebugTool.Assert(false);
						#endif

						return 0;
					}
				}else{
					//文字列以外。

					#if(DEF_BLUEBACK_JSONITEM_ASSERT)
					DebugTool.Assert(false);
					#endif

					return 0;
				}
			}else{
				//開始位置が範囲外。

				#if(DEF_BLUEBACK_JSONITEM_ASSERT)
				DebugTool.Assert(false);
				#endif

				return 0;
			}
		}
	}
}

