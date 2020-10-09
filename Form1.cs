using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Spire.Pdf;
using Spire.Pdf;
using ZXing;
using ZXing.Magick;
using ZXing.QrCode;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace PDF_Tool
{
    public partial class Form1 : Form
    {
        private string strVersion = "1.0";
        private DataTable tblFapiao = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            foreach (var strFile in System.IO.Directory.GetFiles(txtPDFFolderPath.Text))
            {
                convertToPDF(strFile, txtResultImageFileFolder.Text, Convert.ToInt32(numPictureQuality.Value));
            }
        }


        private void convertToPDF(String strPDFFilePath, string strResultFolderPath, int intDPI)
        {
            PdfDocument pdfdocument = new PdfDocument(strPDFFilePath);
            string strFileName = strPDFFilePath.Substring(strPDFFilePath.LastIndexOf("\\", StringComparison.CurrentCulture) + 1);

            for (int i = 0; i < pdfdocument.Pages.Count; i++)
            {
                System.Drawing.Image image = pdfdocument.SaveAsImage(i, intDPI, intDPI);
                image.Save(strResultFolderPath + "\\" + string.Format(strFileName + "{0}.png", i), System.Drawing.Imaging.ImageFormat.Png);
            }

        }

        private void convertFirstPageToImg(String strPDFFilePath, string strImgFilePath, int intDPI)
        {
            PdfDocument pdfdocument = new PdfDocument(strPDFFilePath);
            System.Drawing.Image image = pdfdocument.SaveAsImage(0, intDPI, intDPI);
            image.Save(strImgFilePath, System.Drawing.Imaging.ImageFormat.Png);
        }


        private void btnBrowsePDFFolder_Click(object sender, EventArgs e)
        {
            txtPDFFolderPath.Text = BrowseFolder();
        }

        private void btnBrowseResultImagesFolder_Click(object sender, EventArgs e)
        {
            txtResultImageFileFolder.Text = BrowseFolder();
        }


        private string BrowseFolder()
        {
            FolderBrowserDialog file = new FolderBrowserDialog();
            DialogResult dr = file.ShowDialog();
            if (dr == DialogResult.OK)
            {
                return file.SelectedPath;
            }

            return "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " V" + strVersion;

            //Load the columns
            tblFapiao.Columns.Add("FileName");
            tblFapiao.Columns.Add("Type");
            tblFapiao.Columns.Add("发票代码");
            tblFapiao.Columns.Add("发票号码");
            tblFapiao.Columns.Add("不含税金额");
            tblFapiao.Columns.Add("开票日期");
            tblFapiao.Columns.Add("校验码");
            tblFapiao.Columns.Add("随机产生的机密信息");
            dgFapiao.DataSource = tblFapiao;
        }

        private void btnQRCodereading_Click(object sender, EventArgs e)
        {

            string strImgPath = @"C:\PDF\PDF Tool\Data\zoutput53.jpeg";
            strImgPath = @"C:\PDF\PDF Tool\Data\A_text,_your_name,_a_number_or_anything..._;)_as_QRcode.png";


//            01,04（01,04是普通发票，01,01是专用发票）,1200153320（发票代码）,07041662（发票号码）,183.49（不含税金额）,20151221（开票日期）,83623873463907646339（校验码）,5080（随机产生的机密信息）

//作者：西顾
//链接：https://www.zhihu.com/question/46433405/answer/146524598
//            来源：知乎
//            著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。


            var reader = new ZXing.Magick.BarcodeReader();
            reader.Options.PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE};

            using (var image = new  ImageMagick.MagickImage(strImgPath))
            {
                var result = reader.Decode(image);
                if (result != null)
                {
                    Console.WriteLine("QR Code read");
                    Console.WriteLine(result.Text);
                }
            }


            //QRCodeImage qrimg = new Bitmap(strImgPath);
            //QRCodeDecoder decode = new QRCodeDecoder();
            //decode.Decode()



            //Bitmap img = new Bitmap(strImgPath);
            //ZXing.Binarizer bin;
            


            //ZXing.BinaryBitmap imgBinary = new ZXing.BinaryBitmap()

            //QRCodeReader qrReader = new QRCodeReader();
            //ZXing.Result objResult = qrReader.decode(img);

        }

        private void mf_btnBrowseFapiao_Click(object sender, EventArgs e)
        {
            mf_btnBrowseFapiao.Text = BrowseFolder();
            string strDecodedText;
            string strFapiaoType;
            float fltFapiaoTotalAmount = 0f;
            string[] strArrOutput;

            //Read all files in the folder
            foreach (var strFile in System.IO.Directory.GetFiles(mf_btnBrowseFapiao.Text))
            {
                strDecodedText = "";
                //Check is it PDF of text file
                if (strFile.Substring(strFile.Length - 4).ToLower() == ".pdf")
                {
                    convertFirstPageToImg(strFile, strFile.ToLower().Replace(".pdf",".jpeg"), Convert.ToInt32(numPictureQuality.Value));
                    strDecodedText = DecodeQRCode(strFile);
                }
                else if (strFile.Substring(strFile.Length - 5).ToLower() == ".jpeg")
                {
                    strDecodedText = DecodeQRCode(strFile);
                }

                if (strDecodedText != null && strDecodedText != "" && strDecodedText.Contains("http") == true)
                {
                //Scanned result is an URL
                //Capture the amount from URL , Sample
                https://bcfp.shenzhen.chinatax.gov.cn/verify/scan?hash=007e07634a22c81eba4c66b5338819870eda751a830a2b12e66cad5296e923b205&bill_num=11427293&total_amount=7990
                    string strTem = strDecodedText.Substring(strDecodedText.IndexOf("&bill_num"));
                    strArrOutput = strTem.Split( new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
                    strTem = strArrOutput[0].Replace("bill_num=", "");
                    float fltAmount = float.Parse(strArrOutput[1].Replace("total_amount=", "")) / 100;




                    tblFapiao.Rows.Add(strFile, "", "", strTem, fltAmount.ToString(), "","","");

                    fltFapiaoTotalAmount = fltFapiaoTotalAmount + fltAmount;
                }
                else if (strDecodedText != null && strDecodedText != "")
                {
                   strArrOutput = strDecodedText.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries); 

                    //01,04（01,04是普通发票，01,01是专用发票）
                    if (strArrOutput[1].Trim() == "01,01")
                        strFapiaoType = "专用发票";
                    else
                        strFapiaoType = "普通发票";
                    
                    //Add row
                    tblFapiao.Rows.Add(strFile, strFapiaoType,strArrOutput[2], strArrOutput[3], strArrOutput[4], strArrOutput[5], strArrOutput[6], strArrOutput[7]);

                    //Add amount into total
                    fltFapiaoTotalAmount = fltFapiaoTotalAmount + float.Parse(strArrOutput[4]);

                    //strArrOutput[7] - dont know what this represents
                    //01,04（01,04是普通发票，01,01是专用发票）,1200153320（发票代码）,07041662（发票号码）,183.49（不含税金额）,20151221（开票日期）,83623873463907646339（校验码）,5080（随机产生的机密信息）
                    //作者：西顾
                    //链接：https://www.zhihu.com/question/46433405/answer/146524598
                    //来源：知乎
                    //著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。
                }
                else
                {
                    tblFapiao.Rows.Add(strFile, "Not valid format");
                }
            }

            //Display the results
            dgFapiao.DataSource = tblFapiao;
            mf_lblFapiaoTotalAmt.Text = fltFapiaoTotalAmount.ToString();
        }


        private string DecodeQRCode(string strImgFilePath)
        {
            var reader = new ZXing.Magick.BarcodeReader();
            reader.Options.PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE };

            using (var image = new ImageMagick.MagickImage(strImgFilePath))
            {
                var result = reader.Decode(image);
                if (result != null)
                {                    
                    return result.Text;
                }
            }

            return null;
        }

    }
}
