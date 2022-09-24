using Newtonsoft.Json.Linq;

// ReSharper disable UnusedMember.Global

namespace JsonPatchMaker.Core.Validation
{
    internal class CustomCheckEqualityComparer : IEqualityComparer<JToken>
    {
        private readonly bool _enableIdCheck;
        private readonly IEqualityComparer<JToken> _inner;

        public CustomCheckEqualityComparer(bool enableIdCheck, IEqualityComparer<JToken> inner)
        {
            _enableIdCheck = enableIdCheck;
            _inner = inner;
        }

        public bool Equals(JToken x, JToken y)
        {
            if (!_enableIdCheck || x?.Type != JTokenType.Object || y?.Type != JTokenType.Object)
                return _inner.Equals(x, y);
            var str1 = x["id"]?.Value<string>();
            var str2 = y["id"]?.Value<string>();
            if (str1 != null && str1 == str2)
                return true;
            return _inner.Equals(x, y);
        }

        public int GetHashCode(JToken obj)
        {
            if (!_enableIdCheck || obj.Type != JTokenType.Object) return _inner.GetHashCode(obj);
            var jToken = obj["id"];
            var str = jToken is not { HasValues: true } ? null : jToken.Value<string>();
            if (str != null)
                return str.GetHashCode() + _inner.GetHashCode(obj);
            return _inner.GetHashCode(obj);
        }

        public static bool HaveEqualIds(JToken x, JToken y)
        {
            if (x.Type != JTokenType.Object || y.Type != JTokenType.Object)
                return false;
            var str1 = x["id"]?.Value<string>();
            var str2 = y["id"]?.Value<string>();
            return str1 != null && str1 == str2;
        }
    }
}