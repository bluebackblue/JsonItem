

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief コンバート。
*/


/** BlueBack.JsonItem
*/
namespace BlueBack.JsonItem
{
	/** Normalize
	*/
	public class Normalize
	{
		/** Convert
		*/
		public static string Convert(string a_jsonstring)
		{
			System.Text.StringBuilder t_stringbuilder = new System.Text.StringBuilder(a_jsonstring.Length);

			int t_index = 0;
			while(t_index < a_jsonstring.Length){

				//スペース改行タブのスキップ。
				if((a_jsonstring[t_index] == ' ')||(a_jsonstring[t_index] == '\r')||(a_jsonstring[t_index] == '\t')||(a_jsonstring[t_index] == '\n')){
					t_index++;
					while(t_index < a_jsonstring.Length){
						if((a_jsonstring[t_index] == ' ')||(a_jsonstring[t_index] == '\r')||(a_jsonstring[t_index] == '\t')||(a_jsonstring[t_index] == '\n')){
							t_index++;
						}else{
							break;
						}
					}
					continue;
				}

				switch(a_jsonstring[t_index]){
				case '\"':
				case '\'':
					{
						int t_length = NormalizeJsonString.StringData.Normalize(a_jsonstring,t_index,a_jsonstring.Length,t_stringbuilder);
						if(t_length > 0){
							t_index += t_length;
						}else{
							//ノーマライズに失敗。

							#if(DEF_BLUEBACK_JSONITEM_ASSERT)
							DebugTool.Assert(false);
							#endif

							return "";
						}
					}break;
				default:
					{
						t_stringbuilder.Append(a_jsonstring[t_index]);
						t_index++;
					}break;
				}
			}

			return t_stringbuilder.ToString();
		}
	}
}

