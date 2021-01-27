using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public interface IMainForm
    {
        string FilePath { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            butOpenFile.Click += new EventHandler(butOpenFile_Click);
            butSave.Click += butSave_Click;
            fieldContent.Click += fieldContent_TextChanged;
            butSelectFile.Click += butSelectFile_Click;
            numFontSize.ValueChanged += numFontSize_ValueChanged;
        }
        #region Проброс событий
        private void butOpenFile_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null) FileSaveClick(this, EventArgs.Empty);
        }
        private void fieldContent_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null) ContentChanged(this, EventArgs.Empty);
        }
        #endregion

        #region реализация IMainForm
        public string FilePath
        {
            get { return fieldFilePath.Text; }
        }
        public string Content
        {
            get { return fieldContent.Text; }
            set { fieldContent.Text = value; }
        }
        public void SetSymbolCount(int count)
        {
            labelSymbolCount.Text = count.ToString();
        }
        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentChanged;
        #endregion

        private void butSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fieldFilePath.Text = dlg.FileName;
                if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
            }
        }

        private void numFontSize_ValueChanged(object sender, EventArgs e)
        {
            fieldContent.Font = new Font("Calibri", (float)numFontSize.Value);
        }
    }
}
