// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.QuantityResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.QuantityResource
{
	[ExpressType("IfcPhysicalSimpleQuantity", 858)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPhysicalSimpleQuantity : IfcPhysicalQuantity, IEquatable<@IfcPhysicalSimpleQuantity>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPhysicalSimpleQuantity(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcNamedUnit _unit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcNamedUnit @Unit 
		{ 
			get 
			{
				if(_activated) return _unit;
				Activate();
				return _unit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _unit = v, _unit, value,  "Unit", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_unit = (IfcNamedUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPhysicalSimpleQuantity other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}