using Common.Models;
using System.Text.RegularExpressions;

namespace CodeScanningService
{
    public class CodeScanningServiceLayer:ICodeScanningServiceLayer
    {

        public string scanCode(CodeModel code)
        {
            string pattern = @"(public\s+class\s+\w+\s*){";

            // Check if the code matches the pattern
            if (Regex.IsMatch(code.code, pattern))
            {
                // Return a success message if the pattern is found
                return "Code evaluation successful. Class declaration found.";
            }
            else
            {
                // Return an error message if the pattern is not found
                return "Code evaluation failed. No class declaration found.";
            }
        }
    }
}
