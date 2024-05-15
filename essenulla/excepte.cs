public Task<string[]> GetEmptyStringArray()
{
    // Returns an empty string array as a completed task
    return Task.FromResult(Array.Empty<string>());
}
