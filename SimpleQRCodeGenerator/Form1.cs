using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace SimpleQRCodeGenerator
{
    public partial class SercoQRCodeGenerator : Form
    {
        StringCollection mypasswords;
        public SercoQRCodeGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap qrCodeImage = null;
            if (wifiSSID.Text.Length == 0)
            {


                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                //# QRCodeData qrCodeData = qrGenerator.CreateQrCode("The text which should be encoded.", QRCodeGenerator.ECCLevel.Q);
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(SourceText.Text.ToString(), QRCodeGenerator.ECCLevel.Q);

                QRCode qrCode = new QRCode(qrCodeData);
                qrCodeImage = qrCode.GetGraphic(20);
            }
            else
            {
                //string authType = "";
                PayloadGenerator.WiFi.Authentication authType = PayloadGenerator.WiFi.Authentication.WPA;
                switch (wifiAuth.Text.ToUpper())
                {
                    case "WPA":
                        authType = PayloadGenerator.WiFi.Authentication.WPA;
                        break;
                    case "WEP":
                        authType = PayloadGenerator.WiFi.Authentication.WEP;
                        break;



                }

                PayloadGenerator.WiFi generator = new PayloadGenerator.WiFi(wifiSSID.Text, wifiPassword.Text.ToString(), authType);
                string payload = generator.ToString();

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                var qrCodeAsBitmap = qrCode.GetGraphic(20);
                qrCodeImage = qrCodeAsBitmap;
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            pictureBox1.Image = qrCodeImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var fd = new SaveFileDialog();
            fd.Filter = "Bmp(*.BMP;)|*.BMP;| Jpg(*Jpg)|*.jpg";
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                switch (Path.GetExtension(fd.FileName))
                {
                    case ".BMP":
                        pictureBox1.Image.Save(fd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case ".JPG":
                        pictureBox1.Image.Save(fd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    default:
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void SercoQRCodeGenerator_Load(object sender, EventArgs e)
        {
            try {
                StringCollection mysettings = Properties.Settings.Default.one;
                listOfSSIDs.SelectionMode = SelectionMode.One;
                int m = 0;
                if (mysettings.Count > 0)
                {
                    foreach (string setting in mysettings)

                    {
                        string[] _mysetting = setting.Split(",".ToCharArray());

                        listOfSSIDs.Items.Add(_mysetting[0].Trim());
                        listOFPasswords.Items.Add(_mysetting[1].Trim());
                        listOfAuths.Items.Add(_mysetting[2].Trim());
                        Console.WriteLine(setting);
                        // to be done later listOfSSIDs.Items.Add(setting);
                        //mypasswords.Add(setting);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception detected whilst reading ssid settings", "Exception text " + ex.Message);
            }
            } 
        

        private void listOfSSIDs_Click(object sender, EventArgs e)
        {
            // wifiSSID.Text = listOfSSIDs.SelectedItems.ToString();
            int ndx = listOfSSIDs.SelectedIndex;
            wifiSSID.Text = listOfSSIDs.Items[ndx].ToString();
            wifiPassword.Text = listOFPasswords.Items[ndx].ToString();
            wifiAuth.Text = listOfAuths.Items[ndx].ToString();

        }

        private void getSSIDs_Click(object sender, EventArgs e)
        {
            string[] _myuserprofiles = new String[100];
            string[] _myssids = new String[100];
            string[] _mypasswords = new String[100];
            string[] _myauth = new String[100];
            
            // flush the listboxes to avoid pointers issues 
            // to be done 
            //listOfSSIDs.empty 
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            Process process = Process.Start(processStartInfo);
            process.StandardInput.WriteLine("netsh wlan show profile");
            process.StandardInput.Close();
            string[] Lines = process.StandardOutput.ReadToEnd().Split("\r\n".ToCharArray());
            string LineString = string.Empty;
            int m = -1;
            for (int i = 0; i < Lines.Length; i++)
            {
                LineString = Lines[i];
                if (LineString.Contains("User Profile"))
                {
                    m++;
                    _myuserprofiles[m] = LineString.Split(":".ToCharArray())[1].Trim();
                    _myuserprofiles[m] = "\"" + _myuserprofiles[m] + "\"";
                    // set default values so that the reference by index later doesn't find a null value
                    _myssids[m] = "noSSID";
                    _mypasswords[m] = "noPass";
                    _myauth[m] = "noAuth";
                    ProcessStartInfo processStartInfo2 = new ProcessStartInfo("cmd.exe");
                    processStartInfo.RedirectStandardInput = true;
                    processStartInfo.RedirectStandardOutput = true;
                    processStartInfo.CreateNoWindow = true;
                    processStartInfo.UseShellExecute = false;
                    Process process2 = Process.Start(processStartInfo);
                    process2.StandardInput.WriteLine("netsh wlan show profile " + _myuserprofiles[m] + " key=clear");
                    process2.StandardInput.Close();
                    string[] Lines2 = process2.StandardOutput.ReadToEnd().Split("\r\n".ToCharArray());
                    string LineString2 = string.Empty;
                    int mm = 0;
                    for (int j = 0; j < Lines2.Length; j++)
                    {
                        LineString2 = Lines2[j];
                        if (LineString2.Contains("SSID name"))
                        {
                            // trim funny characters sent back by CMD
                            _myssids[m] = LineString2.Split(":".ToCharArray())[1].Trim(new Char[] { ' ', '*', '"' });
                        }
                        if (LineString2.Contains("Key Content"))
                        {
                            _mypasswords[m] = LineString2.Split(":".ToCharArray())[1].Trim();
                        }
                        if (LineString2.Contains("Authentication"))
                        {
                            _myauth[m] = LineString2.Split(":".ToCharArray())[1].Trim();
                        }
                    }
                    // write this line only if it was a user profile line
                    if (_mypasswords[m] != "noPass") {
                        Console.WriteLine(_myuserprofiles[m] + " " + _myssids[m] + " " + _mypasswords[m] + " " + _myauth[m]);
                        listOfSSIDs.Items.Add(_myssids[m]);
                        listOFPasswords.Items.Add(_mypasswords[m] ?? "zeroPass");
                        listOfAuths.Items.Add(_myauth[m] ?? "zeroAuth");
                    }
                    else
                    {
                        m--;
                    }
                }
                
            }
        }

        private void listOfSSIDs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void saveToSettings_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    StringCollection mysettings = Properties.Settings.Default.one;
            //    listOfSSIDs.SelectionMode = SelectionMode.One;
            //    int m = 0;
            //    if (mysettings.Count > 0)
            //    {
            //        foreach (string setting in mysettings)

            //        {
            //            string[] _mysetting = setting.Split(",".ToCharArray());

            //            listOfSSIDs.Items.Add(_mysetting[0].Trim());
            //            listOFPasswords.Items.Add(_mysetting[1].Trim());
            //            listOfAuths.Items.Add(_mysetting[2].Trim());
            //            Console.WriteLine(setting);
            //            // to be done later listOfSSIDs.Items.Add(setting);
            //            //mypasswords.Add(setting);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Exception detected whilst reading ssid settings", "Exception text " + ex.Message);
            //}

            StringCollection mysettings = Properties.Settings.Default.one;
            mysettings.Clear();
            //Properties.Settings.Default.Save();

            int m = listOfSSIDs.Items.Count;
            int n = -1; 
            foreach (string _ssid in listOfSSIDs.Items)
            {
                n++;
                mysettings.Add(listOfSSIDs.Items[n].ToString() + ',' + listOFPasswords.Items[n].ToString() + ',' + listOfAuths.Items[n].ToString());


            }
            Properties.Settings.Default.Save();
        }

        private void listOfSSIDs_DoubleClick(object sender, EventArgs e)
        {
            int _m = listOfSSIDs.SelectedIndex;
            if (MessageBox.Show("Sure you want to delete ? " + listOfSSIDs.Items[_m],"delete entry",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                listOfSSIDs.Items.RemoveAt(_m);
                listOFPasswords.Items.RemoveAt(_m);
                listOfAuths.Items.RemoveAt(_m);

            }
            Properties.Settings.Default.Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }
    }
}