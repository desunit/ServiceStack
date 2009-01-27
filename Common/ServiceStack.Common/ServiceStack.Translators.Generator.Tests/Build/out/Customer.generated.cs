namespace ServiceStack.Translators.Generator.Tests.Support.DataContract
{
	using System;
	using System.Collections.Generic;
	
	
	public partial class Customer
	{
		
		public virtual ServiceStack.Translators.Generator.Tests.Support.Model.Customer ToModel()
		{
			return this.UpdateModel(new ServiceStack.Translators.Generator.Tests.Support.Model.Customer());
		}
		
		public static System.Collections.Generic.List<ServiceStack.Translators.Generator.Tests.Support.Model.Customer> ToModelList(System.Collections.Generic.IEnumerable<ServiceStack.Translators.Generator.Tests.Support.DataContract.Customer> from)
		{
			if ((from == null))
			{
				return null;
			}
			System.Collections.Generic.List<ServiceStack.Translators.Generator.Tests.Support.Model.Customer> to = new System.Collections.Generic.List<ServiceStack.Translators.Generator.Tests.Support.Model.Customer>();
			for (System.Collections.Generic.IEnumerator<ServiceStack.Translators.Generator.Tests.Support.DataContract.Customer> iter = from.GetEnumerator(); iter.MoveNext(); 
			)
			{
				ServiceStack.Translators.Generator.Tests.Support.DataContract.Customer item = iter.Current;
				if ((item != null))
				{
					to.Add(item.ToModel());
				}
			}
			return to;
		}
		
		public virtual ServiceStack.Translators.Generator.Tests.Support.Model.Customer UpdateModel(ServiceStack.Translators.Generator.Tests.Support.Model.Customer model)
		{
			ServiceStack.Translators.Generator.Tests.Support.DataContract.Customer from = this;
			model.Id = from.Id;
			model.Name = from.Name;
			if ((this.BillingAddress != null))
			{
				model.BillingAddress = this.BillingAddress.ToModel();
			}
			model.PhoneNumbers = ServiceStack.Translators.Generator.Tests.Support.DataContract.PhoneNumber.ToModelList(this.PhoneNumbers);
			// Skipping property 'model.ModelReadOnly' because 'model.ModelReadOnly' is read-only
			model.ModelWriteOnly = from.ModelWriteOnly;
			model.DtoReadOnly = from.DtoReadOnly;
			// Skipping property 'model.DtoWriteOnly' because 'this.DtoWriteOnly' is write-only
			return model;
		}
		
		public static ServiceStack.Translators.Generator.Tests.Support.DataContract.Customer Parse(ServiceStack.Translators.Generator.Tests.Support.Model.Customer from)
		{
			if ((from == null))
			{
				return null;
			}
			ServiceStack.Translators.Generator.Tests.Support.DataContract.Customer to = new ServiceStack.Translators.Generator.Tests.Support.DataContract.Customer();
			to.Id = from.Id;
			to.Name = from.Name;
			to.BillingAddress = ServiceStack.Translators.Generator.Tests.Support.DataContract.Address.Parse(from.BillingAddress);
			to.PhoneNumbers = ServiceStack.Translators.Generator.Tests.Support.DataContract.PhoneNumber.ParseAll(from.PhoneNumbers);
			to.ModelReadOnly = from.ModelReadOnly;
			// Skipping property 'to.ModelWriteOnly' because 'model.ModelWriteOnly' is write-only
			// Skipping property 'to.DtoReadOnly' because 'to.DtoReadOnly' is read-only
			to.DtoWriteOnly = from.DtoWriteOnly;
			return to;
		}
		
		public static System.Collections.Generic.List<ServiceStack.Translators.Generator.Tests.Support.DataContract.Customer> ParseAll(System.Collections.Generic.IEnumerable<ServiceStack.Translators.Generator.Tests.Support.Model.Customer> from)
		{
			if ((from == null))
			{
				return null;
			}
			System.Collections.Generic.List<ServiceStack.Translators.Generator.Tests.Support.DataContract.Customer> to = new System.Collections.Generic.List<ServiceStack.Translators.Generator.Tests.Support.DataContract.Customer>();
			for (System.Collections.Generic.IEnumerator<ServiceStack.Translators.Generator.Tests.Support.Model.Customer> iter = from.GetEnumerator(); iter.MoveNext(); 
			)
			{
				ServiceStack.Translators.Generator.Tests.Support.Model.Customer item = iter.Current;
				to.Add(ServiceStack.Translators.Generator.Tests.Support.DataContract.Customer.Parse(item));
			}
			return to;
		}
	}
}