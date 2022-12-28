private static string RunBash(string command)
{
    ProcessStartInfo startInfo = new ProcessStartInfo
    {
        FileName = "bash",
        Arguments = $"-c \"{command}\"",
        RedirectStandardOutput = true,
        UseShellExecute = false,
        CreateNoWindow = true
    };

    Process process = new Process
    {
        StartInfo = startInfo
    };

    process.Start();
    string output = process.StandardOutput.ReadToEnd();
    process.WaitForExit();

    return output;
}