
///<summary>
/// The old way of doing generic attributes
///</summary>
///
public class OldGenericAttribute : Attribute
{
    public OldGenericAttribute(Type t) => ParameterType = t;

    public Type ParameterType { get; }
}