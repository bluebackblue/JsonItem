

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief 値。
*/


/** BlueBack.JsonItem
*/
namespace BlueBack.JsonItem
{
	/** using
	*/
	using SignedNumberType = System.Int64;
	using UnsignedNumberType = System.UInt64;
	using FloatingNumberType = System.Double;

	/** Value
	*/
	public struct Value
	{
		/** タイプ。
		*/
		public ValueType valuetype;

		/** 値。
		*/
		public System.Object raw;

		/** タイプチェック。
		*/
		public bool IsNull()
		{
			if(this.valuetype == ValueType.Null){
				return true;
			}
			return false;
		}

		/** タイプチェック。
		*/
		public bool IsAssociativeArray()
		{
			if(this.valuetype == ValueType.AssociativeArray){
				return true;
			}
			return false;
		}

		/** タイプチェック。
		*/
		public bool IsIndexArray()
		{
			if(this.valuetype == ValueType.IndexArray){
				return true;
			}
			return false;
		}

		/** タイプチェック。
		*/
		public bool IsStringData()
		{
			if(this.valuetype == ValueType.StringData){
				return true;
			}
			return false;
		}

		/** タイプチェック。
		*/
		public bool IsSignedNumber()
		{
			if(this.valuetype == ValueType.SignedNumber){
				return true;
			}
			return false;
		}

		/** タイプチェック。
		*/
		public bool IsUnSignedNumber()
		{
			if(this.valuetype == ValueType.UnsignedNumber){
				return true;
			}
			return false;
		}


		/** タイプチェック。
		*/
		public bool IsFloatingNumber()
		{
			if(this.valuetype == ValueType.FloatingNumber){
				return true;
			}
			return false;
		}


		/** タイプチェック。
		*/
		public bool IsBoolData()
		{
			if(this.valuetype == ValueType.BoolData){
				return true;
			}
			return false;
		}

		/** タイプチェック。
		*/
		public bool IsDecimalNumber()
		{
			if(this.valuetype == ValueType.DecimalNumber){
				return true;
			}
			return false;
		}

		/** タイプチェック。
		*/
		public bool IsBinaryData()
		{
			if(this.valuetype == ValueType.BinaryData){
				return true;
			}
			return false;
		}

		/** リセット。
		*/
		public void ResetFromType(ValueType a_valuetype)
		{
			this.valuetype = a_valuetype;
			this.raw = null;
		}

		/** 設定。
		*/
		public void Reset(System.Collections.Generic.Dictionary<string,JsonItem> a_raw)
		{
			this.valuetype = ValueType.AssociativeArray;
			this.raw = a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.Collections.Generic.List<JsonItem> a_raw)
		{
			this.valuetype = ValueType.IndexArray;
			this.raw = a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.String a_raw)
		{
			this.valuetype = ValueType.StringData;
			this.raw = a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.Char a_raw)
		{
			this.valuetype = ValueType.SignedNumber;
			this.raw = (SignedNumberType)a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.SByte a_raw)
		{
			this.valuetype = ValueType.SignedNumber;
			this.raw = (SignedNumberType)a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.Byte a_raw)
		{
			this.valuetype = ValueType.SignedNumber;
			this.raw = (SignedNumberType)a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.Int16 a_raw)
		{
			this.valuetype = ValueType.SignedNumber;
			this.raw = (SignedNumberType)a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.UInt16 a_raw)
		{
			this.valuetype = ValueType.SignedNumber;
			this.raw = (SignedNumberType)a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.Int32 a_raw)
		{
			this.valuetype = ValueType.SignedNumber;
			this.raw = (SignedNumberType)a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.UInt32 a_raw)
		{
			this.valuetype = ValueType.SignedNumber;
			this.raw = (SignedNumberType)a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.Int64 a_raw)
		{
			this.valuetype = ValueType.SignedNumber;
			this.raw = (SignedNumberType)a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.UInt64 a_raw)
		{
			this.valuetype = ValueType.UnsignedNumber;
			this.raw = (UnsignedNumberType)a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.Single a_raw)
		{
			this.valuetype = ValueType.FloatingNumber;
			this.raw = (FloatingNumberType)a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.Double a_raw)
		{
			this.valuetype = ValueType.FloatingNumber;
			this.raw = (FloatingNumberType)a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.Boolean a_raw)
		{
			this.valuetype = ValueType.BoolData;
			this.raw = a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.Decimal a_raw)
		{
			this.valuetype = ValueType.DecimalNumber;
			this.raw = (System.Decimal)a_raw;
		}

