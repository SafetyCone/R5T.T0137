using System;


namespace R5T.T0137
{
    /// <summary>
    /// Attribute indicating a class is a context implementation.
    /// The marker attribute is useful for surveying context implementation classes and building a catalogue of those classes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ContextImplementationMarkerAttribute : Attribute
    {
        private readonly bool zIsContextImplementation;
        /// <summary>
        /// Allows specifying that a class is *not* a context implementation.
        /// This is useful for marking classes that end up canonical context implementation code file locations, but are not context implementation classes.
        /// </summary>
        public bool IsContextImplementation
        {
            get
            {
                return this.zIsContextImplementation;
            }
        }


        public ContextImplementationMarkerAttribute(
            bool isContextImplementation = true)
        {
            this.zIsContextImplementation = isContextImplementation;
        }
    }
}
