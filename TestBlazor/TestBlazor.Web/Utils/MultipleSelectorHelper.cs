namespace TestBlazor.Web.Utils
{
    public struct MultipleSelectorHelper
    {
        public MultipleSelectorHelper(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}