		/** 設定。
		*/
		public void Reset(System.Collections.Generic.List<byte> a_raw)
		{
			this.valuetype = ValueType.BinaryData;
			this.raw = a_raw;
		}

		/** GetAssociativeArray
		*/
		public System.Collections.Generic.Dictionary<string,JsonItem> GetAssociativeArray()
		{
			#if(DEF_BLUEBACK_DEBUG_ASSERT)
			DebugTool.Assert(this.valuetype == ValueType.AssociativeArray);
			#endif

			return (System.Collections.Generic.Dictionary<string,JsonItem>)this.raw;
		}

		/** GetIndexArray
		*/
		public System.Collections.Generic.List<JsonItem> GetIndexArray()
		{
			#if(DEF_BLUEBACK_DEBUG_ASSERT)
			DebugTool.Assert(this.valuetype == ValueType.IndexArray);
			#endif

			return (System.Collections.Generic.List<JsonItem>)this.raw;
		}

		/** GetStringData
		*/
		public string GetStringData()
		{
			#if(DEF_BLUEBACK_DEBUG_ASSERT)
			DebugTool.Assert(this.valuetype == ValueType.StringData);
			#endif

			return (string)this.raw;
		}

		/** GetSignedNumber
		*/
		public SignedNumberType GetSignedNumber()
		{
			#if(DEF_BLUEBACK_DEBUG_ASSERT)
			DebugTool.Assert(this.valuetype == ValueType.SignedNumber);
			#endif

			return (SignedNumberType)this.raw;
		}

		/** GetUnsignedNumber
		*/
		public UnsignedNumberType GetUnsignedNumber()
		{
			#if(DEF_BLUEBACK_DEBUG_ASSERT)
			DebugTool.Assert(this.valuetype == ValueType.UnsignedNumber);
			#endif

			return (UnsignedNumberType)this.raw;
		}

		/** GetFloatingNumber
		*/
		public FloatingNumberType GetFloatingNumber()
		{
			#if(DEF_BLUEBACK_DEBUG_ASSERT)
			DebugTool.Assert(this.valuetype == ValueType.FloatingNumber);
			#endif

			return (FloatingNumberType)this.raw;
		}

		/** GetBoolData
		*/
		public System.Boolean GetBoolData()
		{
			#if(DEF_BLUEBACK_DEBUG_ASSERT)
			DebugTool.Assert(this.valuetype == ValueType.BoolData);
			#endif

			return (System.Boolean)this.raw;
		}

		/** GetDecimalNumber
		*/
		public decimal GetDecimalNumber()
		{
			#if(DEF_BLUEBACK_DEBUG_ASSERT)
			DebugTool.Assert(this.valuetype == ValueType.DecimalNumber);
			#endif

			return (System.Decimal)this.raw;
		}

		/** GetBinaryData
		*/
		public System.Collections.Generic.List<byte> GetBinaryData()
		{
			#if(DEF_BLUEBACK_DEBUG_ASSERT)
			DebugTool.Assert(this.valuetype == ValueType.BinaryData);
			#endif

			return (System.Collections.Generic.List<byte>)this.raw;
		}

		/** CastToChar
		*/
		public System.Char CastToChar()
		{
			#pragma warning disable 0162
			switch(this.valuetype){
			case ValueType.SignedNumber:
				{
					return (System.Char)(SignedNumberType)this.raw;
				}break;
			case ValueType.UnsignedNumber:
				{
					return (System.Char)(UnsignedNumberType)this.raw;
				}break;
			case ValueType.FloatingNumber:
				{
					return (System.Char)(FloatingNumberType)this.raw;
				}break;
			case ValueType.DecimalNumber:
				{
					return (System.Char)(System.Decimal)this.raw;
				}break;
			case ValueType.BoolData:
				{
					return ((System.Boolean)this.raw ? (System.Char)1 : (System.Char)0);
				}break;
			default:
				{
					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",this.valuetype));
					#endif

					return default;
				}break;
			}
			#pragma warning restore
		}

