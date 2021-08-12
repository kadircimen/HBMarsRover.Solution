namespace MarsRover.Entities.Enums
{
    public enum Directions
    {
        N,
        S,
        E,
        W
    }
    public static class EnumMethods
    {
        public static T ToEnumValue<T>(this string value) where T : System.Enum
        {
            try
            {
                return (T)System.Enum.Parse(typeof(T), value);
            }
            catch
            {
                return default;
            }
        }
    }
}
