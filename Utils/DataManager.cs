using Newtonsoft.Json;

namespace UserinterfaceTest.Utils
{
    public static class DataManager
    {
        private static string path = "Resources\\TestData.json";
        public static TestDataModel dataObject = JsonConvert.DeserializeObject<TestDataModel>(File.ReadAllText(path));
    }
}