		/** CastToSbyte
		*/
		public System.SByte CastToSbyte()
		{
			#pragma warning disable 0162
			switch(this.valuetype){
			case ValueType.SignedNumber:
				{
					return (System.SByte)(SignedNumberType)this.raw;
				}break;
			case ValueType.UnsignedNumber:
				{
					return (System.SByte)(UnsignedNumberType)this.raw;
				}break;
			case ValueType.FloatingNumber:
				{
					return (System.SByte)(UnsignedNumberType)this.raw;
				}break;
			case ValueType.DecimalNumber:
				{
					return (System.SByte)(System.Decimal)this.raw;
				}break;
			case ValueType.BoolData:
				{
					return ((System.Boolean)this.raw ? (System.SByte)1 : (System.SByte)0);
				}break;
			default:
				{
					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",this.valuetype));
					#endif

					return default;
				}break;
			}
			#pragma warning restore
		}

		/** CastToByte
		*/
		public System.Byte CastToByte()
		{
			#pragma warning disable 0162
			switch(this.valuetype){
			case ValueType.SignedNumber:
				{
					return (System.Byte)(SignedNumberType)this.raw;
				}break;
			case ValueType.UnsignedNumber:
				{
					return (System.Byte)(UnsignedNumberType)this.raw;
				}break;
			case ValueType.FloatingNumber:
				{
					return (System.Byte)(FloatingNumberType)this.raw;
				}break;
			case ValueType.DecimalNumber:
				{
					return (System.Byte)(System.Decimal)this.raw;
				}break;
			case ValueType.BoolData:
				{
					return ((System.Boolean)this.raw ? (System.Byte)1 : (System.Byte)0);
				}break;
			default:
				{
					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",this.valuetype));
					#endif

					return default;
				}break;
			}
			#pragma warning restore
		}

		/** CastToInt16
		*/
		public System.Int16 CastToInt16()
		{
			#pragma warning disable 0162
			switch(this.valuetype){
			case ValueType.SignedNumber:
				{
					return (System.Int16)(SignedNumberType)this.raw;
				}break;
			case ValueType.UnsignedNumber:
				{
					return (System.Int16)(UnsignedNumberType)this.raw;
				}break;
			case ValueType.FloatingNumber:
				{
					return (System.Int16)(FloatingNumberType)this.raw;
				}break;
			case ValueType.DecimalNumber:
				{
					return (System.Int16)(System.Decimal)this.raw;
				}break;
			case ValueType.BoolData:
				{
					return ((System.Boolean)this.raw ? (System.Int16)1 : (System.Int16)0);
				}break;
			default:
				{
					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",this.valuetype));
					#endif

					return default;
				}break;
			}
			#pragma warning restore
		}

		/** CastToUint16
		*/
		public System.UInt16 CastToUint16()
		{
			#pragma warning disable 0162
			switch(this.valuetype){
			case ValueType.SignedNumber:
				{
					return (System.UInt16)(SignedNumberType)this.raw;
				}break;
			case ValueType.UnsignedNumber:
				{
					return (System.UInt16)(UnsignedNumberType)this.raw;
				}break;
			case ValueType.FloatingNumber:
				{
					return (System.UInt16)(FloatingNumberType)this.raw;
				}break;
			case ValueType.DecimalNumber:
				{
					return (System.UInt16)(System.Decimal)this.raw;
				}break;
			case ValueType.BoolData:
				{
					return ((System.Boolean)this.raw ? (System.UInt16)1 : (System.UInt16)0);
				}break;
			default:
				{
					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",this.valuetype));
					#endif

					return default;
				}break;
			}
			#pragma warning restore
		}

