using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using iTextSharp.text.pdf.parser;
using Spire.Pdf;
//using PdfDocument = iTextSharp.text.pdf.PdfDocument;

//using SautinSoft;

namespace frmEncode
{
    public partial class frmDecode : Form
    {
        readonly ColorDialog _dialog = new ColorDialog();
        public frmDecode()
        {
            _savecl = new List<SaveColor>();
            InitializeComponent();
            _savecl = new List<SaveColor>();
        }

        private readonly ObjectEncode[] _lstEncode = new ObjectEncode[] {
            new ObjectEncode(){Key = 'A',Value= "CGA"},
            new ObjectEncode(){Key = 'B',Value = "CCA"},
            new ObjectEncode(){Key = 'C',Value = "GTT"},
            new ObjectEncode(){Key = 'D',Value = "TTG"},
            new ObjectEncode(){Key = 'E',Value = "GGT"},
            new ObjectEncode(){Key = 'F',Value = "ACT"},
            new ObjectEncode(){Key = 'G',Value = "TTT"},
            new ObjectEncode(){Key = 'H',Value = "CGC"},
            new ObjectEncode(){Key = 'I',Value = "ATG"},
            new ObjectEncode(){Key = 'J',Value = "AGT"},
            new ObjectEncode(){Key = 'K',Value = "AAG"},
            new ObjectEncode(){Key = 'L',Value = "TGC"},
            new ObjectEncode(){Key = 'M',Value = "TCC"},
            new ObjectEncode(){Key = 'N',Value = "TCT"},
            new ObjectEncode(){Key = 'O',Value = "GGC"},
            new ObjectEncode(){Key = 'P',Value = "GGA"},
            new ObjectEncode(){Key = 'Q',Value = "AAC"},
            new ObjectEncode(){Key = 'R',Value = "TCA"},
            new ObjectEncode(){Key = 'S',Value = "ACG"},
            new ObjectEncode(){Key = 'T',Value = "TTC"},
            new ObjectEncode(){Key = 'U',Value = "CTG"},
            new ObjectEncode(){Key = 'V',Value = "CCT"},
            new ObjectEncode(){Key = 'W',Value = "CCG"},
            new ObjectEncode(){Key = 'X',Value = "CTA"},
            new ObjectEncode(){Key = 'Y',Value = "AAA"},
            new ObjectEncode(){Key = 'Z',Value = "AAT"},
            new ObjectEncode(){Key = '0',Value = "TTA"},
            new ObjectEncode(){Key = '1',Value = "ACC"},
            new ObjectEncode(){Key = '2',Value = "TAG"},
            new ObjectEncode(){Key = '3',Value = "GCA"},
            new ObjectEncode(){Key = '4',Value = "GAG"},
            new ObjectEncode(){Key = '5',Value = "AGA"},
            new ObjectEncode(){Key = '6',Value = "GGG"},
            new ObjectEncode(){Key = '7',Value = "ACA"},
            new ObjectEncode(){Key = '8',Value = "AGG"},
            new ObjectEncode(){Key = '9',Value = "GCG"},
            new ObjectEncode(){Key = ' ',Value = "ATA"},
            new ObjectEncode(){Key = ',',Value = "TCG"},
            new ObjectEncode(){Key = '.',Value = "GAT"},
            new ObjectEncode(){Key = ':',Value = "GCT"},
            new ObjectEncode(){Key = ';',Value = "ATT"},
            new ObjectEncode(){Key = '-',Value = "ATC"}
        };

        private readonly CharacterToByte[] _lstByte = new CharacterToByte[]{
            new CharacterToByte(){Key = 'C',value = 0},
            new CharacterToByte(){Key = 'A',value = 1},
            new CharacterToByte(){Key = 'T',value = 2},
            new CharacterToByte(){Key = 'G',value = 3}
        };

        private readonly List<Color> _lstcorlor = new List<Color>();

        private List<SaveColor> _savecl;
        private int _sumDnae;


