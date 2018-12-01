namespace Moemi_Hagiyama_Lab03_Ex1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_relDisp = new System.Windows.Forms.Label();
            this.lbl_rel = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txt_factorial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_errEvenOdd = new System.Windows.Forms.Label();
            this.lbl_relOdd = new System.Windows.Forms.Label();
            this.lbl_odd = new System.Windows.Forms.Label();
            this.lbl_relEven = new System.Windows.Forms.Label();
            this.lbl_even = new System.Windows.Forms.Label();
            this.btn_checkEvenOdd = new System.Windows.Forms.Button();
            this.txt_EvenOdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_errGenerate = new System.Windows.Forms.Label();
            this.lbl_err_Index = new System.Windows.Forms.Label();
            this.list_valLowHigh = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_high = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_low = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.list_genValues = new System.Windows.Forms.ListBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.rbtn_char = new System.Windows.Forms.RadioButton();
            this.rbtn_double = new System.Windows.Forms.RadioButton();
            this.rbtn_integer = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_relDisp);
            this.groupBox1.Controls.Add(this.lbl_rel);
            this.groupBox1.Controls.Add(this.btn_calculate);
            this.groupBox1.Controls.Add(this.txt_factorial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(1) Calculate Asynchronously";
            // 
            // lbl_relDisp
            // 
            this.lbl_relDisp.AutoSize = true;
            this.lbl_relDisp.ForeColor = System.Drawing.Color.Black;
            this.lbl_relDisp.Location = new System.Drawing.Point(146, 69);
            this.lbl_relDisp.Name = "lbl_relDisp";
            this.lbl_relDisp.Size = new System.Drawing.Size(0, 13);
            this.lbl_relDisp.TabIndex = 4;
            // 
            // lbl_rel
            // 
            this.lbl_rel.AutoSize = true;
            this.lbl_rel.ForeColor = System.Drawing.Color.Red;
            this.lbl_rel.Location = new System.Drawing.Point(93, 69);
            this.lbl_rel.Name = "lbl_rel";
            this.lbl_rel.Size = new System.Drawing.Size(0, 13);
            this.lbl_rel.TabIndex = 3;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(10, 64);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // txt_factorial
            // 
            this.txt_factorial.Location = new System.Drawing.Point(96, 27);
            this.txt_factorial.Name = "txt_factorial";
            this.txt_factorial.Size = new System.Drawing.Size(100, 20);
            this.txt_factorial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Factorial of: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_errEvenOdd);
            this.groupBox2.Controls.Add(this.lbl_relOdd);
            this.groupBox2.Controls.Add(this.lbl_odd);
            this.groupBox2.Controls.Add(this.lbl_relEven);
            this.groupBox2.Controls.Add(this.lbl_even);
            this.groupBox2.Controls.Add(this.btn_checkEvenOdd);
            this.groupBox2.Controls.Add(this.txt_EvenOdd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(2) Check for Even/Odd";
            // 
            // lbl_errEvenOdd
            // 
            this.lbl_errEvenOdd.AutoSize = true;
            this.lbl_errEvenOdd.ForeColor = System.Drawing.Color.Red;
            this.lbl_errEvenOdd.Location = new System.Drawing.Point(9, 101);
            this.lbl_errEvenOdd.Name = "lbl_errEvenOdd";
            this.lbl_errEvenOdd.Size = new System.Drawing.Size(0, 13);
            this.lbl_errEvenOdd.TabIndex = 9;
            // 
            // lbl_relOdd
            // 
            this.lbl_relOdd.AutoSize = true;
            this.lbl_relOdd.ForeColor = System.Drawing.Color.Black;
            this.lbl_relOdd.Location = new System.Drawing.Point(150, 101);
            this.lbl_relOdd.Name = "lbl_relOdd";
            this.lbl_relOdd.Size = new System.Drawing.Size(0, 13);
            this.lbl_relOdd.TabIndex = 8;
            // 
            // lbl_odd
            // 
            this.lbl_odd.AutoSize = true;
            this.lbl_odd.ForeColor = System.Drawing.Color.Black;
            this.lbl_odd.Location = new System.Drawing.Point(110, 101);
            this.lbl_odd.Name = "lbl_odd";
            this.lbl_odd.Size = new System.Drawing.Size(34, 13);
            this.lbl_odd.TabIndex = 7;
            this.lbl_odd.Text = "Odd:";
            this.lbl_odd.Visible = false;
            // 
            // lbl_relEven
            // 
            this.lbl_relEven.AutoSize = true;
            this.lbl_relEven.ForeColor = System.Drawing.Color.Black;
            this.lbl_relEven.Location = new System.Drawing.Point(49, 101);
            this.lbl_relEven.Name = "lbl_relEven";
            this.lbl_relEven.Size = new System.Drawing.Size(0, 13);
            this.lbl_relEven.TabIndex = 6;
            // 
            // lbl_even
            // 
            this.lbl_even.AutoSize = true;
            this.lbl_even.ForeColor = System.Drawing.Color.Black;
            this.lbl_even.Location = new System.Drawing.Point(7, 101);
            this.lbl_even.Name = "lbl_even";
            this.lbl_even.Size = new System.Drawing.Size(40, 13);
            this.lbl_even.TabIndex = 5;
            this.lbl_even.Text = "Even:";
            this.lbl_even.Visible = false;
            // 
            // btn_checkEvenOdd
            // 
            this.btn_checkEvenOdd.Location = new System.Drawing.Point(67, 65);
            this.btn_checkEvenOdd.Name = "btn_checkEvenOdd";
            this.btn_checkEvenOdd.Size = new System.Drawing.Size(150, 23);
            this.btn_checkEvenOdd.TabIndex = 2;
            this.btn_checkEvenOdd.Text = "Check for Even or Odd";
            this.btn_checkEvenOdd.UseVisualStyleBackColor = true;
            this.btn_checkEvenOdd.Click += new System.EventHandler(this.btn_checkEvenOdd_Click);
            // 
            // txt_EvenOdd
            // 
            this.txt_EvenOdd.Location = new System.Drawing.Point(96, 27);
            this.txt_EvenOdd.Name = "txt_EvenOdd";
            this.txt_EvenOdd.Size = new System.Drawing.Size(100, 20);
            this.txt_EvenOdd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input Number: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_errGenerate);
            this.groupBox3.Controls.Add(this.lbl_err_Index);
            this.groupBox3.Controls.Add(this.list_valLowHigh);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_display);
            this.groupBox3.Controls.Add(this.btn_search);
            this.groupBox3.Controls.Add(this.txt_high);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_low);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_search);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.list_genValues);
            this.groupBox3.Controls.Add(this.btn_generate);
            this.groupBox3.Controls.Add(this.rbtn_char);
            this.groupBox3.Controls.Add(this.rbtn_double);
            this.groupBox3.Controls.Add(this.rbtn_integer);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(275, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 259);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(3) Display LIst of Values and Search";
            // 
            // lbl_errGenerate
            // 
            this.lbl_errGenerate.AutoSize = true;
            this.lbl_errGenerate.ForeColor = System.Drawing.Color.Red;
            this.lbl_errGenerate.Location = new System.Drawing.Point(103, 51);
            this.lbl_errGenerate.Name = "lbl_errGenerate";
            this.lbl_errGenerate.Size = new System.Drawing.Size(0, 13);
            this.lbl_errGenerate.TabIndex = 16;
            // 
            // lbl_err_Index
            // 
            this.lbl_err_Index.AutoSize = true;
            this.lbl_err_Index.ForeColor = System.Drawing.Color.Red;
            this.lbl_err_Index.Location = new System.Drawing.Point(103, 158);
            this.lbl_err_Index.Name = "lbl_err_Index";
            this.lbl_err_Index.Size = new System.Drawing.Size(0, 13);
            this.lbl_err_Index.TabIndex = 15;
            // 
            // list_valLowHigh
            // 
            this.list_valLowHigh.FormattingEnabled = true;
            this.list_valLowHigh.Location = new System.Drawing.Point(106, 194);
            this.list_valLowHigh.Name = "list_valLowHigh";
            this.list_valLowHigh.Size = new System.Drawing.Size(248, 30);
            this.list_valLowHigh.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Output of Values between Low and High:";
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(279, 119);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(75, 23);
            this.btn_display.TabIndex = 12;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(279, 64);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_high
            // 
            this.txt_high.Location = new System.Drawing.Point(214, 133);
            this.txt_high.Name = "txt_high";
            this.txt_high.Size = new System.Drawing.Size(46, 20);
            this.txt_high.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Input High Index: ";
            // 
            // txt_low
            // 
            this.txt_low.Location = new System.Drawing.Point(214, 101);
            this.txt_low.Name = "txt_low";
            this.txt_low.Size = new System.Drawing.Size(46, 20);
            this.txt_low.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input Low Index: ";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(214, 66);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(46, 20);
            this.txt_search.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input Value for Search: ";
            // 
            // list_genValues
            // 
            this.list_genValues.FormattingEnabled = true;
            this.list_genValues.Location = new System.Drawing.Point(7, 51);
            this.list_genValues.Name = "list_genValues";
            this.list_genValues.Size = new System.Drawing.Size(71, 173);
            this.list_genValues.TabIndex = 4;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(231, 25);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(117, 23);
            this.btn_generate.TabIndex = 3;
            this.btn_generate.Text = "Generate Values";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // rbtn_char
            // 
            this.rbtn_char.AutoSize = true;
            this.rbtn_char.Location = new System.Drawing.Point(161, 28);
            this.rbtn_char.Name = "rbtn_char";
            this.rbtn_char.Size = new System.Drawing.Size(51, 17);
            this.rbtn_char.TabIndex = 2;
            this.rbtn_char.TabStop = true;
            this.rbtn_char.Text = "Char";
            this.rbtn_char.UseVisualStyleBackColor = true;
            // 
            // rbtn_double
            // 
            this.rbtn_double.AutoSize = true;
            this.rbtn_double.Location = new System.Drawing.Point(84, 27);
            this.rbtn_double.Name = "rbtn_double";
            this.rbtn_double.Size = new System.Drawing.Size(71, 17);
            this.rbtn_double.TabIndex = 1;
            this.rbtn_double.TabStop = true;
            this.rbtn_double.Text = "Doubles";
            this.rbtn_double.UseVisualStyleBackColor = true;
            // 
            // rbtn_integer
            // 
            this.rbtn_integer.AutoSize = true;
            this.rbtn_integer.Location = new System.Drawing.Point(7, 27);
            this.rbtn_integer.Name = "rbtn_integer";
            this.rbtn_integer.Size = new System.Drawing.Size(71, 17);
            this.rbtn_integer.TabIndex = 0;
            this.rbtn_integer.TabStop = true;
            this.rbtn_integer.Text = "Integers";
            this.rbtn_integer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 302);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Asynchronously Programming";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txt_factorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_checkEvenOdd;
        private System.Windows.Forms.TextBox txt_EvenOdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtn_integer;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.RadioButton rbtn_char;
        private System.Windows.Forms.RadioButton rbtn_double;
        private System.Windows.Forms.TextBox txt_high;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_low;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_genValues;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ListBox list_valLowHigh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_relDisp;
        private System.Windows.Forms.Label lbl_rel;
        private System.Windows.Forms.Label lbl_errEvenOdd;
        private System.Windows.Forms.Label lbl_relOdd;
        private System.Windows.Forms.Label lbl_odd;
        private System.Windows.Forms.Label lbl_relEven;
        private System.Windows.Forms.Label lbl_even;
        private System.Windows.Forms.Label lbl_err_Index;
        private System.Windows.Forms.Label lbl_errGenerate;
    }
}

