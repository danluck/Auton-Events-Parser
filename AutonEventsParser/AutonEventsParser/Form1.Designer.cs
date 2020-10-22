namespace AutonEventsParser
{
    partial class Form1
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
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeserialize = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelByteLength = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.radioButtonIsHex = new System.Windows.Forms.RadioButton();
            this.radioButtonIsDecimal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonBigEndian = new System.Windows.Forms.RadioButton();
            this.radioButtonLittleEndian = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(12, 102);
            this.richTextBoxInput.MaxLength = 65536;
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(450, 105);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input:";
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.Location = new System.Drawing.Point(12, 213);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(119, 38);
            this.buttonDeserialize.TabIndex = 2;
            this.buttonDeserialize.Text = "Deserialize";
            this.buttonDeserialize.UseVisualStyleBackColor = true;
            this.buttonDeserialize.Click += new System.EventHandler(this.buttonDeserialize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelByteLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 137);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // labelByteLength
            // 
            this.labelByteLength.AutoSize = true;
            this.labelByteLength.Location = new System.Drawing.Point(69, 22);
            this.labelByteLength.Name = "labelByteLength";
            this.labelByteLength.Size = new System.Drawing.Size(13, 17);
            this.labelByteLength.TabIndex = 1;
            this.labelByteLength.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Length:";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(359, 406);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(103, 32);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.TabStop = false;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(468, 29);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(294, 314);
            this.richTextBoxOutput.TabIndex = 5;
            this.richTextBoxOutput.Text = "";
            // 
            // radioButtonIsHex
            // 
            this.radioButtonIsHex.AutoSize = true;
            this.radioButtonIsHex.Location = new System.Drawing.Point(9, 21);
            this.radioButtonIsHex.Name = "radioButtonIsHex";
            this.radioButtonIsHex.Size = new System.Drawing.Size(53, 21);
            this.radioButtonIsHex.TabIndex = 6;
            this.radioButtonIsHex.TabStop = true;
            this.radioButtonIsHex.Text = "Hex";
            this.radioButtonIsHex.UseVisualStyleBackColor = true;
            // 
            // radioButtonIsDecimal
            // 
            this.radioButtonIsDecimal.AutoSize = true;
            this.radioButtonIsDecimal.Location = new System.Drawing.Point(68, 21);
            this.radioButtonIsDecimal.Name = "radioButtonIsDecimal";
            this.radioButtonIsDecimal.Size = new System.Drawing.Size(79, 21);
            this.radioButtonIsDecimal.TabIndex = 7;
            this.radioButtonIsDecimal.TabStop = true;
            this.radioButtonIsDecimal.Text = "Decimal";
            this.radioButtonIsDecimal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonIsDecimal);
            this.groupBox3.Controls.Add(this.radioButtonIsHex);
            this.groupBox3.Location = new System.Drawing.Point(12, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 67);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Format:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonBigEndian);
            this.groupBox4.Controls.Add(this.radioButtonLittleEndian);
            this.groupBox4.Location = new System.Drawing.Point(194, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 67);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Endianness:";
            // 
            // radioButtonBigEndian
            // 
            this.radioButtonBigEndian.AutoSize = true;
            this.radioButtonBigEndian.Location = new System.Drawing.Point(9, 40);
            this.radioButtonBigEndian.Name = "radioButtonBigEndian";
            this.radioButtonBigEndian.Size = new System.Drawing.Size(93, 21);
            this.radioButtonBigEndian.TabIndex = 7;
            this.radioButtonBigEndian.TabStop = true;
            this.radioButtonBigEndian.Text = "BigEndian";
            this.radioButtonBigEndian.UseVisualStyleBackColor = true;
            // 
            // radioButtonLittleEndian
            // 
            this.radioButtonLittleEndian.AutoSize = true;
            this.radioButtonLittleEndian.Location = new System.Drawing.Point(9, 18);
            this.radioButtonLittleEndian.Name = "radioButtonLittleEndian";
            this.radioButtonLittleEndian.Size = new System.Drawing.Size(103, 21);
            this.radioButtonLittleEndian.TabIndex = 6;
            this.radioButtonLittleEndian.TabStop = true;
            this.radioButtonLittleEndian.Text = "LittleEndian";
            this.radioButtonLittleEndian.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 447);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDeserialize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxInput);
            this.Name = "Form1";
            this.Text = "Auton Events Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeserialize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelByteLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.RadioButton radioButtonIsHex;
        private System.Windows.Forms.RadioButton radioButtonIsDecimal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonBigEndian;
        private System.Windows.Forms.RadioButton radioButtonLittleEndian;
    }
}

