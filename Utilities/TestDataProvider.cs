using Newtonsoft.Json;

public static class TestDataProvider
{
    public static IEnumerable<TestCaseData> GetTestData<T>(string testDataFile) where T : class, new()
    {
        if (string.IsNullOrEmpty(testDataFile))
        {
            throw new ArgumentException("Test data file path cannot be null or empty.");
        }

        //if (!File.Exists(testDataFile))
        //{
        //    throw new FileNotFoundException($"Test data file not found: {testDataFile}");
        //}

        //Console.WriteLine($"Reading test data from: {testDataFile}");
        
        // Read the JSON file and deserialize it into a list of TestCaseData
        var jsonData = File.ReadAllText(@$"TestData\{testDataFile}");
        var testDataList = JsonConvert.DeserializeObject<List<T>>(jsonData);

        foreach (var data in testDataList)
        {
            yield return new TestCaseData(data);
        }
    }

}

public class Sprint1TestData
{
    public string FirstName { get; set; }
}

public class Sprint2TestData
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class Sprint3TestData
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
}