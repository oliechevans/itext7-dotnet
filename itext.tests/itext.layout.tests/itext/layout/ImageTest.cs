using System;
using iText.IO.Image;
using iText.IO.Util;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Xobject;
using iText.Kernel.Utils;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Test;
using iText.Test.Attributes;

namespace iText.Layout {
    public class ImageTest : ExtendedITextTest {
        public static readonly String sourceFolder = NUnit.Framework.TestContext.CurrentContext.TestDirectory + "/../../resources/itext/layout/ImageTest/";

        public static readonly String destinationFolder = NUnit.Framework.TestContext.CurrentContext.TestDirectory
             + "/test/itext/layout/ImageTest/";

        [NUnit.Framework.OneTimeSetUp]
        public static void BeforeClass() {
            CreateDestinationFolder(destinationFolder);
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void ImageTest01() {
            String outFileName = destinationFolder + "imageTest01.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest01.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            PdfImageXObject xObject = new PdfImageXObject(ImageDataFactory.Create(sourceFolder + "Desert.jpg"));
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(xObject, 100);
            doc.Add(new Paragraph(new Text("First Line")));
            Paragraph p = new Paragraph();
            p.Add(image);
            doc.Add(p);
            doc.Add(new Paragraph(new Text("Second Line")));
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void ImageTest02() {
            String outFileName = destinationFolder + "imageTest02.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest02.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            PdfImageXObject xObject = new PdfImageXObject(ImageDataFactory.CreateJpeg(UrlUtil.ToURL(sourceFolder + "Desert.jpg"
                )));
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(xObject, 100);
            Paragraph p = new Paragraph();
            p.Add(new Text("before image"));
            p.Add(image);
            p.Add(new Text("after image"));
            doc.Add(p);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void ImageTest03() {
            String outFileName = destinationFolder + "imageTest03.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest03.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            PdfImageXObject xObject = new PdfImageXObject(ImageDataFactory.Create(sourceFolder + "Desert.jpg"));
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(xObject, 100);
            doc.Add(new Paragraph(new Text("First Line")));
            Paragraph p = new Paragraph();
            p.Add(image);
            image.SetRotationAngle(Math.PI / 6);
            doc.Add(p);
            doc.Add(new Paragraph(new Text("Second Line")));
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void ImageTest04() {
            String outFileName = destinationFolder + "imageTest04.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest04.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            PdfImageXObject xObject = new PdfImageXObject(ImageDataFactory.Create(sourceFolder + "Desert.jpg"));
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(xObject, 100);
            Paragraph p = new Paragraph();
            p.Add(new Text("before image"));
            p.Add(image);
            image.SetRotationAngle(Math.PI / 6);
            p.Add(new Text("after image"));
            doc.Add(p);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void ImageTest05() {
            String outFileName = destinationFolder + "imageTest05.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest05.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            PdfImageXObject xObject = new PdfImageXObject(ImageDataFactory.Create(sourceFolder + "Desert.jpg"));
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(xObject, 100);
            doc.Add(new Paragraph(new Text("First Line")));
            Paragraph p = new Paragraph();
            p.Add(image);
            image.Scale(1, 0.5f);
            doc.Add(p);
            doc.Add(new Paragraph(new Text("Second Line")));
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void ImageTest06() {
            String outFileName = destinationFolder + "imageTest06.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest06.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            PdfImageXObject xObject = new PdfImageXObject(ImageDataFactory.Create(sourceFolder + "Desert.jpg"));
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(xObject, 100);
            doc.Add(new Paragraph(new Text("First Line")));
            Paragraph p = new Paragraph();
            p.Add(image);
            image.SetMarginLeft(100).SetMarginTop(100);
            doc.Add(p);
            doc.Add(new Paragraph(new Text("Second Line")));
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        [LogMessage(iText.IO.LogMessageConstant.ELEMENT_DOES_NOT_FIT_AREA)]
        public virtual void ImageTest07() {
            String outFileName = destinationFolder + "imageTest07.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest07.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + "Desert.jpg"
                ));
            Div div = new Div();
            div.Add(image);
            doc.Add(div);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        [LogMessage(iText.IO.LogMessageConstant.ELEMENT_DOES_NOT_FIT_AREA)]
        public virtual void ImageTest08() {
            String outFileName = destinationFolder + "imageTest08.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest08.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + "Desert.jpg"
                ));
            Div div = new Div();
            div.Add(image);
            div.Add(image);
            doc.Add(div);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        [LogMessage(iText.IO.LogMessageConstant.ELEMENT_DOES_NOT_FIT_AREA)]
        public virtual void ImageTest09() {
            String outFileName = destinationFolder + "imageTest09.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest09.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc, new PageSize(500, 300));
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + "Desert.jpg"
                ));
            image.SetWidthPercent(100);
            doc.Add(image);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void ImageTest10() {
            String outFileName = destinationFolder + "imageTest10.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest10.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc, new PageSize(500, 300));
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + "Desert.jpg"
                ));
            image.SetAutoScale(true);
            doc.Add(image);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void ImageTest11() {
            String outFileName = destinationFolder + "imageTest11.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest11.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + "Desert.jpg"
                ));
            image.SetAutoScale(true);
            doc.Add(image);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void ImageTest12_HorizontalAlignment_CENTER() {
            String outFileName = destinationFolder + "imageTest12.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest12.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + "itis.jpg"
                ));
            image.SetHorizontalAlignment(HorizontalAlignment.CENTER);
            doc.Add(image);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void ImageTest13_HorizontalAlignment_RIGHT() {
            String outFileName = destinationFolder + "imageTest13.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest13.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + "itis.jpg"
                ));
            image.SetHorizontalAlignment(HorizontalAlignment.RIGHT);
            doc.Add(image);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void ImageTest14_HorizontalAlignment_LEFT() {
            String outFileName = destinationFolder + "imageTest14.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest14.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + "itis.jpg"
                ));
            image.SetHorizontalAlignment(HorizontalAlignment.LEFT);
            doc.Add(image);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        [LogMessage(iText.IO.LogMessageConstant.ELEMENT_DOES_NOT_FIT_AREA)]
        public virtual void ImageTest15() {
            String outFileName = destinationFolder + "imageTest15.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest15.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + "Desert.jpg"
                ));
            image.SetBorder(new SolidBorder(Color.BLUE, 5));
            doc.Add(image);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void ImageTest16() {
            String outFileName = destinationFolder + "imageTest16.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest16.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + "Desert.jpg"
                ));
            image.SetBorder(new SolidBorder(Color.BLUE, 5));
            image.SetAutoScale(true);
            image.SetRotationAngle(Math.PI / 2);
            doc.Add(image);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        [LogMessage(iText.IO.LogMessageConstant.ELEMENT_DOES_NOT_FIT_AREA, Count = 50)]
        public virtual void ImageTest17() {
            String outFileName = destinationFolder + "imageTest17.pdf";
            String cmpFileName = sourceFolder + "cmp_imageTest17.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            iText.Layout.Element.Image image1 = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + 
                "Desert.jpg"));
            image1.SetBorder(new SolidBorder(Color.BLUE, 5));
            iText.Layout.Element.Image image2 = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + 
                "scarf.jpg"));
            image2.SetBorder(new SolidBorder(Color.BLUE, 5));
            for (int i = 0; i <= 24; i++) {
                image1.SetRotationAngle(i * Math.PI / 12);
                image2.SetRotationAngle(i * Math.PI / 12);
                doc.Add(image1);
                doc.Add(image2);
            }
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <summary>Image can be reused in layout, so flushing it on the very first draw is a bad thing.</summary>
        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void FlushOnDrawTest() {
            String outFileName = destinationFolder + "flushOnDrawTest.pdf";
            String cmpFileName = sourceFolder + "cmp_flushOnDrawTest.pdf";
            int rowCount = 60;
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document document = new Document(pdfDoc);
            iText.Layout.Element.Image img = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + "Desert.jpg"
                ));
            Table table = new Table(8);
            table.SetWidthPercent(100);
            for (int k = 0; k < rowCount; k++) {
                for (int j = 0; j < 7; j++) {
                    table.AddCell("Hello");
                }
                Cell c = new Cell().Add(img.SetWidthPercent(50));
                table.AddCell(c);
            }
            document.Add(table);
            document.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <summary>
        /// If an image is flushed automatically on draw, we will later check it for circular references
        /// as it is an XObject.
        /// </summary>
        /// <remarks>
        /// If an image is flushed automatically on draw, we will later check it for circular references
        /// as it is an XObject. This is a test for
        /// <see cref="System.ArgumentNullException"/>
        /// that was caused by getting
        /// a value from flushed image.
        /// </remarks>
        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void FlushOnDrawCheckCircularReferencesTest() {
            String outFileName = destinationFolder + "flushOnDrawCheckCircularReferencesTest.pdf";
            String cmpFileName = sourceFolder + "cmp_flushOnDrawCheckCircularReferencesTest.pdf";
            PdfDocument pdf = new PdfDocument(new PdfWriter(outFileName));
            //Initialize document
            Document document = new Document(pdf);
            iText.Layout.Element.Image img = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + "itis.jpg"
                ));
            img.SetAutoScale(true);
            Table table = new Table(4);
            table.SetWidthPercent(100);
            for (int k = 0; k < 5; k++) {
                table.AddCell("Hello World from iText7");
                List list = new List().SetListSymbol("-> ");
                list.Add("list item").Add("list item").Add("list item").Add("list item").Add("list item");
                Cell cell = new Cell().Add(list);
                table.AddCell(cell);
                Cell c = new Cell().Add(img);
                table.AddCell(c);
                Table innerTable = new Table(3);
                int j = 0;
                while (j < 9) {
                    innerTable.AddCell("Hi");
                    j++;
                }
                table.AddCell(innerTable);
            }
            document.Add(table);
            document.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void ImageWithBordersSurroundedByTextTest() {
            String outFileName = destinationFolder + "imageBordersTextTest.pdf";
            String cmpFileName = sourceFolder + "cmp_imageBordersTextTest.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            PdfImageXObject xObject = new PdfImageXObject(ImageDataFactory.Create(sourceFolder + "Desert.jpg"));
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(xObject, 100);
            Paragraph p = new Paragraph();
            p.SetBorder(new SolidBorder(Color.GREEN, 5));
            p.Add(new Text("before image"));
            p.Add(image);
            image.SetBorder(new SolidBorder(Color.BLUE, 5));
            p.Add(new Text("after image"));
            doc.Add(p);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        public virtual void ImageInParagraphBorderTest() {
            String outFileName = destinationFolder + "imageParagraphBorderTest.pdf";
            String cmpFileName = sourceFolder + "cmp_imageParagraphBorderTest.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            PdfImageXObject xObject = new PdfImageXObject(ImageDataFactory.Create(sourceFolder + "Desert.jpg"));
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(xObject, 100);
            Paragraph p = new Paragraph();
            p.SetBorder(new SolidBorder(Color.GREEN, 5));
            p.Add(image);
            image.SetBorder(new SolidBorder(Color.BLUE, 5));
            doc.Add(p);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("DEVSIX-1022")]
        public virtual void ImageRelativePositionTest() {
            String outFileName = destinationFolder + "imageRelativePositionTest.pdf";
            String cmpFileName = sourceFolder + "cmp_imageRelativePositionTest.pdf";
            PdfWriter writer = new PdfWriter(outFileName);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc);
            PdfImageXObject xObject = new PdfImageXObject(ImageDataFactory.Create(sourceFolder + "Desert.jpg"));
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(xObject, 100).SetRelativePosition(30, 30
                , 0, 0);
            Paragraph p = new Paragraph();
            p.SetBorder(new SolidBorder(Color.GREEN, 5));
            p.Add(image);
            image.SetBorder(new SolidBorder(Color.BLUE, 5));
            doc.Add(p);
            doc.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        [LogMessage(iText.IO.LogMessageConstant.CLIP_ELEMENT, Count = 2)]
        public virtual void ImageInTableTest01() {
            String outFileName = destinationFolder + "imageInTableTest01.pdf";
            String cmpFileName = sourceFolder + "cmp_imageInTableTest01.pdf";
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(outFileName));
            Document document = new Document(pdfDoc);
            iText.Layout.Element.Image img = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + "Desert.jpg"
                ));
            Table table = new Table(1);
            table.SetMaxHeight(300);
            table.SetBorder(new SolidBorder(Color.BLUE, 10));
            Cell c = new Cell().Add(img.SetHeight(500));
            table.AddCell(c);
            document.Add(table);
            document.Add(new Table(1).AddCell("Is my occupied area right?"));
            document.Add(new AreaBreak());
            table.SetMinHeight(150);
            document.Add(table);
            document.Add(new Table(1).AddCell("Is my occupied area right?"));
            document.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }

        /// <exception cref="System.IO.IOException"/>
        /// <exception cref="System.Exception"/>
        [NUnit.Framework.Test]
        [LogMessage(iText.IO.LogMessageConstant.CLIP_ELEMENT, Count = 2)]
        public virtual void ImageInTableTest02() {
            String outFileName = destinationFolder + "imageInTableTest02.pdf";
            String cmpFileName = sourceFolder + "cmp_imageInTableTest02.pdf";
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(outFileName));
            Document document = new Document(pdfDoc);
            iText.Layout.Element.Image img = new iText.Layout.Element.Image(ImageDataFactory.Create(sourceFolder + "Desert.jpg"
                ));
            Table table = new Table(1);
            table.SetMaxHeight(300);
            table.SetBorder(new SolidBorder(Color.BLUE, 10));
            Cell c = new Cell().Add(img.SetHeight(500));
            table.AddCell("First cell");
            table.AddCell(c);
            document.Add(table);
            document.Add(new Table(1).AddCell("Is my occupied area right?"));
            document.Add(new AreaBreak());
            table.SetMinHeight(150);
            document.Add(table);
            document.Add(new Table(1).AddCell("Is my occupied area right?"));
            document.Close();
            NUnit.Framework.Assert.IsNull(new CompareTool().CompareByContent(outFileName, cmpFileName, destinationFolder
                , "diff"));
        }
    }
}