        private void frmDecode_Load(object sender, EventArgs e)
        {

        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            _dialog.ShowDialog();
            txtInputWord.SelectionLength = txtInputWord.Text.Length;
            txtInputWord.SelectionColor = _dialog.Color;
        }
        /// <summary>
        /// Hàm chuyển một kí tự thành mã đã cho trong bảng ví dụ A -> CGA
        /// </summary>
        /// <param name="a">A</param>
        /// <returns>CGA</returns>
        private string DecodeCharacter(char a)
        {
            var firstOrDefault = _lstEncode.FirstOrDefault(p => p.Key == a);
            return firstOrDefault != null ? firstOrDefault.Value : "";
        }
        /// <summary>
        /// Chuyển đổi Ký tự C,A,T,G -> 00,01,10,11
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private byte ConvertCharToByte(char a)
        {
            var ret = _lstByte.FirstOrDefault(p => p.Key == a);
            return ret?.value ?? new byte();
        }
        /// <summary>
        /// Hàm chuyển một danh sách Byte về Danh sách ký tự Char Ví dụ 00, 01, 10 -> C,A,T
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        private IEnumerable<char> ConvertBytetoChar(IEnumerable<byte> lst)
        {
            var enumerable = lst as IList<byte> ?? lst.ToList();
            return enumerable.Any()
                ? enumerable.Select(p => _lstByte.Where(k => k.value.Equals(p)).Select(z => z.Key).FirstOrDefault())
                    .ToList()
                : new List<char>();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (string.IsNullOrEmpty(txtInputWord.Text.Trim()))
            {
                err.SetError(txtInputWord, "Bạn chưa nhập Input text");
                txtInputWord.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtWordEncode.Text.Trim()))
            {
                err.SetError(txtWordEncode, "Bạn chưa nhập Word Encode");
                txtWordEncode.Focus();
                return;
            }
            var value = DecodeCharacter(txtWordEncode.Text.Trim()[0]);

            double xzi = 0, wy = 0, zy = 0;
            var strDnae = new List<string>();

            double.TryParse(txtZX.Text.Trim(), out xzi);

            double.TryParse(txtXY.Text.Trim(), out wy);

            double.TryParse(txtZY.Text.Trim(), out zy);

            byte xor = 00;


            Xor(xzi, ref xor);

            //lblTest.Text = "" + xor;

            var lstPrimer = this.ConvertBytetoChar(this.Yprimer(wy, zy));

            var yprimer = lstPrimer.Aggregate("", (current, item) => current + item);
            //Chuỗi Y primer thu được
            lblYprimer.Text = yprimer;

            //Convert chuỗi MDNA -> danh sách Byte
            var lstByteConvert = value.Select(this.ConvertCharToByte).ToList();

            var lstMdna1 = this.AddByte(lstByteConvert, xor);

            var mdna1 = lstMdna1.Aggregate("", (current, item) => current + item);

            //test = lstChar1.Select(p => test += p).FirstOrDefault();
            //Sau khi cộng byte ta thu được chuỗi MDNA phẩy
            lblMDNA1.Text = mdna1;

            var my = "";
            //Sau đó ta cộng chuỗi MDNA phẩy với chuỗi Yprimer
            my = yprimer + mdna1;

            var data = txtInputWord.Text.Trim().Length - txtWordEncode.Text.Trim().Length;
            //Vì luôn có hai chuỗi nên chỉ cần cộng thêm n-2 chuỗi Yprimer thì ta sẽ thu được chuỗi DNAE Gọi tắt vào chuỗi MY
            for (var i = 0; i < data - 1; i++)
            {
                my += yprimer;
                _sumDnae++;
            }

            //Chuyển chuỗi MDNAE thành dạng byte
            var lstbyteMy = my.Select(this.ConvertCharToByte).ToList();

            var lstByteString = lstbyteMy.Select(p => Convert.ToString(p, 2)).ToList();
            var dnaeBinaryStr = "";
            foreach (var item in lstByteString)
            {
                if (item.Length == 1)
                {
                    var tmp = "0" + item;
                    dnaeBinaryStr += tmp;
                }
                else
                    dnaeBinaryStr += item;
            }

            lblDNAE.Text = dnaeBinaryStr;
            lblMY1.Text = "" + dnaeBinaryStr.Length;
            //byte bi = new byte();

            // byte.TryParse(DNAEBinarySTR,out bi);
            //Get màu  của từng chữ trong text box
            for (var i = 0; i < txtInputWord.Text.Trim().Length; i++)
            {
                try
                {
                    txtInputWord.Select(i, 1);
                }
                catch (Exception)
                {
                    // ignored
                }

                _lstcorlor.Add(txtInputWord.SelectionColor);
            }
            //Chia nhỏ chuỗi chuỗi Byte các chuỗi với độ dài bằng 6
            for (var i = 0; i < txtInputWord.Text.Trim().Length; i++)
            {
                var page = i * 6;

                strDnae.Add(dnaeBinaryStr.Substring(page, 6));
            }

