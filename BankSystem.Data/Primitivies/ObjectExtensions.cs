using System.Reflection;

namespace BankSystem.Data.Primitivies;

public static class ObjectExtensions
{
    public static bool AreAllPropertiesSet(this object obj)
    {
        return obj.GetType()
            .GetProperties()
            .All(p => p.GetValue(obj) != null && !IsDefaultValue(p.GetValue(obj)));
    }

    private static bool IsDefaultValue(object value)
    {
        if (value is null) return true;
        var type = value.GetType();
        if (type.IsValueType)
        {
            var defaultValue = Activator.CreateInstance(type);
            return value.Equals(defaultValue);
        }

        return false;
    }
}