		/** CastToInt32
		*/
		public System.Int32 CastToInt32()
		{
			#pragma warning disable 0162
			switch(this.valuetype){
			case ValueType.SignedNumber:
				{
					return (System.Int32)(SignedNumberType)this.raw;
				}break;
			case ValueType.UnsignedNumber:
				{
					return (System.Int32)(UnsignedNumberType)this.raw;
				}break;
			case ValueType.FloatingNumber:
				{
					return (System.Int32)(FloatingNumberType)this.raw;
				}break;
			case ValueType.DecimalNumber:
				{
					return (System.Int32)(System.Decimal)this.raw;
				}break;
			case ValueType.BoolData:
				{
					return ((System.Boolean)this.raw ? (System.Int32)1 : (System.Int32)0);
				}break;
			default:
				{
					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",this.valuetype));
					#endif

					return default;
				}break;
			}
			#pragma warning restore
		}

		/** CastToUint32
		*/
		public System.UInt32 CastToUint32()
		{
			#pragma warning disable 0162
			switch(this.valuetype){
			case ValueType.SignedNumber:
				{
					return (System.UInt32)(SignedNumberType)this.raw;
				}break;
			case ValueType.UnsignedNumber:
				{
					return (System.UInt32)(UnsignedNumberType)this.raw;
				}break;
			case ValueType.FloatingNumber:
				{
					return (System.UInt32)(FloatingNumberType)this.raw;
				}break;
			case ValueType.DecimalNumber:
				{
					return (System.UInt32)(System.Decimal)this.raw;
				}break;
			case ValueType.BoolData:
				{
					return ((System.Boolean)this.raw ? (System.UInt32)1 : (System.UInt32)0);
				}break;
			default:
				{
					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",this.valuetype));
					#endif

					return default;
				}break;
			}
			#pragma warning restore
		}

		/** CastToInt64
		*/
		public System.Int64 CastToInt64()
		{
			#pragma warning disable 0162
			switch(this.valuetype){
			case ValueType.SignedNumber:
				{
					return (System.Int64)(SignedNumberType)this.raw;
				}break;
			case ValueType.UnsignedNumber:
				{
					return (System.Int64)(UnsignedNumberType)this.raw;
				}break;
			case ValueType.FloatingNumber:
				{
					return (System.Int64)(FloatingNumberType)this.raw;
				}break;
			case ValueType.DecimalNumber:
				{
					return (System.Int64)(System.Decimal)this.raw;
				}break;
			case ValueType.BoolData:
				{
					return ((System.Boolean)this.raw ? (System.Int64)1 : (System.Int64)0);
				}break;
			default:
				{
					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",this.valuetype));
					#endif

					return default;
				}break;
			}
			#pragma warning restore
		}

		/** CastToUint64
		*/
		public System.UInt64 CastToUint64()
		{
			#pragma warning disable 0162
			switch(this.valuetype){
			case ValueType.SignedNumber:
				{
					return (System.UInt64)(SignedNumberType)this.raw;
				}break;
			case ValueType.UnsignedNumber:
				{
					return (System.UInt64)(UnsignedNumberType)this.raw;
				}break;
			case ValueType.FloatingNumber:
				{
					return (System.UInt64)(FloatingNumberType)this.raw;
				}break;
			case ValueType.DecimalNumber:
				{
					return (System.UInt64)(System.Decimal)this.raw;
				}break;
			case ValueType.BoolData:
				{
					return ((System.Boolean)this.raw ? (System.UInt64)1 : (System.UInt64)0);
				}break;
			default:
				{
					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",this.valuetype));
					#endif

					return default;
				}break;
			}
			#pragma warning restore
		}

		/** CastToSingle
		*/
		public System.Single CastToSingle()
		{
			#pragma warning disable 0162
			switch(this.valuetype){
			case ValueType.SignedNumber:
				{
					return (System.Single)(SignedNumberType)this.raw;
				}break;
			case ValueType.FloatingNumber:
				{
					return (System.Single)(FloatingNumberType)this.raw;
				}break;
			case ValueType.UnsignedNumber:
				{
					return (System.Single)(UnsignedNumberType)this.raw;
				}break;
			case ValueType.DecimalNumber:
				{
					return (System.Single)(System.Decimal)this.raw;
				}break;
			case ValueType.BoolData:
				{
					return ((System.Boolean)this.raw ? (System.Single)1 : (System.Single)0);
				}break;
			default:
				{
					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",this.valuetype));
					#endif

					return default;
				}break;
			}
			#pragma warning restore
		}

