

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief コンバート。
*/


/** BlueBack.JsonItem.JsonStringLength
*/
namespace BlueBack.JsonItem.JsonStringLength
{
	/** True真偽データ。
	*/
	public static class TrueBoolData
	{
		/** TRUE
		*/
		public static char[] STRING_TRUE_1 = {'T','R','U','E'};
		public static char[] STRING_TRUE_2 = {'t','r','u','e'};

		/** GetLength
		*/
		public static int GetLength(string a_jsonstring,int a_index,int a_length)
		{
			for(int ii=0;ii<STRING_TRUE_1.Length;ii++){
				int t_index = a_index + ii;

				if(t_index < a_length){
					if((a_jsonstring[t_index] == STRING_TRUE_1[ii])||(a_jsonstring[t_index] == STRING_TRUE_2[ii])){
					}else{
						//TRUE以外。

						#if(DEF_BLUEBACK_JSONITEM_ASSERT)
						DebugTool.Assert(false);
						#endif

						return 0;
					}
				}else{
					//終端前に範囲外。

					#if(DEF_BLUEBACK_JSONITEM_ASSERT)
					DebugTool.Assert(false);
					#endif

					return 0;
				}
			}

			//終端チェック。
			{
				int t_index = a_index + STRING_TRUE_1.Length;
				if(t_index < a_length){
					#pragma warning disable 0162
					switch(a_jsonstring[t_index]){
					case '}':
					case ']':
					case ',':
					case ' ':
					case '\n':
					case '\t':
					case '\r':
						{
							//終端。
							return STRING_TRUE_1.Length;
						}break;
					default:
						{
							//不明な文字。

							#if(DEF_BLUEBACK_JSONITEM_ASSERT)
							DebugTool.Assert(false);
							#endif

							return 0;
						}break;	
					}
					#pragma warning restore
				}else{
					//終端。
					return STRING_TRUE_1.Length;
				}
			}
		}
	}
}

