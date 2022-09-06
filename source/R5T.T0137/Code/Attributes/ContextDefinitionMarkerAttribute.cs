using System;

using R5T.T0143;


namespace R5T.T0137
{
    /// <summary>
    /// Attribute indicating a class or interface is a context definition.
    /// The marker attribute is useful for surveying context definition types and building a catalogue of those types.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class ContextDefinitionMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsContextDefinition;
        /// <summary>
        /// Allows specifying that a class or interface is *not* a context definition.
        /// This is useful for marking classes or interfaces that end up canonical context definition code file locations, but are not context definitions classes.
        /// </summary>
        public bool IsContextDefinition
        {
            get
            {
                return this.zIsContextDefinition;
            }
        }


        public ContextDefinitionMarkerAttribute(
            bool isContextDefinition = true)
        {
            this.zIsContextDefinition = isContextDefinition;
        }
    }
}
