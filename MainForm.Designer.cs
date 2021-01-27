namespace TextEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butSelectFile = new System.Windows.Forms.Button();
            this.butOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fieldFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.fieldContent = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelSymbolCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butSelectFile
            // 
            this.butSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSelectFile.Location = new System.Drawing.Point(716, 17);
            this.butSelectFile.Name = "butSelectFile";
            this.butSelectFile.Size = new System.Drawing.Size(81, 28);
            this.butSelectFile.TabIndex = 0;
            this.butSelectFile.Text = "Выбрать";
            this.butSelectFile.UseVisualStyleBackColor = true;
            this.butSelectFile.Click += new System.EventHandler(this.butSelectFile_Click);
            // 
            // butOpenFile
            // 
            this.butOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butOpenFile.Location = new System.Drawing.Point(803, 17);
            this.butOpenFile.Name = "butOpenFile";
            this.butOpenFile.Size = new System.Drawing.Size(81, 28);
            this.butOpenFile.TabIndex = 1;
            this.butOpenFile.Text = "Открыть";
            this.butOpenFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите фйал";
            // 
            // fieldFilePath
            // 
            this.fieldFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldFilePath.Location = new System.Drawing.Point(131, 20);
            this.fieldFilePath.Name = "fieldFilePath";
            this.fieldFilePath.Size = new System.Drawing.Size(577, 22);
            this.fieldFilePath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шрифт";
            // 
            // numFontSize
            // 
            this.numFontSize.Location = new System.Drawing.Point(131, 56);
            this.numFontSize.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(120, 22);
            this.numFontSize.TabIndex = 5;
            this.numFontSize.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numFontSize.ValueChanged += new System.EventHandler(this.numFontSize_ValueChanged);
            // 
            // fieldContent
            // 
            this.fieldContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldContent.Location = new System.Drawing.Point(12, 86);
            this.fieldContent.Multiline = true;
            this.fieldContent.Name = "fieldContent";
            this.fieldContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fieldContent.Size = new System.Drawing.Size(879, 249);
            this.fieldContent.TabIndex = 6;
            // 
            // butSave
            // 
            this.butSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butSave.Location = new System.Drawing.Point(799, 341);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(94, 35);
            this.butSave.TabIndex = 7;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelSymbolCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 383);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(905, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelSymbolCount
            // 
            this.labelSymbolCount.Name = "labelSymbolCount";
            this.labelSymbolCount.Size = new System.Drawing.Size(166, 20);
            this.labelSymbolCount.Text = "Количество символов:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 409);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.fieldContent);
            this.Controls.Add(this.numFontSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fieldFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butOpenFile);
            this.Controls.Add(this.butSelectFile);
            this.Name = "MainForm";
            this.Text = "Текстовый редактор";
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSelectFile;
        private System.Windows.Forms.Button butOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fieldFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.TextBox fieldContent;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelSymbolCount;
    }
}

