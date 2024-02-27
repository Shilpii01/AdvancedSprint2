using Newtonsoft.Json;

namespace AdvancedTaskSpecflow.Utilities
{
    public class JsonReader
    {

        public static List<T> ReadTestDataFromJson<T>(string jsonFilePath)
        {
            string jsonContent = File.ReadAllText(jsonFilePath);
            List<T> testData = JsonConvert.DeserializeObject<List<T>>(jsonContent);
            return testData;
        }
    }
}
