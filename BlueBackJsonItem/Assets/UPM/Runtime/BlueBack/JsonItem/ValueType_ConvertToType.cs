

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief タイプ。
*/


/** BlueBack.JsonItem
*/
namespace BlueBack.JsonItem
{
	/** JsonItemからコンバート先の型を決める
	*/
	public static class ValueType_ConvertToType
	{
		/** Get
		*/
		public static System.Type Get(BlueBack.JsonItem.JsonItem a_jsonitem)
		{
			#pragma warning disable 0162
			switch(a_jsonitem.GetValueType()){
			case ValueType.Null:
				{
					//値型が不明なので値型はSystem.Objectにする。
					return typeof(System.Object);
				}break;
			case ValueType.AssociativeArray:
				{
					//値型が不明なので値型はSystem.Objectにする。
					return typeof(System.Collections.Generic.Dictionary<string,System.Object>);
				}break;
			case ValueType.IndexArray:
				{
					//値型が不明なので値型はSystem.Objectにする。
					return typeof(System.Collections.Generic.List<System.Object>);
				}break;
			case ValueType.StringData:
				{
					return typeof(System.String);
				}break;
			case ValueType.SignedNumber:
				{
					return JsonItem.GetSignedNumberType();
				}break;
			case ValueType.UnsignedNumber:
				{
					return JsonItem.GetUnsignedNumberType();
				}break;
			case ValueType.FloatingNumber:
				{
					return JsonItem.GetFloatingNumberType();
				}break;
			case ValueType.BoolData:
				{
					return typeof(System.Boolean);
				}break;
			case ValueType.DecimalNumber:
				{
					return typeof(System.Decimal);
				}break;
			case ValueType.BinaryData:
				{
					return typeof(System.Collections.Generic.List<byte>);
				}break;
			default:
				{
					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",a_jsonitem.GetValueType()));
					#endif

					return null;
				}break;
			}
			#pragma warning restore
		}
	}
}

