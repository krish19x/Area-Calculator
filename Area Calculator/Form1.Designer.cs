
namespace Area_Calculator
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
            this.lengthbox = new System.Windows.Forms.TextBox();
            this.ValueBox = new System.Windows.Forms.ComboBox();
            this.lengthLbl = new System.Windows.Forms.Label();
            this.widthLbl = new System.Windows.Forms.Label();
            this.widhtbox = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Heightlbl = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lengthbox
            // 
            this.lengthbox.Location = new System.Drawing.Point(89, 52);
            this.lengthbox.Name = "lengthbox";
            this.lengthbox.Size = new System.Drawing.Size(130, 20);
            this.lengthbox.TabIndex = 0;
            this.lengthbox.Visible = false;
            // 
            // ValueBox
            // 
            this.ValueBox.FormattingEnabled = true;
            this.ValueBox.Location = new System.Drawing.Point(8, 12);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(121, 21);
            this.ValueBox.TabIndex = 1;
            this.ValueBox.Text = "Select a Shape";
            this.ValueBox.SelectedIndexChanged += new System.EventHandler(this.ValueBox_SelectedIndexChanged);
            // 
            // lengthLbl
            // 
            this.lengthLbl.AutoSize = true;
            this.lengthLbl.Location = new System.Drawing.Point(12, 52);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(71, 13);
            this.lengthLbl.TabIndex = 2;
            this.lengthLbl.Text = "MAJOR AXIS";
            this.lengthLbl.Visible = false;
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(12, 78);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(32, 13);
            this.widthLbl.TabIndex = 4;
            this.widthLbl.Text = "width";
            this.widthLbl.Visible = false;
            // 
            // widhtbox
            // 
            this.widhtbox.Location = new System.Drawing.Point(89, 78);
            this.widhtbox.Name = "widhtbox";
            this.widhtbox.Size = new System.Drawing.Size(130, 20);
            this.widhtbox.TabIndex = 3;
            this.widhtbox.Visible = false;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(89, 130);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 7;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // Heightlbl
            // 
            this.Heightlbl.AutoSize = true;
            this.Heightlbl.Location = new System.Drawing.Point(12, 104);
            this.Heightlbl.Name = "Heightlbl";
            this.Heightlbl.Size = new System.Drawing.Size(38, 13);
            this.Heightlbl.TabIndex = 10;
            this.Heightlbl.Text = "Height";
            this.Heightlbl.Visible = false;
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(89, 104);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(130, 20);
            this.HeightBox.TabIndex = 9;
            this.HeightBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Area-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Perimeter-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 229);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Heightlbl);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.widhtbox);
            this.Controls.Add(this.lengthLbl);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.lengthbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lengthbox;
        private System.Windows.Forms.ComboBox ValueBox;
        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.TextBox widhtbox;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Heightlbl;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

