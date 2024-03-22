# HtmlRendererCore

[![NuGet version (HtmlRendererCore.PdfSharp)](https://img.shields.io/nuget/v/HtmlRendererCore.PdfSharp.svg?style=flat-square)](https://www.nuget.org/packages/HtmlRendererCore.PdfSharp/)
![Build](https://github.com/j-petty/HtmlRendererCore/workflows/Build/badge.svg?branch=master)

**HtmlRendererCore** is a partial port of [HtmlRendererCore](https://github.com/j-petty/HtmlRendererCore) for .NET 6+.
Previous versions of this library used `System.Drawing` which was deprecated for linux systems in .Net 6, and completely remove in .Net 7.

This library offers Html to Pdf parsing for .Net Core projects using [PdfSharpCore](https://github.com/ststeiger/PdfSharpCore). We are currently using a preview version of this lib, as other older version did not support .Net 7 as well.

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
- `dotnet pack -c Release ./HtmlRendererCoreNet7.PdfSharp/HtmlRendererCoreNet7.PdfSharp.csproj -o .`
- `dotnet publish`
- `dotnet nuget push "HtmlRendererCoreNet7.PdfSharp.2.0.7.nupkg" -k ${{secrets.NUGET_API_KEY}} --source https://api.nuget.org/v3/index.json
  `

## Attribution

**HtmlRendererCore:** https://github.com/j-petty/HtmlRendererCore
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
