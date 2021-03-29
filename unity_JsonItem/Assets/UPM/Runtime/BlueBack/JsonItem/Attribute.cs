

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief 属性。
*/


/** BlueBack.JsonItem
*/
namespace BlueBack.JsonItem
{
	/** コンバート時に除外する。
	*/
	public class Ignore : System.Attribute
	{
	}

	/** Enumを文字データとして出力する。
	*/
	public class EnumString : System.Attribute
	{
	}

	/** Enumを数値として出力する。
	*/
	public class EnumInt : System.Attribute
	{
	}
}

