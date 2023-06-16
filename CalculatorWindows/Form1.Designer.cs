namespace CalculatorWindows
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlHostory = new System.Windows.Forms.Panel();
            this.RtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.BtnClearHistory = new System.Windows.Forms.Button();
            this.btnPM = new ArtanButton.ArtanButton();
            this.btn0 = new ArtanButton.ArtanButton();
            this.btnDeals = new ArtanButton.ArtanButton();
            this.BtnEquals = new ArtanButton.ArtanButton();
            this.btn1 = new ArtanButton.ArtanButton();
            this.btn2 = new ArtanButton.ArtanButton();
            this.btn3 = new ArtanButton.ArtanButton();
            this.BtnAdd = new ArtanButton.ArtanButton();
            this.btn4 = new ArtanButton.ArtanButton();
            this.btn5 = new ArtanButton.ArtanButton();
            this.btn6 = new ArtanButton.ArtanButton();
            this.BtnSubstraction = new ArtanButton.ArtanButton();
            this.btn7 = new ArtanButton.ArtanButton();
            this.btn8 = new ArtanButton.ArtanButton();
            this.btn9 = new ArtanButton.ArtanButton();
            this.BtnMultiply = new ArtanButton.ArtanButton();
            this.Btn1x = new ArtanButton.ArtanButton();
            this.Btnx2 = new ArtanButton.ArtanButton();
            this.BtnSquare = new ArtanButton.ArtanButton();
            this.BtnDevision = new ArtanButton.ArtanButton();
            this.BtnPercent = new ArtanButton.ArtanButton();
            this.btnCE = new ArtanButton.ArtanButton();
            this.BtnC = new ArtanButton.ArtanButton();
            this.BtnBackSpace = new ArtanButton.ArtanButton();
            this.artanButton6 = new ArtanButton.ArtanButton();
            this.artanButton5 = new ArtanButton.ArtanButton();
            this.artanButton4 = new ArtanButton.ArtanButton();
            this.artanButton3 = new ArtanButton.ArtanButton();
            this.artanButton2 = new ArtanButton.ArtanButton();
            this.artanButton1 = new ArtanButton.ArtanButton();
            this.panel1.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.PnlHostory.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay1.Font = new System.Drawing.Font("Gadugi", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay1.ForeColor = System.Drawing.Color.White;
            this.TxtDisplay1.Location = new System.Drawing.Point(0, 110);
            this.TxtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.Size = new System.Drawing.Size(350, 94);
            this.TxtDisplay1.TabIndex = 8;
            this.TxtDisplay1.Text = "0";
            this.TxtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay2.Font = new System.Drawing.Font("Gadugi", 14F);
            this.TxtDisplay2.ForeColor = System.Drawing.Color.Silver;
            this.TxtDisplay2.Location = new System.Drawing.Point(0, 80);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(350, 30);
            this.TxtDisplay2.TabIndex = 7;
            this.TxtDisplay2.Text = "0";
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnMenu);
            this.panel1.Controls.Add(this.BtnHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 6;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(50, 40);
            this.BtnMenu.TabIndex = 2;
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHistory.FlatAppearance.BorderSize = 0;
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnHistory.Image")));
            this.BtnHistory.Location = new System.Drawing.Point(300, 0);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(50, 40);
            this.BtnHistory.TabIndex = 0;
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_click);
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.button2);
            this.PnlTitle.Controls.Add(this.button1);
            this.PnlTitle.Controls.Add(this.BtnExit);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(350, 40);
            this.PnlTitle.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(200, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 40);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(250, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(300, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(50, 40);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PnlHostory
            // 
            this.PnlHostory.Controls.Add(this.RtBoxDisplayHistory);
            this.PnlHostory.Controls.Add(this.BtnClearHistory);
            this.PnlHostory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHostory.ForeColor = System.Drawing.Color.White;
            this.PnlHostory.Location = new System.Drawing.Point(0, 565);
            this.PnlHostory.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHostory.Name = "PnlHostory";
            this.PnlHostory.Size = new System.Drawing.Size(350, 5);
            this.PnlHostory.TabIndex = 19;
            // 
            // RtBoxDisplayHistory
            // 
            this.RtBoxDisplayHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.RtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtBoxDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtBoxDisplayHistory.ForeColor = System.Drawing.SystemColors.Window;
            this.RtBoxDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.RtBoxDisplayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            this.RtBoxDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.RtBoxDisplayHistory.Size = new System.Drawing.Size(350, 0);
            this.RtBoxDisplayHistory.TabIndex = 4;
            this.RtBoxDisplayHistory.Text = "";
            // 
            // BtnClearHistory
            // 
            this.BtnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClearHistory.FlatAppearance.BorderSize = 0;
            this.BtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnClearHistory.Image")));
            this.BtnClearHistory.Location = new System.Drawing.Point(0, -35);
            this.BtnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearHistory.Name = "BtnClearHistory";
            this.BtnClearHistory.Size = new System.Drawing.Size(350, 40);
            this.BtnClearHistory.TabIndex = 3;
            this.BtnClearHistory.UseVisualStyleBackColor = true;
            this.BtnClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPM.BorderRadius = 20;
            this.btnPM.BorderSize = 20;
            this.btnPM.FlatAppearance.BorderSize = 0;
            this.btnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPM.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPM.ForeColor = System.Drawing.Color.White;
            this.btnPM.Location = new System.Drawing.Point(0, 498);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(85, 50);
            this.btnPM.TabIndex = 39;
            this.btnPM.Text = "±";
            this.btnPM.TextColor = System.Drawing.Color.White;
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn0.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn0.BorderRadius = 20;
            this.btn0.BorderSize = 20;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(88, 498);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(85, 50);
            this.btn0.TabIndex = 38;
            this.btn0.Text = "0";
            this.btn0.TextColor = System.Drawing.Color.White;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btnDeals
            // 
            this.btnDeals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeals.BorderRadius = 20;
            this.btnDeals.BorderSize = 20;
            this.btnDeals.FlatAppearance.BorderSize = 0;
            this.btnDeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeals.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeals.Location = new System.Drawing.Point(176, 498);
            this.btnDeals.Name = "btnDeals";
            this.btnDeals.Size = new System.Drawing.Size(85, 50);
            this.btnDeals.TabIndex = 37;
            this.btnDeals.Text = ".";
            this.btnDeals.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeals.UseVisualStyleBackColor = false;
            this.btnDeals.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEquals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEquals.BorderRadius = 20;
            this.BtnEquals.BorderSize = 20;
            this.BtnEquals.FlatAppearance.BorderSize = 0;
            this.BtnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquals.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnEquals.ForeColor = System.Drawing.Color.White;
            this.BtnEquals.Location = new System.Drawing.Point(264, 498);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(85, 50);
            this.BtnEquals.TabIndex = 36;
            this.BtnEquals.Text = "=";
            this.BtnEquals.TextColor = System.Drawing.Color.White;
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn1.BorderRadius = 20;
            this.btn1.BorderSize = 20;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(-1, 445);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(85, 50);
            this.btn1.TabIndex = 35;
            this.btn1.Text = "1";
            this.btn1.TextColor = System.Drawing.Color.White;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn2.BorderRadius = 20;
            this.btn2.BorderSize = 20;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(87, 445);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(85, 50);
            this.btn2.TabIndex = 34;
            this.btn2.Text = "2";
            this.btn2.TextColor = System.Drawing.Color.White;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn3.BorderRadius = 20;
            this.btn3.BorderSize = 20;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(175, 445);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(85, 50);
            this.btn3.TabIndex = 33;
            this.btn3.Text = "3";
            this.btn3.TextColor = System.Drawing.Color.White;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAdd.BorderRadius = 20;
            this.BtnAdd.BorderSize = 20;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(263, 445);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(85, 50);
            this.BtnAdd.TabIndex = 32;
            this.BtnAdd.Text = "+";
            this.BtnAdd.TextColor = System.Drawing.Color.White;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnMathOperations);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn4.BorderRadius = 20;
            this.btn4.BorderSize = 20;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(-1, 392);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(85, 50);
            this.btn4.TabIndex = 31;
            this.btn4.Text = "4";
            this.btn4.TextColor = System.Drawing.Color.White;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn5.BorderRadius = 20;
            this.btn5.BorderSize = 20;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(87, 392);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(85, 50);
            this.btn5.TabIndex = 30;
            this.btn5.Text = "5";
            this.btn5.TextColor = System.Drawing.Color.White;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn6.BorderRadius = 20;
            this.btn6.BorderSize = 20;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(175, 392);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(85, 50);
            this.btn6.TabIndex = 29;
            this.btn6.Text = "6";
            this.btn6.TextColor = System.Drawing.Color.White;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnSubstraction
            // 
            this.BtnSubstraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSubstraction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSubstraction.BorderRadius = 20;
            this.BtnSubstraction.BorderSize = 20;
            this.BtnSubstraction.FlatAppearance.BorderSize = 0;
            this.BtnSubstraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubstraction.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnSubstraction.ForeColor = System.Drawing.Color.White;
            this.BtnSubstraction.Location = new System.Drawing.Point(263, 392);
            this.BtnSubstraction.Name = "BtnSubstraction";
            this.BtnSubstraction.Size = new System.Drawing.Size(85, 50);
            this.BtnSubstraction.TabIndex = 28;
            this.BtnSubstraction.Text = "-";
            this.BtnSubstraction.TextColor = System.Drawing.Color.White;
            this.BtnSubstraction.UseVisualStyleBackColor = false;
            this.BtnSubstraction.Click += new System.EventHandler(this.BtnMathOperations);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn7.BorderRadius = 20;
            this.btn7.BorderSize = 20;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(-1, 339);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(85, 50);
            this.btn7.TabIndex = 27;
            this.btn7.Text = "7";
            this.btn7.TextColor = System.Drawing.Color.White;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn8.BorderRadius = 20;
            this.btn8.BorderSize = 20;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(87, 339);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(85, 50);
            this.btn8.TabIndex = 26;
            this.btn8.Text = "8";
            this.btn8.TextColor = System.Drawing.Color.White;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn9.BorderRadius = 20;
            this.btn9.BorderSize = 20;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(175, 339);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(85, 50);
            this.btn9.TabIndex = 25;
            this.btn9.Text = "9";
            this.btn9.TextColor = System.Drawing.Color.White;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnMultiply.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnMultiply.BorderRadius = 20;
            this.BtnMultiply.BorderSize = 20;
            this.BtnMultiply.FlatAppearance.BorderSize = 0;
            this.BtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiply.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnMultiply.ForeColor = System.Drawing.Color.White;
            this.BtnMultiply.Location = new System.Drawing.Point(263, 339);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(85, 50);
            this.BtnMultiply.TabIndex = 24;
            this.BtnMultiply.Text = "×";
            this.BtnMultiply.TextColor = System.Drawing.Color.White;
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMathOperations);
            // 
            // Btn1x
            // 
            this.Btn1x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn1x.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btn1x.BorderRadius = 20;
            this.Btn1x.BorderSize = 20;
            this.Btn1x.FlatAppearance.BorderSize = 0;
            this.Btn1x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1x.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn1x.Location = new System.Drawing.Point(-1, 286);
            this.Btn1x.Name = "Btn1x";
            this.Btn1x.Size = new System.Drawing.Size(85, 50);
            this.Btn1x.TabIndex = 23;
            this.Btn1x.Text = "¹/x";
            this.Btn1x.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btn1x.UseVisualStyleBackColor = false;
            this.Btn1x.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // Btnx2
            // 
            this.Btnx2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btnx2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Btnx2.BorderRadius = 20;
            this.Btnx2.BorderSize = 20;
            this.Btnx2.FlatAppearance.BorderSize = 0;
            this.Btnx2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnx2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btnx2.Location = new System.Drawing.Point(87, 286);
            this.Btnx2.Name = "Btnx2";
            this.Btnx2.Size = new System.Drawing.Size(85, 50);
            this.Btnx2.TabIndex = 22;
            this.Btnx2.Text = "^2";
            this.Btnx2.TextColor = System.Drawing.Color.WhiteSmoke;
            this.Btnx2.UseVisualStyleBackColor = false;
            this.Btnx2.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSquare.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSquare.BorderRadius = 20;
            this.BtnSquare.BorderSize = 20;
            this.BtnSquare.FlatAppearance.BorderSize = 0;
            this.BtnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSquare.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnSquare.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSquare.Location = new System.Drawing.Point(175, 286);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(85, 50);
            this.BtnSquare.TabIndex = 21;
            this.BtnSquare.Text = "√";
            this.BtnSquare.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSquare.UseVisualStyleBackColor = false;
            this.BtnSquare.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // BtnDevision
            // 
            this.BtnDevision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnDevision.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnDevision.BorderRadius = 20;
            this.BtnDevision.BorderSize = 20;
            this.BtnDevision.FlatAppearance.BorderSize = 0;
            this.BtnDevision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDevision.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnDevision.ForeColor = System.Drawing.Color.White;
            this.BtnDevision.Location = new System.Drawing.Point(263, 286);
            this.BtnDevision.Name = "BtnDevision";
            this.BtnDevision.Size = new System.Drawing.Size(85, 50);
            this.BtnDevision.TabIndex = 20;
            this.BtnDevision.Text = "÷";
            this.BtnDevision.TextColor = System.Drawing.Color.White;
            this.BtnDevision.UseVisualStyleBackColor = false;
            this.BtnDevision.Click += new System.EventHandler(this.BtnMathOperations);
            // 
            // BtnPercent
            // 
            this.BtnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPercent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPercent.BorderRadius = 20;
            this.BtnPercent.BorderSize = 20;
            this.BtnPercent.FlatAppearance.BorderSize = 0;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPercent.Location = new System.Drawing.Point(-1, 233);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(85, 50);
            this.BtnPercent.TabIndex = 18;
            this.BtnPercent.Text = "%";
            this.BtnPercent.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPercent.UseVisualStyleBackColor = false;
            this.BtnPercent.Click += new System.EventHandler(this.BtnOperations_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCE.BorderRadius = 20;
            this.btnCE.BorderSize = 20;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCE.Location = new System.Drawing.Point(87, 233);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(85, 50);
            this.btnCE.TabIndex = 17;
            this.btnCE.Text = "CE";
            this.btnCE.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnC.BorderRadius = 20;
            this.BtnC.BorderSize = 20;
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnC.Location = new System.Drawing.Point(175, 233);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(85, 50);
            this.BtnC.TabIndex = 16;
            this.BtnC.Text = "C";
            this.BtnC.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnBackSpace.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnBackSpace.BorderRadius = 20;
            this.BtnBackSpace.BorderSize = 20;
            this.BtnBackSpace.FlatAppearance.BorderSize = 0;
            this.BtnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackSpace.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackSpace.Image")));
            this.BtnBackSpace.Location = new System.Drawing.Point(263, 233);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(85, 50);
            this.BtnBackSpace.TabIndex = 15;
            this.BtnBackSpace.TextColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBackSpace.UseVisualStyleBackColor = false;
            this.BtnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // artanButton6
            // 
            this.artanButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton6.BorderRadius = 30;
            this.artanButton6.BorderSize = 30;
            this.artanButton6.FlatAppearance.BorderSize = 0;
            this.artanButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton6.ForeColor = System.Drawing.Color.DarkGray;
            this.artanButton6.Location = new System.Drawing.Point(0, 184);
            this.artanButton6.Name = "artanButton6";
            this.artanButton6.Size = new System.Drawing.Size(57, 30);
            this.artanButton6.TabIndex = 14;
            this.artanButton6.TabStop = false;
            this.artanButton6.Text = "MC";
            this.artanButton6.TextColor = System.Drawing.Color.DarkGray;
            this.artanButton6.UseVisualStyleBackColor = false;
            // 
            // artanButton5
            // 
            this.artanButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton5.BorderRadius = 30;
            this.artanButton5.BorderSize = 30;
            this.artanButton5.FlatAppearance.BorderSize = 0;
            this.artanButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton5.ForeColor = System.Drawing.Color.DarkGray;
            this.artanButton5.Location = new System.Drawing.Point(59, 184);
            this.artanButton5.Name = "artanButton5";
            this.artanButton5.Size = new System.Drawing.Size(56, 30);
            this.artanButton5.TabIndex = 13;
            this.artanButton5.TabStop = false;
            this.artanButton5.Text = "MR";
            this.artanButton5.TextColor = System.Drawing.Color.DarkGray;
            this.artanButton5.UseVisualStyleBackColor = false;
            // 
            // artanButton4
            // 
            this.artanButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton4.BorderRadius = 30;
            this.artanButton4.BorderSize = 30;
            this.artanButton4.FlatAppearance.BorderSize = 0;
            this.artanButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton4.ForeColor = System.Drawing.Color.DarkGray;
            this.artanButton4.Location = new System.Drawing.Point(117, 184);
            this.artanButton4.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton4.Name = "artanButton4";
            this.artanButton4.Size = new System.Drawing.Size(59, 30);
            this.artanButton4.TabIndex = 12;
            this.artanButton4.TabStop = false;
            this.artanButton4.Text = "M+";
            this.artanButton4.TextColor = System.Drawing.Color.DarkGray;
            this.artanButton4.UseVisualStyleBackColor = false;
            // 
            // artanButton3
            // 
            this.artanButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton3.BorderRadius = 30;
            this.artanButton3.BorderSize = 30;
            this.artanButton3.FlatAppearance.BorderSize = 0;
            this.artanButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton3.ForeColor = System.Drawing.Color.DarkGray;
            this.artanButton3.Location = new System.Drawing.Point(177, 184);
            this.artanButton3.Name = "artanButton3";
            this.artanButton3.Size = new System.Drawing.Size(58, 30);
            this.artanButton3.TabIndex = 11;
            this.artanButton3.TabStop = false;
            this.artanButton3.Text = "M-";
            this.artanButton3.TextColor = System.Drawing.Color.DarkGray;
            this.artanButton3.UseVisualStyleBackColor = false;
            // 
            // artanButton2
            // 
            this.artanButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton2.BorderRadius = 30;
            this.artanButton2.BorderSize = 30;
            this.artanButton2.FlatAppearance.BorderSize = 0;
            this.artanButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton2.ForeColor = System.Drawing.Color.DarkGray;
            this.artanButton2.Location = new System.Drawing.Point(235, 184);
            this.artanButton2.Name = "artanButton2";
            this.artanButton2.Size = new System.Drawing.Size(61, 30);
            this.artanButton2.TabIndex = 10;
            this.artanButton2.TabStop = false;
            this.artanButton2.Text = "MS";
            this.artanButton2.TextColor = System.Drawing.Color.DarkGray;
            this.artanButton2.UseVisualStyleBackColor = false;
            // 
            // artanButton1
            // 
            this.artanButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.artanButton1.BorderRadius = 30;
            this.artanButton1.BorderSize = 30;
            this.artanButton1.FlatAppearance.BorderSize = 0;
            this.artanButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artanButton1.ForeColor = System.Drawing.Color.DarkGray;
            this.artanButton1.Location = new System.Drawing.Point(296, 184);
            this.artanButton1.Margin = new System.Windows.Forms.Padding(0);
            this.artanButton1.Name = "artanButton1";
            this.artanButton1.Size = new System.Drawing.Size(50, 30);
            this.artanButton1.TabIndex = 9;
            this.artanButton1.TabStop = false;
            this.artanButton1.Text = "M";
            this.artanButton1.TextColor = System.Drawing.Color.DarkGray;
            this.artanButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 570);
            this.Controls.Add(this.PnlHostory);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDeals);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.BtnSubstraction);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.Btn1x);
            this.Controls.Add(this.Btnx2);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.BtnDevision);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnBackSpace);
            this.Controls.Add(this.artanButton6);
            this.Controls.Add(this.artanButton5);
            this.Controls.Add(this.artanButton4);
            this.Controls.Add(this.artanButton3);
            this.Controls.Add(this.artanButton2);
            this.Controls.Add(this.artanButton1);
            this.Controls.Add(this.TxtDisplay1);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlTitle);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.PnlTitle.ResumeLayout(false);
            this.PnlHostory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDisplay1;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnExit;
        private ArtanButton.ArtanButton artanButton1;
        private ArtanButton.ArtanButton artanButton2;
        private ArtanButton.ArtanButton artanButton3;
        private ArtanButton.ArtanButton artanButton4;
        private ArtanButton.ArtanButton artanButton5;
        private ArtanButton.ArtanButton artanButton6;
        private ArtanButton.ArtanButton BtnBackSpace;
        private ArtanButton.ArtanButton BtnC;
        private ArtanButton.ArtanButton btnCE;
        private ArtanButton.ArtanButton BtnPercent;
        private System.Windows.Forms.Panel PnlHostory;
        private System.Windows.Forms.RichTextBox RtBoxDisplayHistory;
        private System.Windows.Forms.Button BtnClearHistory;
        private ArtanButton.ArtanButton Btn1x;
        private ArtanButton.ArtanButton Btnx2;
        private ArtanButton.ArtanButton BtnSquare;
        private ArtanButton.ArtanButton BtnDevision;
        private ArtanButton.ArtanButton btn7;
        private ArtanButton.ArtanButton btn8;
        private ArtanButton.ArtanButton btn9;
        private ArtanButton.ArtanButton BtnMultiply;
        private ArtanButton.ArtanButton btn4;
        private ArtanButton.ArtanButton btn5;
        private ArtanButton.ArtanButton btn6;
        private ArtanButton.ArtanButton BtnSubstraction;
        private ArtanButton.ArtanButton btn1;
        private ArtanButton.ArtanButton btn2;
        private ArtanButton.ArtanButton btn3;
        private ArtanButton.ArtanButton BtnAdd;
        private ArtanButton.ArtanButton btnPM;
        private ArtanButton.ArtanButton btn0;
        private ArtanButton.ArtanButton btnDeals;
        private ArtanButton.ArtanButton BtnEquals;
    }
}

