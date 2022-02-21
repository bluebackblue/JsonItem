

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief タイプ。
*/


/** BlueBack.JsonItem
*/
namespace BlueBack.JsonItem
{
	/** 数値のタイプを取得。
	*/
	public static class ValueType_NumverValueType
	{
		/** Get
		*/
		public static ValueType Get(string a_string)
		{
			//サフィックス。
			{
				#pragma warning disable 0162
				switch(a_string[a_string.Length - 1]){
				case 'm':
				case 'M':
					{
						return ValueType.DecimalNumber;
					}break;
				case 'f':
				case 'F':
					{
						return ValueType.FloatingNumber;
					}break;
				case 'l':
				case 'L':
					{
						if(a_string[0] == '-'){
							return ValueType.SignedNumber;
						}else{
							return ValueType.UnsignedNumber;
						}
					}break;
				}
				#pragma warning restore
			}

			//ピリオドがある場合は浮動小数。
			for(int ii=0;ii<a_string.Length;ii++){
				if(a_string[ii] == Config.FLOATING_SEPARATOR){
					return ValueType.FloatingNumber;
				}
			}

			//マイナス符号がある場合は符号あり整数。
			if(a_string[0] == '-'){
				return ValueType.SignedNumber;
			}

			return ValueType.UnsignedNumber;
		}
	}
}

