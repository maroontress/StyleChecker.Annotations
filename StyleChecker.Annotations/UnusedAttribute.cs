namespace StyleChecker.Annotations
{
    using System;

    /// <include file='docs.xml'
    /// path='docs/members[@name="Unused"]/UnusedAttribute/*'/>
    [AttributeUsage(
        AttributeTargets.Parameter,
        Inherited = false,
        AllowMultiple = false)]
    public sealed class UnusedAttribute : Attribute
    {
    }
}
