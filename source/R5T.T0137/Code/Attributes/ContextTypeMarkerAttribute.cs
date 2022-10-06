using System;

using R5T.T0143;


namespace R5T.T0137
{
    /// <summary>
    /// Attribute indicating a class is a context type (either class or interface).
    /// A context type is useful as the input type for Action{T} and Func{T} parameters in higher-order functions.
    /// The marker attribute is useful for surveying context implementation classes and building a catalogue of those classes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Enum, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class ContextTypeMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsContextType;
        /// <summary>
        /// Allows specifying that a class is *not* a context type.
        /// This is useful for marking classes that end up canonical context type code file locations, but are not context type classes.
        /// </summary>
        public bool IsContextType
        {
            get
            {
                return this.zIsContextType;
            }
        }


        public ContextTypeMarkerAttribute(
            bool isContextType = true)
        {
            this.zIsContextType = isContextType;
        }
    }
}
