namespace MakeBatFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxcrf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxmerange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxme = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxpreset = new System.Windows.Forms.ComboBox();
            this.comboBoxsubme = new System.Windows.Forms.ComboBox();
            this.comboBoxtrellis = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(264, 182);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "Make";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxcrf
            // 
            this.textBoxcrf.Location = new System.Drawing.Point(80, 90);
            this.textBoxcrf.Name = "textBoxcrf";
            this.textBoxcrf.Size = new System.Drawing.Size(100, 21);
            this.textBoxcrf.TabIndex = 1;
            this.textBoxcrf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimal_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "crf:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "me:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "subme:";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(264, 211);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxmerange
            // 
            this.textBoxmerange.Location = new System.Drawing.Point(80, 210);
            this.textBoxmerange.Name = "textBoxmerange";
            this.textBoxmerange.Size = new System.Drawing.Size(100, 21);
            this.textBoxmerange.TabIndex = 1;
            this.textBoxmerange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "merange:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "trellis:";
            // 
            // comboBoxme
            // 
            this.comboBoxme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxme.FormattingEnabled = true;
            this.comboBoxme.Items.AddRange(new object[] {
            "dia",
            "hex",
            "umh",
            "esa",
            "tesa"});
            this.comboBoxme.Location = new System.Drawing.Point(80, 130);
            this.comboBoxme.Name = "comboBoxme";
            this.comboBoxme.Size = new System.Drawing.Size(100, 20);
            this.comboBoxme.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "preset:";
            // 
            // comboBoxpreset
            // 
            this.comboBoxpreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxpreset.FormattingEnabled = true;
            this.comboBoxpreset.Items.AddRange(new object[] {
            "veryfast",
            "faster",
            "fast",
            "medium",
            "slow",
            "slower",
            "veryslow"});
            this.comboBoxpreset.Location = new System.Drawing.Point(80, 50);
            this.comboBoxpreset.Name = "comboBoxpreset";
            this.comboBoxpreset.Size = new System.Drawing.Size(100, 20);
            this.comboBoxpreset.TabIndex = 3;
            // 
            // comboBoxsubme
            // 
            this.comboBoxsubme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxsubme.FormattingEnabled = true;
            this.comboBoxsubme.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.comboBoxsubme.Location = new System.Drawing.Point(81, 170);
            this.comboBoxsubme.Name = "comboBoxsubme";
            this.comboBoxsubme.Size = new System.Drawing.Size(100, 20);
            this.comboBoxsubme.TabIndex = 3;
            // 
            // comboBoxtrellis
            // 
            this.comboBoxtrellis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxtrellis.FormattingEnabled = true;
            this.comboBoxtrellis.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBoxtrellis.Location = new System.Drawing.Point(81, 250);
            this.comboBoxtrellis.Name = "comboBoxtrellis";
            this.comboBoxtrellis.Size = new System.Drawing.Size(100, 20);
            this.comboBoxtrellis.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 310);
            this.Controls.Add(this.comboBoxpreset);
            this.Controls.Add(this.comboBoxtrellis);
            this.Controls.Add(this.comboBoxsubme);
            this.Controls.Add(this.comboBoxme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxmerange);
            this.Controls.Add(this.textBoxcrf);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxcrf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxmerange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxpreset;
        private System.Windows.Forms.ComboBox comboBoxsubme;
        private System.Windows.Forms.ComboBox comboBoxtrellis;
    }
}

