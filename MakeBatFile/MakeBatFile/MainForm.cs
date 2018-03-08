using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MakeBatFile
{
    public partial class MainForm : Form
    {
        private x264Parameter clsParameters = new x264Parameter();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ClearParameter()
        {
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string crf = textBoxcrf.Text.Trim();
            string subme = comboBoxsubme.Text.Trim();
            string me = comboBoxme.Text.Trim();
            string merange = textBoxmerange.Text.Trim();
            string trellis = comboBoxtrellis.Text.Trim();
            string preset = comboBoxpreset.Text.Trim();

            if (!string.IsNullOrEmpty(me) && me != "dia" && me != "hex" && me != "umh" && me != "esa" && me != "tesa")
            {
                MessageBox.Show("me选项内容错误");
                return;
            }

            clsParameters.BeginSetParameter();
            clsParameters.crf = crf;
            clsParameters.subme = subme;
            clsParameters.me = me;
            clsParameters.merange = merange;
            clsParameters.trellis = trellis;
            clsParameters.preset = preset;
            clsParameters.EndSetParameter();

            string strParameter = clsParameters.GetParameterStr();
            string strName = clsParameters.GetNameStr();

            string fileName = "[8bit]" + strName + ".bat";

            string text = "";

            string tmpStr = "@ECHO OFF & CD/D \"%~dp0\"\r\n";
            text += tmpStr;

            tmpStr = ":start\r\nset in=%~dpn1\r\n";
            text += tmpStr;

            tmpStr = "\"F:\\video\\x264\\02\\avs4x264mod.exe\" --x264-binary \"x264_64_tMod-8bit-all.exe\"";
            text += tmpStr;

            text += strParameter;

            tmpStr = " --log-file \"%in%_" + strName + ".log\"";
            text += tmpStr;

            tmpStr = " -o \"%in%_" + strName + ".mp4\"";
            text += tmpStr;

            tmpStr = " \"%~1\"\r\nshift\r\nif not \"%~1\"==\"\" goto start\r\npause";
            text += tmpStr;

            doMakeFile(fileName, text);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxpreset.SelectedIndex = -1;
            textBoxcrf.Text = "";
            comboBoxsubme.SelectedIndex = -1;
            comboBoxme.SelectedIndex = -1;
            textBoxmerange.Text = "";
            comboBoxtrellis.SelectedIndex = -1;
        }

        private void doMakeFile(string fileName, string text)
        {
            System.IO.StreamWriter objWStream = new System.IO.StreamWriter(fileName, true, System.Text.Encoding.Default);
            objWStream.WriteLine(text);
            objWStream.Close();
            objWStream = null;
        }

        private void decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.' && !(char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void int_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
