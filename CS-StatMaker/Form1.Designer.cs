namespace CS_StatMaker
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
            this.StartButton = new System.Windows.Forms.Button();
            this.DieBox1 = new System.Windows.Forms.TextBox();
            this.DieBox6 = new System.Windows.Forms.TextBox();
            this.DieBox5 = new System.Windows.Forms.TextBox();
            this.DieBox4 = new System.Windows.Forms.TextBox();
            this.DieBox3 = new System.Windows.Forms.TextBox();
            this.DieBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DexBox = new System.Windows.Forms.TextBox();
            this.ConBox = new System.Windows.Forms.TextBox();
            this.IntBox = new System.Windows.Forms.TextBox();
            this.ChaBox = new System.Windows.Forms.TextBox();
            this.WisBox = new System.Windows.Forms.TextBox();
            this.StrBox = new System.Windows.Forms.TextBox();
            this.RaceDropbox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.ChaTotal = new System.Windows.Forms.Label();
            this.WisTotal = new System.Windows.Forms.Label();
            this.IntTotal = new System.Windows.Forms.Label();
            this.ConTotal = new System.Windows.Forms.Label();
            this.DexTotal = new System.Windows.Forms.Label();
            this.StrTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ChaBonus = new System.Windows.Forms.Label();
            this.WisBonus = new System.Windows.Forms.Label();
            this.IntBonus = new System.Windows.Forms.Label();
            this.ConBonus = new System.Windows.Forms.Label();
            this.DexBonus = new System.Windows.Forms.Label();
            this.StrBonus = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ChaMod = new System.Windows.Forms.Label();
            this.WisMod = new System.Windows.Forms.Label();
            this.StrMod = new System.Windows.Forms.Label();
            this.IntMod = new System.Windows.Forms.Label();
            this.DexMod = new System.Windows.Forms.Label();
            this.ConMod = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(6, 6);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 42);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Roll";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DieBox1
            // 
            this.DieBox1.AllowDrop = true;
            this.DieBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DieBox1.Location = new System.Drawing.Point(108, 14);
            this.DieBox1.Multiline = true;
            this.DieBox1.Name = "DieBox1";
            this.DieBox1.ReadOnly = true;
            this.DieBox1.Size = new System.Drawing.Size(30, 30);
            this.DieBox1.TabIndex = 1;
            this.DieBox1.Text = "0";
            this.DieBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DieBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Die_DragDrop);
            this.DieBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Die_DragEnter);
            this.DieBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Die_MouseDown);
            // 
            // DieBox6
            // 
            this.DieBox6.AllowDrop = true;
            this.DieBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DieBox6.Location = new System.Drawing.Point(285, 14);
            this.DieBox6.Multiline = true;
            this.DieBox6.Name = "DieBox6";
            this.DieBox6.ReadOnly = true;
            this.DieBox6.Size = new System.Drawing.Size(30, 30);
            this.DieBox6.TabIndex = 2;
            this.DieBox6.Text = "0";
            this.DieBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DieBox5
            // 
            this.DieBox5.AllowDrop = true;
            this.DieBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DieBox5.Location = new System.Drawing.Point(249, 14);
            this.DieBox5.Multiline = true;
            this.DieBox5.Name = "DieBox5";
            this.DieBox5.ReadOnly = true;
            this.DieBox5.Size = new System.Drawing.Size(30, 30);
            this.DieBox5.TabIndex = 3;
            this.DieBox5.Text = "0";
            this.DieBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DieBox4
            // 
            this.DieBox4.AllowDrop = true;
            this.DieBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DieBox4.Location = new System.Drawing.Point(216, 14);
            this.DieBox4.Multiline = true;
            this.DieBox4.Name = "DieBox4";
            this.DieBox4.ReadOnly = true;
            this.DieBox4.Size = new System.Drawing.Size(30, 30);
            this.DieBox4.TabIndex = 4;
            this.DieBox4.Text = "0";
            this.DieBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DieBox3
            // 
            this.DieBox3.AllowDrop = true;
            this.DieBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DieBox3.Location = new System.Drawing.Point(180, 14);
            this.DieBox3.Multiline = true;
            this.DieBox3.Name = "DieBox3";
            this.DieBox3.ReadOnly = true;
            this.DieBox3.Size = new System.Drawing.Size(30, 30);
            this.DieBox3.TabIndex = 5;
            this.DieBox3.Text = "0";
            this.DieBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DieBox2
            // 
            this.DieBox2.AllowDrop = true;
            this.DieBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DieBox2.Location = new System.Drawing.Point(144, 14);
            this.DieBox2.Multiline = true;
            this.DieBox2.Name = "DieBox2";
            this.DieBox2.ReadOnly = true;
            this.DieBox2.Size = new System.Drawing.Size(30, 30);
            this.DieBox2.TabIndex = 6;
            this.DieBox2.Text = "0";
            this.DieBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "STR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "CHA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "WIS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "INT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "CON:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "DEX:";
            // 
            // DexBox
            // 
            this.DexBox.AllowDrop = true;
            this.DexBox.BackColor = System.Drawing.SystemColors.Control;
            this.DexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexBox.Location = new System.Drawing.Point(61, 129);
            this.DexBox.Multiline = true;
            this.DexBox.Name = "DexBox";
            this.DexBox.ReadOnly = true;
            this.DexBox.Size = new System.Drawing.Size(30, 30);
            this.DexBox.TabIndex = 18;
            this.DexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConBox
            // 
            this.ConBox.AllowDrop = true;
            this.ConBox.BackColor = System.Drawing.SystemColors.Control;
            this.ConBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConBox.Location = new System.Drawing.Point(61, 165);
            this.ConBox.Multiline = true;
            this.ConBox.Name = "ConBox";
            this.ConBox.ReadOnly = true;
            this.ConBox.Size = new System.Drawing.Size(30, 30);
            this.ConBox.TabIndex = 17;
            this.ConBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IntBox
            // 
            this.IntBox.AllowDrop = true;
            this.IntBox.BackColor = System.Drawing.SystemColors.Control;
            this.IntBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntBox.Location = new System.Drawing.Point(61, 201);
            this.IntBox.Multiline = true;
            this.IntBox.Name = "IntBox";
            this.IntBox.ReadOnly = true;
            this.IntBox.Size = new System.Drawing.Size(30, 30);
            this.IntBox.TabIndex = 16;
            this.IntBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChaBox
            // 
            this.ChaBox.AllowDrop = true;
            this.ChaBox.BackColor = System.Drawing.SystemColors.Control;
            this.ChaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChaBox.Location = new System.Drawing.Point(61, 273);
            this.ChaBox.Multiline = true;
            this.ChaBox.Name = "ChaBox";
            this.ChaBox.ReadOnly = true;
            this.ChaBox.Size = new System.Drawing.Size(30, 30);
            this.ChaBox.TabIndex = 15;
            this.ChaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WisBox
            // 
            this.WisBox.AllowDrop = true;
            this.WisBox.BackColor = System.Drawing.SystemColors.Control;
            this.WisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisBox.Location = new System.Drawing.Point(61, 237);
            this.WisBox.Multiline = true;
            this.WisBox.Name = "WisBox";
            this.WisBox.ReadOnly = true;
            this.WisBox.Size = new System.Drawing.Size(30, 30);
            this.WisBox.TabIndex = 14;
            this.WisBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StrBox
            // 
            this.StrBox.AllowDrop = true;
            this.StrBox.BackColor = System.Drawing.SystemColors.Control;
            this.StrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrBox.Location = new System.Drawing.Point(61, 93);
            this.StrBox.Multiline = true;
            this.StrBox.Name = "StrBox";
            this.StrBox.ReadOnly = true;
            this.StrBox.Size = new System.Drawing.Size(30, 30);
            this.StrBox.TabIndex = 13;
            this.StrBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RaceDropbox
            // 
            this.RaceDropbox.FormattingEnabled = true;
            this.RaceDropbox.Location = new System.Drawing.Point(65, 5);
            this.RaceDropbox.Name = "RaceDropbox";
            this.RaceDropbox.Size = new System.Drawing.Size(121, 21);
            this.RaceDropbox.TabIndex = 25;
            this.RaceDropbox.SelectedIndexChanged += new System.EventHandler(this.RaceDropbox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Race:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 446);
            this.tabControl1.TabIndex = 42;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.StartButton);
            this.tabPage1.Controls.Add(this.DieBox1);
            this.tabPage1.Controls.Add(this.DieBox6);
            this.tabPage1.Controls.Add(this.DieBox5);
            this.tabPage1.Controls.Add(this.DieBox4);
            this.tabPage1.Controls.Add(this.DieBox3);
            this.tabPage1.Controls.Add(this.DieBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.StrBox);
            this.tabPage1.Controls.Add(this.WisBox);
            this.tabPage1.Controls.Add(this.ChaBox);
            this.tabPage1.Controls.Add(this.IntBox);
            this.tabPage1.Controls.Add(this.ConBox);
            this.tabPage1.Controls.Add(this.DexBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Base Stats";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.ChaMod);
            this.tabPage2.Controls.Add(this.WisMod);
            this.tabPage2.Controls.Add(this.StrMod);
            this.tabPage2.Controls.Add(this.IntMod);
            this.tabPage2.Controls.Add(this.DexMod);
            this.tabPage2.Controls.Add(this.ConMod);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.ChaTotal);
            this.tabPage2.Controls.Add(this.WisTotal);
            this.tabPage2.Controls.Add(this.IntTotal);
            this.tabPage2.Controls.Add(this.ConTotal);
            this.tabPage2.Controls.Add(this.DexTotal);
            this.tabPage2.Controls.Add(this.StrTotal);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.ChaBonus);
            this.tabPage2.Controls.Add(this.WisBonus);
            this.tabPage2.Controls.Add(this.IntBonus);
            this.tabPage2.Controls.Add(this.ConBonus);
            this.tabPage2.Controls.Add(this.DexBonus);
            this.tabPage2.Controls.Add(this.StrBonus);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.RaceDropbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Race";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(101, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Total:";
            // 
            // ChaTotal
            // 
            this.ChaTotal.AutoSize = true;
            this.ChaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChaTotal.Location = new System.Drawing.Point(117, 235);
            this.ChaTotal.Name = "ChaTotal";
            this.ChaTotal.Size = new System.Drawing.Size(18, 20);
            this.ChaTotal.TabIndex = 54;
            this.ChaTotal.Text = "0";
            // 
            // WisTotal
            // 
            this.WisTotal.AutoSize = true;
            this.WisTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisTotal.Location = new System.Drawing.Point(117, 199);
            this.WisTotal.Name = "WisTotal";
            this.WisTotal.Size = new System.Drawing.Size(18, 20);
            this.WisTotal.TabIndex = 53;
            this.WisTotal.Text = "0";
            // 
            // IntTotal
            // 
            this.IntTotal.AutoSize = true;
            this.IntTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntTotal.Location = new System.Drawing.Point(117, 163);
            this.IntTotal.Name = "IntTotal";
            this.IntTotal.Size = new System.Drawing.Size(18, 20);
            this.IntTotal.TabIndex = 52;
            this.IntTotal.Text = "0";
            // 
            // ConTotal
            // 
            this.ConTotal.AutoSize = true;
            this.ConTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConTotal.Location = new System.Drawing.Point(117, 127);
            this.ConTotal.Name = "ConTotal";
            this.ConTotal.Size = new System.Drawing.Size(18, 20);
            this.ConTotal.TabIndex = 51;
            this.ConTotal.Text = "0";
            // 
            // DexTotal
            // 
            this.DexTotal.AutoSize = true;
            this.DexTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexTotal.Location = new System.Drawing.Point(117, 91);
            this.DexTotal.Name = "DexTotal";
            this.DexTotal.Size = new System.Drawing.Size(18, 20);
            this.DexTotal.TabIndex = 50;
            this.DexTotal.Text = "0";
            // 
            // StrTotal
            // 
            this.StrTotal.AutoSize = true;
            this.StrTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrTotal.Location = new System.Drawing.Point(117, 55);
            this.StrTotal.Name = "StrTotal";
            this.StrTotal.Size = new System.Drawing.Size(18, 20);
            this.StrTotal.TabIndex = 49;
            this.StrTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Bonus:";
            // 
            // ChaBonus
            // 
            this.ChaBonus.AutoSize = true;
            this.ChaBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChaBonus.Location = new System.Drawing.Point(61, 235);
            this.ChaBonus.Name = "ChaBonus";
            this.ChaBonus.Size = new System.Drawing.Size(18, 20);
            this.ChaBonus.TabIndex = 47;
            this.ChaBonus.Text = "0";
            // 
            // WisBonus
            // 
            this.WisBonus.AutoSize = true;
            this.WisBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisBonus.Location = new System.Drawing.Point(61, 199);
            this.WisBonus.Name = "WisBonus";
            this.WisBonus.Size = new System.Drawing.Size(18, 20);
            this.WisBonus.TabIndex = 46;
            this.WisBonus.Text = "0";
            // 
            // IntBonus
            // 
            this.IntBonus.AutoSize = true;
            this.IntBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntBonus.Location = new System.Drawing.Point(61, 163);
            this.IntBonus.Name = "IntBonus";
            this.IntBonus.Size = new System.Drawing.Size(18, 20);
            this.IntBonus.TabIndex = 45;
            this.IntBonus.Text = "0";
            // 
            // ConBonus
            // 
            this.ConBonus.AutoSize = true;
            this.ConBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConBonus.Location = new System.Drawing.Point(61, 127);
            this.ConBonus.Name = "ConBonus";
            this.ConBonus.Size = new System.Drawing.Size(18, 20);
            this.ConBonus.TabIndex = 44;
            this.ConBonus.Text = "0";
            // 
            // DexBonus
            // 
            this.DexBonus.AutoSize = true;
            this.DexBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexBonus.Location = new System.Drawing.Point(61, 91);
            this.DexBonus.Name = "DexBonus";
            this.DexBonus.Size = new System.Drawing.Size(18, 20);
            this.DexBonus.TabIndex = 43;
            this.DexBonus.Text = "0";
            // 
            // StrBonus
            // 
            this.StrBonus.AutoSize = true;
            this.StrBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrBonus.Location = new System.Drawing.Point(61, 55);
            this.StrBonus.Name = "StrBonus";
            this.StrBonus.Size = new System.Drawing.Size(18, 20);
            this.StrBonus.TabIndex = 42;
            this.StrBonus.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 56;
            this.label11.Text = "STR:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 57;
            this.label12.Text = "CHA:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 58;
            this.label13.Text = "WIS:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 20);
            this.label14.TabIndex = 59;
            this.label14.Text = "INT:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 60;
            this.label15.Text = "CON:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 20);
            this.label16.TabIndex = 61;
            this.label16.Text = "DEX:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(157, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 68;
            this.label8.Text = "Mod:";
            // 
            // ChaMod
            // 
            this.ChaMod.AutoSize = true;
            this.ChaMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChaMod.Location = new System.Drawing.Point(169, 235);
            this.ChaMod.Name = "ChaMod";
            this.ChaMod.Size = new System.Drawing.Size(18, 20);
            this.ChaMod.TabIndex = 67;
            this.ChaMod.Text = "0";
            // 
            // WisMod
            // 
            this.WisMod.AutoSize = true;
            this.WisMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisMod.Location = new System.Drawing.Point(169, 199);
            this.WisMod.Name = "WisMod";
            this.WisMod.Size = new System.Drawing.Size(18, 20);
            this.WisMod.TabIndex = 66;
            this.WisMod.Text = "0";
            // 
            // StrMod
            // 
            this.StrMod.AutoSize = true;
            this.StrMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrMod.Location = new System.Drawing.Point(169, 55);
            this.StrMod.Name = "StrMod";
            this.StrMod.Size = new System.Drawing.Size(18, 20);
            this.StrMod.TabIndex = 62;
            this.StrMod.Text = "0";
            // 
            // IntMod
            // 
            this.IntMod.AutoSize = true;
            this.IntMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntMod.Location = new System.Drawing.Point(169, 163);
            this.IntMod.Name = "IntMod";
            this.IntMod.Size = new System.Drawing.Size(18, 20);
            this.IntMod.TabIndex = 65;
            this.IntMod.Text = "0";
            // 
            // DexMod
            // 
            this.DexMod.AutoSize = true;
            this.DexMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexMod.Location = new System.Drawing.Point(169, 91);
            this.DexMod.Name = "DexMod";
            this.DexMod.Size = new System.Drawing.Size(18, 20);
            this.DexMod.TabIndex = 63;
            this.DexMod.Text = "0";
            // 
            // ConMod
            // 
            this.ConMod.AutoSize = true;
            this.ConMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConMod.Location = new System.Drawing.Point(169, 127);
            this.ConMod.Name = "ConMod";
            this.ConMod.Size = new System.Drawing.Size(18, 20);
            this.ConMod.TabIndex = 64;
            this.ConMod.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 470);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox DieBox1;
        private System.Windows.Forms.TextBox DieBox6;
        private System.Windows.Forms.TextBox DieBox5;
        private System.Windows.Forms.TextBox DieBox4;
        private System.Windows.Forms.TextBox DieBox3;
        private System.Windows.Forms.TextBox DieBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DexBox;
        private System.Windows.Forms.TextBox ConBox;
        private System.Windows.Forms.TextBox IntBox;
        private System.Windows.Forms.TextBox ChaBox;
        private System.Windows.Forms.TextBox WisBox;
        private System.Windows.Forms.TextBox StrBox;
        private System.Windows.Forms.ComboBox RaceDropbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ChaTotal;
        private System.Windows.Forms.Label WisTotal;
        private System.Windows.Forms.Label IntTotal;
        private System.Windows.Forms.Label ConTotal;
        private System.Windows.Forms.Label DexTotal;
        private System.Windows.Forms.Label StrTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ChaBonus;
        private System.Windows.Forms.Label WisBonus;
        private System.Windows.Forms.Label IntBonus;
        private System.Windows.Forms.Label ConBonus;
        private System.Windows.Forms.Label DexBonus;
        private System.Windows.Forms.Label StrBonus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ChaMod;
        private System.Windows.Forms.Label WisMod;
        private System.Windows.Forms.Label StrMod;
        private System.Windows.Forms.Label IntMod;
        private System.Windows.Forms.Label DexMod;
        private System.Windows.Forms.Label ConMod;
    }
}

