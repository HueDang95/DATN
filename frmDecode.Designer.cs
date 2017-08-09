namespace frmEncode
{
    partial class frmDecode
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
            this.components = new System.ComponentModel.Container();
            this.grp = new System.Windows.Forms.GroupBox();
            this.txtPDf = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTextAfterConvert = new System.Windows.Forms.RichTextBox();
            this.lblAfter = new System.Windows.Forms.ListBox();
            this.lblCurrent = new System.Windows.Forms.ListBox();
            this.lblDNAE = new System.Windows.Forms.Label();
            this.lblMY1 = new System.Windows.Forms.Label();
            this.lblYprimer = new System.Windows.Forms.Label();
            this.lblMDNA1 = new System.Windows.Forms.Label();
            this.txtZY = new System.Windows.Forms.TextBox();
            this.txtZX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXY = new System.Windows.Forms.TextBox();
            this.txtWX = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtWordEncode = new System.Windows.Forms.TextBox();
            this.txtInputWord = new System.Windows.Forms.RichTextBox();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // grp
            // 
            this.grp.Controls.Add(this.txtPDf);
            this.grp.Controls.Add(this.btnConvert);
            this.grp.Controls.Add(this.label3);
            this.grp.Controls.Add(this.txtTextAfterConvert);
            this.grp.Controls.Add(this.lblAfter);
            this.grp.Controls.Add(this.lblCurrent);
            this.grp.Controls.Add(this.lblDNAE);
            this.grp.Controls.Add(this.lblMY1);
            this.grp.Controls.Add(this.lblYprimer);
            this.grp.Controls.Add(this.lblMDNA1);
            this.grp.Controls.Add(this.txtZY);
            this.grp.Controls.Add(this.txtZX);
            this.grp.Controls.Add(this.label2);
            this.grp.Controls.Add(this.label1);
            this.grp.Controls.Add(this.txtXY);
            this.grp.Controls.Add(this.txtWX);
            this.grp.Controls.Add(this.btnProcess);
            this.grp.Controls.Add(this.txtWordEncode);
            this.grp.Controls.Add(this.txtInputWord);
            this.grp.Controls.Add(this.btnChangeColor);
            this.grp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp.Location = new System.Drawing.Point(0, 0);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(814, 350);
            this.grp.TabIndex = 1;
            this.grp.TabStop = false;
            this.grp.Text = "Chuyển đổi";
            // 
            // txtPDf
            // 
            this.txtPDf.Location = new System.Drawing.Point(647, 79);
            this.txtPDf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPDf.Multiline = true;
            this.txtPDf.Name = "txtPDf";
            this.txtPDf.Size = new System.Drawing.Size(100, 71);
            this.txtPDf.TabIndex = 20;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(647, 33);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(74, 24);
            this.btnConvert.TabIndex = 19;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Chữ sau khi mã hóa:";
            // 
            // txtTextAfterConvert
            // 
            this.txtTextAfterConvert.Location = new System.Drawing.Point(647, 159);
            this.txtTextAfterConvert.Name = "txtTextAfterConvert";
            this.txtTextAfterConvert.Size = new System.Drawing.Size(100, 66);
            this.txtTextAfterConvert.TabIndex = 17;
            this.txtTextAfterConvert.Text = "";
            // 
            // lblAfter
            // 
            this.lblAfter.FormattingEnabled = true;
            this.lblAfter.Location = new System.Drawing.Point(403, 159);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(120, 95);
            this.lblAfter.TabIndex = 16;
            // 
            // lblCurrent
            // 
            this.lblCurrent.FormattingEnabled = true;
            this.lblCurrent.Location = new System.Drawing.Point(277, 159);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(120, 95);
            this.lblCurrent.TabIndex = 15;
            // 
            // lblDNAE
            // 
            this.lblDNAE.AutoSize = true;
            this.lblDNAE.Location = new System.Drawing.Point(128, 214);
            this.lblDNAE.Name = "lblDNAE";
            this.lblDNAE.Size = new System.Drawing.Size(35, 13);
            this.lblDNAE.TabIndex = 14;
            this.lblDNAE.Text = "label3";
            // 
            // lblMY1
            // 
            this.lblMY1.AutoSize = true;
            this.lblMY1.Location = new System.Drawing.Point(60, 214);
            this.lblMY1.Name = "lblMY1";
            this.lblMY1.Size = new System.Drawing.Size(35, 13);
            this.lblMY1.TabIndex = 13;
            this.lblMY1.Text = "label3";
            // 
            // lblYprimer
            // 
            this.lblYprimer.AutoSize = true;
            this.lblYprimer.Location = new System.Drawing.Point(128, 169);
            this.lblYprimer.Name = "lblYprimer";
            this.lblYprimer.Size = new System.Drawing.Size(35, 13);
            this.lblYprimer.TabIndex = 12;
            this.lblYprimer.Text = "label3";
            // 
            // lblMDNA1
            // 
            this.lblMDNA1.AutoSize = true;
            this.lblMDNA1.Location = new System.Drawing.Point(60, 169);
            this.lblMDNA1.Name = "lblMDNA1";
            this.lblMDNA1.Size = new System.Drawing.Size(35, 13);
            this.lblMDNA1.TabIndex = 11;
            this.lblMDNA1.Text = "label3";
            // 
            // txtZY
            // 
            this.txtZY.Location = new System.Drawing.Point(473, 55);
            this.txtZY.Name = "txtZY";
            this.txtZY.Size = new System.Drawing.Size(100, 20);
            this.txtZY.TabIndex = 10;
            this.txtZY.Text = "0,7812";
            // 
            // txtZX
            // 
            this.txtZX.Location = new System.Drawing.Point(473, 29);
            this.txtZX.Name = "txtZX";
            this.txtZX.Size = new System.Drawing.Size(100, 20);
            this.txtZX.TabIndex = 9;
            this.txtZX.Text = "0,21821";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Skey-Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Skey-X:";
            // 
            // txtXY
            // 
            this.txtXY.Location = new System.Drawing.Point(367, 56);
            this.txtXY.Name = "txtXY";
            this.txtXY.Size = new System.Drawing.Size(100, 20);
            this.txtXY.TabIndex = 6;
            this.txtXY.Text = "5,1682";
            // 
            // txtWX
            // 
            this.txtWX.Location = new System.Drawing.Point(367, 29);
            this.txtWX.Name = "txtWX";
            this.txtWX.Size = new System.Drawing.Size(100, 20);
            this.txtWX.TabIndex = 5;
            this.txtWX.Text = "4,2991";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(203, 103);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtWordEncode
            // 
            this.txtWordEncode.Location = new System.Drawing.Point(63, 103);
            this.txtWordEncode.MaxLength = 1;
            this.txtWordEncode.Name = "txtWordEncode";
            this.txtWordEncode.Size = new System.Drawing.Size(100, 20);
            this.txtWordEncode.TabIndex = 3;
            // 
            // txtInputWord
            // 
            this.txtInputWord.Location = new System.Drawing.Point(63, 31);
            this.txtInputWord.Name = "txtInputWord";
            this.txtInputWord.Size = new System.Drawing.Size(100, 66);
            this.txtInputWord.TabIndex = 2;
            this.txtInputWord.Text = "";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(203, 29);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(75, 23);
            this.btnChangeColor.TabIndex = 1;
            this.btnChangeColor.Text = "Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmDecode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 350);
            this.Controls.Add(this.grp);
            this.Name = "frmDecode";
            this.Text = "frmDecode";
            this.Load += new System.EventHandler(this.frmDecode_Load);
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.RichTextBox txtInputWord;
        private System.Windows.Forms.TextBox txtWordEncode;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXY;
        private System.Windows.Forms.TextBox txtWX;
        private System.Windows.Forms.TextBox txtZX;
        private System.Windows.Forms.TextBox txtZY;
        private System.Windows.Forms.Label lblMDNA1;
        private System.Windows.Forms.Label lblYprimer;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Label lblDNAE;
        private System.Windows.Forms.Label lblMY1;
        private System.Windows.Forms.ListBox lblCurrent;
        private System.Windows.Forms.ListBox lblAfter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtTextAfterConvert;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtPDf;
    }
}