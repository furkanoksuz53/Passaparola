namespace Passaparola
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            lblDogru = new Label();
            lblYanlis = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            lblSoru = new Label();
            button23 = new Button();
            button12 = new Button();
            button22 = new Button();
            button4 = new Button();
            button21 = new Button();
            button11 = new Button();
            button20 = new Button();
            button5 = new Button();
            button19 = new Button();
            button10 = new Button();
            button18 = new Button();
            button6 = new Button();
            button17 = new Button();
            button9 = new Button();
            button16 = new Button();
            button3 = new Button();
            button15 = new Button();
            button8 = new Button();
            button14 = new Button();
            button2 = new Button();
            button13 = new Button();
            button7 = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            lblKalanSure = new Label();
            linkLabel3 = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(332, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 98);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Soru";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(15, 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(405, 69);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(linkLabel3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(linkLabel2);
            groupBox2.Controls.Add(linkLabel1);
            groupBox2.Location = new Point(332, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(426, 98);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cevap";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 27);
            textBox1.TabIndex = 2;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(149, 73);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(62, 20);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Cevapla";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(90, 73);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(44, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Başla";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 247);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 9;
            label1.Text = "Doğru :";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(395, 247);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(17, 20);
            lblDogru.TabIndex = 10;
            lblDogru.Text = "0";
            // 
            // lblYanlis
            // 
            lblYanlis.AutoSize = true;
            lblYanlis.Location = new Point(528, 247);
            lblYanlis.Name = "lblYanlis";
            lblYanlis.Size = new Size(17, 20);
            lblYanlis.TabIndex = 12;
            lblYanlis.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 247);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 11;
            label4.Text = "Yanlış :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblSoru);
            groupBox3.Controls.Add(button23);
            groupBox3.Controls.Add(button12);
            groupBox3.Controls.Add(button22);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button21);
            groupBox3.Controls.Add(button11);
            groupBox3.Controls.Add(button20);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button19);
            groupBox3.Controls.Add(button10);
            groupBox3.Controls.Add(button18);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(button17);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(button16);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button15);
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(button14);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button13);
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(8, 9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(318, 240);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            lblSoru.Location = new Point(111, 78);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(0, 89);
            lblSoru.TabIndex = 30;
            // 
            // button23
            // 
            button23.Location = new Point(10, 200);
            button23.Name = "button23";
            button23.Size = new Size(37, 29);
            button23.TabIndex = 29;
            button23.Text = "S";
            button23.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(268, 200);
            button12.Name = "button12";
            button12.Size = new Size(37, 29);
            button12.TabIndex = 28;
            button12.Text = "L";
            button12.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Location = new Point(10, 26);
            button22.Name = "button22";
            button22.Size = new Size(37, 29);
            button22.TabIndex = 26;
            button22.Text = "Z";
            button22.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(230, 26);
            button4.Name = "button4";
            button4.Size = new Size(37, 29);
            button4.TabIndex = 27;
            button4.Text = "F";
            button4.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Location = new Point(53, 200);
            button21.Name = "button21";
            button21.Size = new Size(37, 29);
            button21.TabIndex = 25;
            button21.Text = "R";
            button21.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(268, 165);
            button11.Name = "button11";
            button11.Size = new Size(37, 29);
            button11.TabIndex = 24;
            button11.Text = "K";
            button11.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Location = new Point(10, 60);
            button20.Name = "button20";
            button20.Size = new Size(37, 29);
            button20.TabIndex = 21;
            button20.Text = "Y";
            button20.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(193, 26);
            button5.Name = "button5";
            button5.Size = new Size(37, 29);
            button5.TabIndex = 23;
            button5.Text = "E";
            button5.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Location = new Point(96, 200);
            button19.Name = "button19";
            button19.Size = new Size(37, 29);
            button19.TabIndex = 20;
            button19.Text = "P";
            button19.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(268, 130);
            button10.Name = "button10";
            button10.Size = new Size(37, 29);
            button10.TabIndex = 22;
            button10.Text = "J";
            button10.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(10, 95);
            button18.Name = "button18";
            button18.Size = new Size(37, 29);
            button18.TabIndex = 18;
            button18.Text = "V";
            button18.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(155, 26);
            button6.Name = "button6";
            button6.Size = new Size(37, 29);
            button6.TabIndex = 19;
            button6.Text = "D";
            button6.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(139, 200);
            button17.Name = "button17";
            button17.Size = new Size(37, 29);
            button17.TabIndex = 17;
            button17.Text = "O";
            button17.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(268, 95);
            button9.Name = "button9";
            button9.Size = new Size(37, 29);
            button9.TabIndex = 16;
            button9.Text = "I";
            button9.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(10, 130);
            button16.Name = "button16";
            button16.Size = new Size(37, 29);
            button16.TabIndex = 14;
            button16.Text = "U";
            button16.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(119, 26);
            button3.Name = "button3";
            button3.Size = new Size(37, 29);
            button3.TabIndex = 15;
            button3.Text = "C";
            button3.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(182, 200);
            button15.Name = "button15";
            button15.Size = new Size(37, 29);
            button15.TabIndex = 13;
            button15.Text = "N";
            button15.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(268, 60);
            button8.Name = "button8";
            button8.Size = new Size(37, 29);
            button8.TabIndex = 12;
            button8.Text = "H";
            button8.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(10, 165);
            button14.Name = "button14";
            button14.Size = new Size(37, 29);
            button14.TabIndex = 9;
            button14.Text = "T";
            button14.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(83, 26);
            button2.Name = "button2";
            button2.Size = new Size(37, 29);
            button2.TabIndex = 11;
            button2.Text = "B";
            button2.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(225, 200);
            button13.Name = "button13";
            button13.Size = new Size(37, 29);
            button13.TabIndex = 8;
            button13.Text = "M";
            button13.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(268, 26);
            button7.Name = "button7";
            button7.Size = new Size(37, 29);
            button7.TabIndex = 10;
            button7.Text = "G";
            button7.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(47, 26);
            button1.Name = "button1";
            button1.Size = new Size(37, 29);
            button1.TabIndex = 7;
            button1.Text = "A";
            button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(616, 247);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 14;
            label2.Text = "Kalan Süre :";
            // 
            // lblKalanSure
            // 
            lblKalanSure.AutoSize = true;
            lblKalanSure.Location = new Point(708, 247);
            lblKalanSure.Name = "lblKalanSure";
            lblKalanSure.Size = new Size(0, 20);
            lblKalanSure.TabIndex = 14;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(217, 73);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(36, 20);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Bitir";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 285);
            Controls.Add(lblKalanSure);
            Controls.Add(label2);
            Controls.Add(groupBox3);
            Controls.Add(lblYanlis);
            Controls.Add(label4);
            Controls.Add(lblDogru);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox2;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label lblDogru;
        private Label lblYanlis;
        private Label label4;
        private GroupBox groupBox3;
        private Button button23;
        private Button button12;
        private Button button22;
        private Button button4;
        private Button button21;
        private Button button11;
        private Button button20;
        private Button button5;
        private Button button19;
        private Button button10;
        private Button button18;
        private Button button6;
        private Button button17;
        private Button button9;
        private Button button16;
        private Button button3;
        private Button button15;
        private Button button8;
        private Button button14;
        private Button button2;
        private Button button13;
        private Button button7;
        private Button button1;
        private Label lblSoru;
        private LinkLabel linkLabel2;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Label label2;
        private Label lblKalanSure;
        private LinkLabel linkLabel3;
    }
}