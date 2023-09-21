using HtmlRendererCore.PdfSharp;
using PdfSharp;
using PdfSharp.Fonts;
using PdfSharp.Snippets.Font;

GlobalFontSettings.FontResolver = new FailsafeFontResolver();

var html = @"
                <html>
                    <body>
                        <p style=""color: red"">Test document</p>
                        <p style=""color: blue; font-style: italic"">Test document</p>
                        <p style=""color: black;""><strong>Test document</strong></p>
                        <p style=""color: black"">Test document</p>
                        <p style=""color: black"">Test document</p>
                    </body>
                </html>
            ";

var result = PdfGenerator.GeneratePdf(html, PageSize.A4);

result.Save("file.pdf");