		/** CastToDouble
		*/
		public System.Double CastToDouble()
		{
			#pragma warning disable 0162
			switch(this.valuetype){
			case ValueType.SignedNumber:
				{
					return (System.Double)(SignedNumberType)this.raw;
				}break;
			case ValueType.FloatingNumber:
				{
					return (System.Double)(FloatingNumberType)this.raw;
				}break;
			case ValueType.UnsignedNumber:
				{
					return (System.Double)(UnsignedNumberType)this.raw;
				}break;
			case ValueType.DecimalNumber:
				{
					return (System.Double)(System.Decimal)this.raw;
				}break;
			case ValueType.BoolData:
				{
					return ((System.Boolean)this.raw ? (System.Double)1 : (System.Double)0);
				}break;
			default:
				{
					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",this.valuetype));
					#endif

					return default;
				}break;
			}
			#pragma warning restore
		}

		/** CastToBoolData
		*/
		public System.Boolean CastToBoolData()
		{
			#pragma warning disable 0162
			switch(this.valuetype){
			case ValueType.SignedNumber:
				{
					return ((SignedNumberType)this.raw > 0) ? (System.Boolean)true : (System.Boolean)false;
				}break;
			case ValueType.FloatingNumber:
				{
					return ((FloatingNumberType)this.raw > 0) ? (System.Boolean)true : (System.Boolean)false;
				}break;
			case ValueType.UnsignedNumber:
				{
					return ((UnsignedNumberType)this.raw > 0) ? (System.Boolean)true : (System.Boolean)false;
				}break;
			case ValueType.DecimalNumber:
				{
					return ((System.Decimal)this.raw > 0) ? (System.Boolean)true : (System.Boolean)false;
				}break;
			case ValueType.BoolData:
				{
					return (System.Boolean)this.raw;
				}break;
			default:
				{
					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",this.valuetype));
					#endif

					return default;
				}break;
			}
			#pragma warning restore
		}

		/** CastToDecimal
		*/
		public System.Decimal CastToDecimal()
		{
			#pragma warning disable 0162
			switch(this.valuetype){
			case ValueType.SignedNumber:
				{
					return (System.Decimal)(SignedNumberType)this.raw;
				}break;
			case ValueType.UnsignedNumber:
				{
					return (System.Decimal)(UnsignedNumberType)this.raw;
				}break;
			case ValueType.FloatingNumber:
				{
					return (System.Decimal)(FloatingNumberType)this.raw;
				}break;
			case ValueType.DecimalNumber:
				{
					return (System.Decimal)this.raw;
				}break;
			case ValueType.BoolData:
				{
					return ((System.Boolean)this.raw ? (System.Decimal)1 : (System.Decimal)0);
				}break;
			default:
				{
					#if(DEF_BLUEBACK_DEBUG_ASSERT)
					DebugTool.Assert(false,string.Format("{0}",this.valuetype));
					#endif

					return default;
				}break;
			}
			#pragma warning restore
		}
	}

	/** 連想配列。
	*/
	public readonly struct Value_AssociativeArray
	{
	}

	/** インデックス配列。
	*/
	public readonly struct Value_IndexArray
	{
	}

	/** Value_StringData
	*/
	public readonly struct Value_StringData
	{
		readonly public string value;
		public Value_StringData(string a_value)
		{
			this.value = a_value;
		}
	}

	/** 数値。

		System.Char
		System.SByte
		System.Byte
		System.Int16
		System.UInt16
		System.Int32
		System.UInt32
		System.Int64

		System.UInt64

		System.Single
		System.Double

		System.Boolean

		System.Decimal

	*/
	public readonly struct Value_Number<T>
	{
		readonly public T value;
		public Value_Number(T a_value)
		{
			this.value = a_value;
		}
	}

	/** Value_BinaryData
	*/
	public readonly struct Value_BinaryData
	{
		readonly public System.Collections.Generic.List<byte> value;
		public Value_BinaryData(System.Collections.Generic.List<byte> a_value)
		{
			this.value = a_value;
		}
	}
}

