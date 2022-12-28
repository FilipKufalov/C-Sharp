private static string RunCMD(string command)
{
    Process proc = new Process();
    proc.StartInfo.FileName = "cmd.exe";
    proc.StartInfo.Arguments = "/c " + command;
    proc.StartInfo.UseShellExecute = false;
    proc.StartInfo.RedirectStandardOutput = true;
    proc.Start();

    string output = proc.StandardOutput.ReadToEnd();
    proc.WaitForExit();

    return output;
}