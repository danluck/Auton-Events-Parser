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
            this.buttonHelp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelByteLength = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(12, 29);
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
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hex data:";
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.Location = new System.Drawing.Point(12, 141);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(119, 38);
            this.buttonDeserialize.TabIndex = 2;
            this.buttonDeserialize.Text = "Deserialize";
            this.buttonDeserialize.UseVisualStyleBackColor = true;
            this.buttonDeserialize.Click += new System.EventHandler(this.buttonDeserialize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelByteLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 199);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Length:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 447);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDeserialize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxInput);
            this.Name = "Form1";
            this.Text = "Auton Events Parser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

