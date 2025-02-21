using System.Diagnostics;

namespace SumatraPDFPrinter
{
    public static class PdfPrinter
    {
        public static void PrintPdf(string pdfPath, string printerName)
        {
            var exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SumatraPDF.exe");

            ValidateParameters(exePath, pdfPath, printerName);

            var args = $"-exit-when-done -print-to \"{printerName}\" \"{pdfPath}\"";

            StartPrintProcess(exePath, args);
        }

        private static void ValidateParameters(string exePath, string pdfPath, string printerName)
        {
            if (!File.Exists(exePath))
                throw new FileNotFoundException("SumatraPDF.exe not found!", exePath);

            if (!File.Exists(pdfPath))
                throw new FileNotFoundException("PDF file not found!", pdfPath);

            if (string.IsNullOrWhiteSpace(printerName))
                throw new ArgumentException("Printer name cannot be empty", nameof(printerName));
        }

        private static void StartPrintProcess(string exePath, string args)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = exePath,
                Arguments = args,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            using Process? process = Process.Start(processInfo) ?? throw new InvalidOperationException("Failed to start the print process.");
        }
    }
}