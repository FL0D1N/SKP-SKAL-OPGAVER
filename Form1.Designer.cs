namespace Hastighed
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cBox1 = new System.Windows.Forms.ComboBox();
            this.cBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(327, 65);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(144, 29);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Hastigheds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "converter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cBox1
            // 
            this.cBox1.FormattingEnabled = true;
            this.cBox1.Items.AddRange(new object[] {
            "M/s",
            "Km/t"});
            this.cBox1.Location = new System.Drawing.Point(330, 199);
            this.cBox1.Name = "cBox1";
            this.cBox1.Size = new System.Drawing.Size(140, 21);
            this.cBox1.TabIndex = 3;
            // 
            // cBox2
            // 
            this.cBox2.FormattingEnabled = true;
            this.cBox2.Items.AddRange(new object[] {
            "M/s",
            "Km/t"});
            this.cBox2.Location = new System.Drawing.Point(330, 226);
            this.cBox2.Name = "cBox2";
            this.cBox2.Size = new System.Drawing.Size(140, 21);
            this.cBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hastighed :";
            // 
            // btnResult
            // 
            this.btnResult.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Location = new System.Drawing.Point(330, 253);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(140, 23);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Klik her :P ";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox2);
            this.Controls.Add(this.cBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Hastighed Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cBox1;
        private System.Windows.Forms.ComboBox cBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResult;
    }
}

