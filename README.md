# SumatraPDFPrinter

SumatraPDFPrinter is a lightweight C# library that allows you to print PDF files using SumatraPDF, a fast and minimalistic PDF viewer. This library provides an easy way to send PDF documents to a specified printer without user interaction.

## 📌 Features

- Print PDF files programmatically.
- Supports specifying the target printer.
- Uses SumatraPDF's command-line options for fast and silent printing.
- Simple and lightweight, with minimal dependencies.
- SumatraPDF is included with this library, so no separate download is required.

## 🛠 Installation

Add `PdfPrinter.cs` to your project.

## 🚀 Usage

```csharp
using SumatraPDFPrinter;

string pdfPath = "C:\\path\\to\\yourfile.pdf";
string printerName = "Your Printer Name";

PdfPrinter.PrintPdf(pdfPath, printerName);
```

For asynchronous printing, use:

```csharp
await Task.Run(() => PdfPrinter.PrintPdf(pdfPath, printerName));
```

## ⚙️ Configuration

Make sure that:

- The provided PDF file path is valid.
- The specified printer name is correct.

## 🛑 Troubleshooting

- **"PDF file not found!"** → Verify the file path before printing.
- **Printing is stuck** → Use `Task.Run` to avoid blocking the request.

## 📜 License

This library is licensed under the Eclipse Public License 2.0. Feel free to modify and use it in your projects.

💡 Contributions are welcome! If you find a bug or have an improvement, feel free to submit a pull request or open an issue.
