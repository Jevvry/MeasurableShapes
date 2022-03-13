using JetBrains.Annotations;

namespace MeasurableShapes
{
    [PublicAPI]
    public interface IMeasurableShape
    {
        double Area { get; }
    }
}