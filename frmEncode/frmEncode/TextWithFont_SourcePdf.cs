using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf.parser;

namespace frmEncode
{
    public class TextWithFont_SourcePdf : ITextExtractionStrategy
    {
        private int _r;

        public int R
        {
            get { return _r; }
            set { _r = value; }
        }

        public int G
        {
            get
            {
                return _g;
            }

            set
            {
                _g = value;
            }
        }

        public int B
        {
            get
            {
                return _b;
            }

            set
            {
                _b = value;
            }
        }

        private int _g;

        private int _b;

        public void BeginTextBlock()
        {
            Console.WriteLine(@"Success");
        }

        public void RenderText(TextRenderInfo renderInfo)
        {
            _r = renderInfo.GetStrokeColor().R;
            _g = renderInfo.GetStrokeColor().G;
            _b = renderInfo.GetStrokeColor().B;
        }

        public void EndTextBlock()
        {
            Console.WriteLine(@"Success");
        }

        public void RenderImage(ImageRenderInfo renderInfo)
        {
            throw new NotImplementedException();
        }

        public string GetResultantText()
        {
            return @"Success";
        }
    }
}
