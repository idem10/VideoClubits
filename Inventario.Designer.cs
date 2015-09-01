namespace VideoClub
{
    partial class Inventario
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gen = new System.Windows.Forms.ComboBox();
            this.lor = new System.Windows.Forms.ComboBox();
            this.ldis = new System.Windows.Forms.ComboBox();
            this.año = new System.Windows.Forms.ComboBox();
            this.disp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.act = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lista
            // 
            this.Lista.Location = new System.Drawing.Point(6, 60);
            this.Lista.Multiline = true;
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(302, 145);
            this.Lista.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gen);
            this.groupBox1.Controls.Add(this.lor);
            this.groupBox1.Controls.Add(this.ldis);
            this.groupBox1.Controls.Add(this.año);
            this.groupBox1.Controls.Add(this.disp);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dur);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.act);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 308);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar peliculas";
            // 
            // gen
            // 
            this.gen.FormattingEnabled = true;
            this.gen.Items.AddRange(new object[] {
            "Accion",
            "Terror",
            "Ciencia ficcion",
            "Animacion",
            "Comedia Romantica",
            "Documental"});
            this.gen.Location = new System.Drawing.Point(66, 226);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(236, 21);
            this.gen.TabIndex = 29;
            // 
            // lor
            // 
            this.lor.FormattingEnabled = true;
            this.lor.Items.AddRange(new object[] {
            "Ingles",
            "Español",
            "Aleman"});
            this.lor.Location = new System.Drawing.Point(66, 173);
            this.lor.Name = "lor";
            this.lor.Size = new System.Drawing.Size(236, 21);
            this.lor.TabIndex = 28;
            // 
            // ldis
            // 
            this.ldis.FormattingEnabled = true;
            this.ldis.Items.AddRange(new object[] {
            "Ingles",
            "Español",
            "Aleman"});
            this.ldis.Location = new System.Drawing.Point(66, 148);
            this.ldis.Name = "ldis";
            this.ldis.Size = new System.Drawing.Size(236, 21);
            this.ldis.TabIndex = 27;
            // 
            // año
            // 
            this.año.FormattingEnabled = true;
            this.año.Items.AddRange(new object[] {
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.año.Location = new System.Drawing.Point(65, 69);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(236, 21);
            this.año.TabIndex = 26;
            // 
            // disp
            // 
            this.disp.Location = new System.Drawing.Point(65, 252);
            this.disp.Name = "disp";
            this.disp.Size = new System.Drawing.Size(236, 20);
            this.disp.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Disponible";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Genero";
            // 
            // dur
            // 
            this.dur.Location = new System.Drawing.Point(65, 200);
            this.dur.Name = "dur";
            this.dur.Size = new System.Drawing.Size(236, 20);
            this.dur.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "duracion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Leng orig";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Leng disp";
            // 
            // dir
            // 
            this.dir.Location = new System.Drawing.Point(65, 122);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(236, 20);
            this.dir.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "directores";
            // 
            // act
            // 
            this.act.Location = new System.Drawing.Point(65, 96);
            this.act.Name = "act";
            this.act.Size = new System.Drawing.Size(236, 20);
            this.act.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "actores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Año";
            // 
            // tit
            // 
            this.tit.Location = new System.Drawing.Point(65, 44);
            this.tit.Name = "tit";
            this.tit.Size = new System.Drawing.Size(236, 20);
            this.tit.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "titulo";
            // 
            // cod
            // 
            this.cod.Location = new System.Drawing.Point(65, 18);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(236, 20);
            this.cod.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lista);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 220);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(336, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 82);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Baja";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Codigo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(233, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "Baja";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 355);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Lista;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox act;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox disp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox gen;
        private System.Windows.Forms.ComboBox lor;
        private System.Windows.Forms.ComboBox ldis;
        private System.Windows.Forms.ComboBox año;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
    }
}