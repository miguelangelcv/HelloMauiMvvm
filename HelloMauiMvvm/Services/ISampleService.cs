namespace HelloMauiMvvm.Services
{
    public interface ISampleService
    {
        IEnumerable<string> GetSampleStrings();
        string GetRandomString();
    }
}
