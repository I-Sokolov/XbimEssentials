using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
using static Xbim.Ifc4.Functions;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.StructuralLoadResource
{
	public partial class IfcStructuralLoadConfiguration : IExpressValidatable
	{
		private static readonly ILog Log = LogManager.GetLogger("Xbim.Ifc4.StructuralLoadResource.IfcStructuralLoadConfiguration");

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(Where.IfcStructuralLoadConfiguration clause) {
			var retVal = false;
			if (clause == Where.IfcStructuralLoadConfiguration.ValidListSize) {
				try {
					retVal = !EXISTS(Locations) || (SIZEOF(Locations) == SIZEOF(Values));
				} catch (Exception ex) {
					Log.Error($"Exception thrown evaluating where-clause 'IfcStructuralLoadConfiguration.ValidListSize' for #{EntityLabel}.", ex);
				}
				return retVal;
			}
			throw new ArgumentException($"Invalid clause specifier: '{clause}'", nameof(clause));
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(Where.IfcStructuralLoadConfiguration.ValidListSize))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStructuralLoadConfiguration.ValidListSize", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.Where
{
	public class IfcStructuralLoadConfiguration
	{
		public static readonly IfcStructuralLoadConfiguration ValidListSize = new IfcStructuralLoadConfiguration();
		protected IfcStructuralLoadConfiguration() {}
	}
}