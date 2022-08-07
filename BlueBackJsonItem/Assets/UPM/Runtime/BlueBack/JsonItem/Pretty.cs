

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief コンバート。
*/


/** BlueBack.JsonItem
*/
namespace BlueBack.JsonItem
{
	/** Pretty
	*/
	public static class Pretty
	{
		/** Convert
		*/
		public static string Convert(string a_jsonstring,string a_neststring)
		{
			System.Text.StringBuilder t_stringbuilder = new System.Text.StringBuilder(a_jsonstring.Length);

			int t_nest = 0;

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
						int t_length = JsonStringLength.StringData.GetLength(a_jsonstring,t_index,a_jsonstring.Length);
						if(t_length > 0){
							t_stringbuilder.Append(a_jsonstring.Substring(t_index,t_length));
							t_index += t_length;
						}else{
							//サイズの取得に失敗。

							#if(DEF_BLUEBACK_ASSERT)
							DebugTool.Assert(false);
							#endif

							return "";
						}
					}break;
				case '{':
				case '[':
					{
						t_stringbuilder.Append(a_jsonstring[t_index]);
						t_stringbuilder.Append("\n");
						t_index++;

						t_nest++;

						for(int ii=0;ii<t_nest;ii++){
							t_stringbuilder.Append(a_neststring);
						}
					}break;
				case '}':
				case ']':
					{
						t_stringbuilder.Append("\n");
						t_nest--;

						for(int ii=0;ii<t_nest;ii++){
							t_stringbuilder.Append(a_neststring);
						}

						t_stringbuilder.Append(a_jsonstring[t_index]);
						t_index++;
					}break;
				case ',':
					{
						t_stringbuilder.Append(a_jsonstring[t_index]);
						t_stringbuilder.Append("\n");
						t_index++;

						for(int ii=0;ii<t_nest;ii++){
							t_stringbuilder.Append(a_neststring);
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

