

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief タイプ。
*/


/** BlueBack.JsonItem
*/
namespace BlueBack.JsonItem
{
	/** 最初の一文字からタイプを推測。
	*/
	public static class ValueType_FirstCharValueType
	{
		/** Get
		*/
		public static ValueType Get(char a_first_char)
		{
			#pragma warning disable 0162
			switch(a_first_char){
			case '"':
			case '\'':
				{
					return ValueType.StringData;
				}break;
			case '{':
				{
					return ValueType.AssociativeArray;
				}break;
			case '[':
				{
					return ValueType.IndexArray;
				}break;
			case '<':
				{
					return ValueType.BinaryData;
				}break;
			case 't':
			case 'T':
				{
					return ValueType.Calc_TrueBoolData;
				}break;
			case 'f':
			case 'F':
				{
					return ValueType.Calc_FalseBoolData;
				}break;
			case '-':
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
				{
					return ValueType.Calc_UnknownNumber;
				}break;
			case 'n':
				{
					return ValueType.Null;
				}break;
			default:
				{
					//不明。

					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",a_first_char));
					#endif

					return ValueType.Null;
				}break;
			}
			#pragma warning restore
		}
	}
}

