﻿using System.Collections.Generic;
namespace HookMeUP.iOS
{
	class VoucherCount
	{

		public bool IsVoucherDepleted
		{
			get;
			private set;
		}
		public bool IsVoucherNegative
		{
			get;
			private set;
		}

		public int Voucher
		{
			get;
			set;
		}

		public double Price
		{
			get;
			set;
		}

		public bool IsSelected
		{
			get;
			set;
		}

		public bool IsDeselected
		{
			get;
			set;
		}

		public void VoucherChange()
		{

			if (Voucher > 0)
			{
				IsVoucherNegative = false;
				IsVoucherDepleted = false;

			}
			//else if (Voucher == 0) IsVoucherDepleted = true;
			else
			{
				IsVoucherNegative = true;
				IsVoucherDepleted = false;
			}

			if (IsSelected && !IsVoucherNegative) --Voucher;
			if (IsDeselected) ++Voucher;
		}

		public int GetVoucher()
		{
			return Voucher;
		}
	}

	public class TagOrder
	{
		public bool HasTag
		{
			get;
			set;
		}

		public string OrderName
		{
			get;
			set;
		}

		public TagOrder(string orderName, bool hasTag)
		{
			OrderName = orderName;
			HasTag = hasTag;		
		}

	}
}