            foreach (var item in _lstcorlor)
            {
                lblCurrent.Items.Add(item.R + " " + item.G + " " + item.B);
            }
            //Nhúng bit vào màu RBG
            Dipbyte(strDnae);
            var k = 0;
            txtTextAfterConvert.Text = txtInputWord.Text;
            foreach (var item in _lstcorlor)
            {
                lblAfter.Items.Add(item.R + " " + item.G + " " + item.B);

                txtTextAfterConvert.Select(k, 1);
                txtTextAfterConvert.SelectionColor = item;
                k++;
            }

        }
        /// <summary>
        /// Nhúng bit vào màu RBG lấy được
        /// </summary>
        /// <param name="lststring"></param>
        private void Dipbyte(IReadOnlyList<string> lststring)
        {
            //Vòng for một lấy màu của chữ hiện tại
            for (var i = 0; i < _lstcorlor.Count; i++)
            {
                var lstmp = new List<int>();
                //Vòng for 2 để nhúng màu vào byte RBG 
                for (var j = 0; j < 3; j++)
                {
                    var tmp = 0;
                    var bi = lststring[i].Substring(j * 2, 2);
                    var b = Convert.ToInt32(bi, 2);
                    switch (j)
                    {
                        case 0:
                            tmp = _lstcorlor[i].R & 252;
                            lstmp.Add(Convert.ToInt32((byte)tmp | b));
                            break;
                        case 1:
                            tmp = _lstcorlor[i].G & 252;
                            lstmp.Add(Convert.ToInt32((byte)tmp | b));
                            break;
                        case 2:
                            tmp = _lstcorlor[i].B & 252;
                            lstmp.Add(Convert.ToInt32((byte)tmp | b));
                            break;
                        default:
                            break;
                    }
                }
                //Gán lại màu mới vào list màu
                _lstcorlor[i] = Color.FromArgb(lstmp[0], lstmp[1], lstmp[2]);

            }
        }
        /// <summary>
        /// Hàm + byte 11 + 10 = 01, 01 + 10 = 11 rồi chuyển byte đó thành ký tự A,T,C,G
        /// </summary>
        /// <param name="lst"></param>
        /// <param name="test"></param>
        /// <returns></returns>
        private IEnumerable<char> AddByte(IEnumerable<byte> lst, byte test)
        {
            //List<byte> lsttest = new List<byte>();
            var lsttest = lst.Select(p => (byte)((byte)(p + test) & 3)).ToList();
            return this.ConvertBytetoChar(lsttest.Select(p => byte.Parse(p + "")).ToList());
        }
        /// <summary>
        /// Hàm lấy về xi dựa vào Zi
        /// </summary>
        /// <param name="zi"></param>
        /// <param name="xi"></param>
        private static void Xor(double zi, ref byte xi)
        {
            if ((zi > -1) && (zi <= -0.5))
                xi = 0;
            else if ((zi > -0.5) && (zi <= 0))
                xi = 1;
            else if ((zi > 0) && (zi <= 0.5))
                xi = 2;
            else if ((zi > 0.5) && (zi < 1))
                xi = 3;
        }
        /// <summary>
        /// Hàm tìm kiếm danh sách Y primer theo đúng dạng thuật toán
        /// </summary>
        /// <param name="wi"></param>
        /// <param name="zi"></param>
        /// <returns></returns>
        private IEnumerable<byte> Yprimer(double wi, double zi)
        {
            var lst = new List<byte>();
            var data = txtInputWord.Text.Trim().Length - txtWordEncode.Text.Trim().Length;
            for (double i = 2, ztest = zi; i <= data + 1; i++)
            {
                if ((ztest > -1) && (ztest <= -0.5))
                    lst.Add(3);
                else if ((ztest > -0.5) && (ztest <= 0))
                    lst.Add(2);
                else if ((ztest > 0) && (ztest <= 0.5))
                    lst.Add(1);
                else if ((ztest > 0.5) && (ztest < 1))
                    lst.Add(0);
                var sub = Math.Acos(ztest);
                ztest = Math.Cos(i * sub);

            }
            return lst;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var AC = new Microsoft.Office.Interop.Word.Application();

            var doc = new Microsoft.Office.Interop.Word.Document();

            object readOnly = false;

            object isVisible = true;

            object missing = System.Reflection.Missing.Value;
            var docx = new PdfDocument();
            var openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                docx.LoadFromFile(openFile.FileName);
            }
            object fn = System.IO.Path.GetDirectoryName(openFile.FileName) + @"\output.doc";

            docx.SaveToFile("" + fn, FileFormat.DOC);
            try
            {
                doc = AC.Documents.Open(ref fn, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible, ref isVisible, ref missing, ref missing, ref missing);
                var strResult = "";
                //var test = doc.Content.Characters.Count;
                txtInputWord.Text = doc.Content.Text;
                for (var i = 1; i <= doc.Content.Characters.Count; i++)
                {
                    var text = doc.Content.Characters[i].Text;
                    if (text == " " || text == "\r") continue;
                    var color = (Color)WdColorColorConverter.Convert(doc.Content.Characters[i].Font.Color, null, null, null);
                    strResult += text + " " + color.R + " " + color.G + " " + color.B + " " + doc.Content.Characters[i].Font.Color + "    ";
                    txtInputWord.Select(i - 1, 1);
                    txtInputWord.SelectionColor = color;
                }
                txtPDf.Text = strResult;
            }

            catch (Exception ex)

            {

            }
            Process.Start("WINWORD.EXE", "" + fn);
        }
    }
}
