namespace AnomaliePaliw
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.End = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LeakType = new System.Windows.Forms.CheckBox();
            this.DamageType = new System.Windows.Forms.CheckBox();
            this.DiscalibratedType = new System.Windows.Forms.CheckBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StableOption = new System.Windows.Forms.RadioButton();
            this.VariousOption = new System.Windows.Forms.RadioButton();
            this.PipeOption = new System.Windows.Forms.RadioButton();
            this.TextBoxA = new System.Windows.Forms.TextBox();
            this.TextBoxB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Type,
            this.Value,
            this.Start,
            this.End});
            this.listView1.Location = new System.Drawing.Point(228, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(505, 441);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add to list";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete form list";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBoxB);
            this.groupBox1.Controls.Add(this.TextBoxA);
            this.groupBox1.Controls.Add(this.PipeOption);
            this.groupBox1.Controls.Add(this.VariousOption);
            this.groupBox1.Controls.Add(this.StableOption);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 168);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leak Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LeakType
            // 
            this.LeakType.AutoSize = true;
            this.LeakType.Location = new System.Drawing.Point(13, 13);
            this.LeakType.Name = "LeakType";
            this.LeakType.Size = new System.Drawing.Size(50, 17);
            this.LeakType.TabIndex = 5;
            this.LeakType.Text = "Leak";
            this.LeakType.UseVisualStyleBackColor = true;
            this.LeakType.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DamageType
            // 
            this.DamageType.AutoSize = true;
            this.DamageType.Location = new System.Drawing.Point(13, 211);
            this.DamageType.Name = "DamageType";
            this.DamageType.Size = new System.Drawing.Size(66, 17);
            this.DamageType.TabIndex = 6;
            this.DamageType.Text = "Damage";
            this.DamageType.UseVisualStyleBackColor = true;
            this.DamageType.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // DiscalibratedType
            // 
            this.DiscalibratedType.AutoSize = true;
            this.DiscalibratedType.Location = new System.Drawing.Point(12, 257);
            this.DiscalibratedType.Name = "DiscalibratedType";
            this.DiscalibratedType.Size = new System.Drawing.Size(87, 17);
            this.DiscalibratedType.TabIndex = 7;
            this.DiscalibratedType.Text = "Discalibrated";
            this.DiscalibratedType.UseVisualStyleBackColor = true;
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(59, 328);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(163, 20);
            this.StartDate.TabIndex = 8;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(59, 349);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(163, 20);
            this.EndDate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "To";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StableOption
            // 
            this.StableOption.AutoSize = true;
            this.StableOption.Location = new System.Drawing.Point(7, 19);
            this.StableOption.Name = "StableOption";
            this.StableOption.Size = new System.Drawing.Size(55, 17);
            this.StableOption.TabIndex = 0;
            this.StableOption.TabStop = true;
            this.StableOption.Text = "Stable";
            this.StableOption.UseVisualStyleBackColor = true;
            this.StableOption.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // VariousOption
            // 
            this.VariousOption.AutoSize = true;
            this.VariousOption.Location = new System.Drawing.Point(6, 42);
            this.VariousOption.Name = "VariousOption";
            this.VariousOption.Size = new System.Drawing.Size(60, 17);
            this.VariousOption.TabIndex = 1;
            this.VariousOption.TabStop = true;
            this.VariousOption.Text = "Various";
            this.VariousOption.UseVisualStyleBackColor = true;
            this.VariousOption.CheckedChanged += new System.EventHandler(this.VariousOption_CheckedChanged);
            // 
            // PipeOption
            // 
            this.PipeOption.AutoSize = true;
            this.PipeOption.Location = new System.Drawing.Point(7, 65);
            this.PipeOption.Name = "PipeOption";
            this.PipeOption.Size = new System.Drawing.Size(46, 17);
            this.PipeOption.TabIndex = 2;
            this.PipeOption.TabStop = true;
            this.PipeOption.Text = "Pipe";
            this.PipeOption.UseVisualStyleBackColor = true;
            this.PipeOption.CheckedChanged += new System.EventHandler(this.PipeOption_CheckedChanged);
            // 
            // TextBoxA
            // 
            this.TextBoxA.Enabled = false;
            this.TextBoxA.Location = new System.Drawing.Point(47, 112);
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.Size = new System.Drawing.Size(157, 20);
            this.TextBoxA.TabIndex = 3;
            // 
            // TextBoxB
            // 
            this.TextBoxB.Enabled = false;
            this.TextBoxB.Location = new System.Drawing.Point(47, 139);
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(157, 20);
            this.TextBoxB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ax+b";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "a";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "b";
            // 
            // TextBoxC
            // 
            this.TextBoxC.Enabled = false;
            this.TextBoxC.Location = new System.Drawing.Point(12, 280);
            this.TextBoxC.Name = "TextBoxC";
            this.TextBoxC.Size = new System.Drawing.Size(188, 20);
            this.TextBoxC.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "%";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 465);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.DiscalibratedType);
            this.Controls.Add(this.DamageType);
            this.Controls.Add(this.LeakType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "MainForm";
            this.Text = "Anomaly Simulator 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader Start;
        private System.Windows.Forms.ColumnHeader End;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox LeakType;
        private System.Windows.Forms.CheckBox DamageType;
        private System.Windows.Forms.CheckBox DiscalibratedType;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton PipeOption;
        private System.Windows.Forms.RadioButton VariousOption;
        private System.Windows.Forms.RadioButton StableOption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxB;
        private System.Windows.Forms.TextBox TextBoxA;
        private System.Windows.Forms.TextBox TextBoxC;
        private System.Windows.Forms.Label label6;

    }
}

