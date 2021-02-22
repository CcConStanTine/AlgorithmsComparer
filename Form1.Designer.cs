namespace Projekt_v2._0
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_algorithms = new System.Windows.Forms.CheckedListBox();
            this.comboBox_dataSetSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_dataPattern = new System.Windows.Forms.ComboBox();
            this.checkBox_Multithreaded = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(71, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(954, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sorting algorithms comparer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(268, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose the algorithms";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(440, 725);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sort!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_algorithms
            // 
            this.checkBox_algorithms.BackColor = System.Drawing.SystemColors.Info;
            this.checkBox_algorithms.Items.AddRange(new object[] {
            "Selection sort",
            "Bubble sort",
            "Insertion sort",
            "Merge sort",
            "Quick sort",
            "Heap sort"});
            this.checkBox_algorithms.Location = new System.Drawing.Point(178, 450);
            this.checkBox_algorithms.Name = "checkBox_algorithms";
            this.checkBox_algorithms.Size = new System.Drawing.Size(738, 214);
            this.checkBox_algorithms.TabIndex = 4;
            // 
            // comboBox_dataSetSize
            // 
            this.comboBox_dataSetSize.FormattingEnabled = true;
            this.comboBox_dataSetSize.Items.AddRange(new object[] {
            "100",
            "1000",
            "2500",
            "5000",
            "10000",
            "20000",
            "50000",
            "100000",
            "200000",
            "500000",
            "1000000"});
            this.comboBox_dataSetSize.Location = new System.Drawing.Point(213, 318);
            this.comboBox_dataSetSize.Name = "comboBox_dataSetSize";
            this.comboBox_dataSetSize.Size = new System.Drawing.Size(200, 39);
            this.comboBox_dataSetSize.TabIndex = 5;
            this.comboBox_dataSetSize.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(116, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose dataset size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(612, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "Choose data pattern";
            // 
            // comboBox_dataPattern
            // 
            this.comboBox_dataPattern.FormattingEnabled = true;
            this.comboBox_dataPattern.Items.AddRange(new object[] {
            "Rising values",
            "Decreasing values",
            "Random values"});
            this.comboBox_dataPattern.Location = new System.Drawing.Point(717, 318);
            this.comboBox_dataPattern.Name = "comboBox_dataPattern";
            this.comboBox_dataPattern.Size = new System.Drawing.Size(200, 39);
            this.comboBox_dataPattern.TabIndex = 8;
            this.comboBox_dataPattern.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // checkBox_Multithreaded
            // 
            this.checkBox_Multithreaded.AutoSize = true;
            this.checkBox_Multithreaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_Multithreaded.Location = new System.Drawing.Point(66, 153);
            this.checkBox_Multithreaded.Name = "checkBox_Multithreaded";
            this.checkBox_Multithreaded.Size = new System.Drawing.Size(927, 50);
            this.checkBox_Multithreaded.TabIndex = 9;
            this.checkBox_Multithreaded.Text = "Choose if program should use multiple threads";
            this.checkBox_Multithreaded.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1168, 912);
            this.Controls.Add(this.checkBox_Multithreaded);
            this.Controls.Add(this.comboBox_dataPattern);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_dataSetSize);
            this.Controls.Add(this.checkBox_algorithms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sorting algorithms comparer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkBox_algorithms;
        private System.Windows.Forms.ComboBox comboBox_dataSetSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_dataPattern;
        private System.Windows.Forms.CheckBox checkBox_Multithreaded;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

