# HtmlRendererCore

[![NuGet version (HtmlRendererCore.PdfSharpMigraDoc)](https://img.shields.io/nuget/v/HtmlRendererCore.PdfSharpMigraDoc.svg?style=flat-square)](https://www.nuget.org/packages/HtmlRendererCore.PdfSharpMigraDoc/)
![Build](https://github.com/karbonbaron/HtmlRendererCore/workflows/Build/badge.svg?branch=master)

**HtmlRendererCore** is a partial port of [HtmlRendererCore](https://github.com/j-petty/HtmlRendererCore) for .NET 6+ by https://github.com/manuel3108/HtmlRendererCore-Net7
Previous versions of this library used `System.Drawing` which was deprecated for linux systems in .Net 6, and completely remove in .Net 7.

This package does library updates to latest and targets .NET 8 and uses PdfSharpMigraDoc package instead of PdfSharp

This library offers Html to Pdf parsing for .Net Core projects using [PdfSharpCore](https://github.com/ststeiger/PdfSharpCore).

Future updates will be focused at cleaning up the codebase and offering support for more advanced HTML rendering. Public pull requests welcome.

## Example usage

### Generate PDF from HTML

```cs
var pdf = PdfGenerator.GeneratePdf(html, PdfSharpCore.PageSize.A4);
```

### Generating Base64 PDF from HTML

```cs
var result = string.Empty;

using (var stream = new MemoryStream())
{
    var pdf = PdfGenerator.GeneratePdf(html, PdfSharpCore.PageSize.A4);

    pdf.Save(stream);

    result = Convert.ToBase64String(stream.ToArray());
}
```

## Publishing
- `dotnet build -c Release`
- `dotnet pack -c Release ./HtmlRendererCore.PdfSharpMigraDoc/HtmlRendererCore.PdfSharpMigraDoc.csproj -o .`
- `dotnet publish`
- `dotnet nuget push "HtmlRendererCore.PdfSharpMigraDoc.2.0.12.nupkg" -k ${{secrets.NUGET_API_KEY}} --source https://api.nuget.org/v3/index.json
  `

## Attribution

**HtmlRendererCore:** https://github.com/j-petty/HtmlRendererCore
**HtmlRendererCore port to .NET 7:** https://github.com/manuel3108/HtmlRendererCore-Net7
**PdfSharp:** https://github.com/empira/PDFsharp/

## License

Copyright (c) 2021 James Petty

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
