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
    public class DraftContextTypeMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsDraftContextType;
        /// <summary>
        /// Allows specifying that a class is *not* a context type.
        /// This is useful for marking classes that end up canonical context type code file locations, but are not context type classes.
        /// </summary>
        public bool IsDraftContextType
        {
            get
            {
                return this.zIsDraftContextType;
            }
        }


        public DraftContextTypeMarkerAttribute(
            bool isDraftContextType = true)
        {
            this.zIsDraftContextType = isDraftContextType;
        }
    }
}
