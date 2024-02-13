namespace Lab1
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
            text = new TextBox();
            number_7 = new Button();
            number_8 = new Button();
            number_9 = new Button();
            number_6 = new Button();
            number_5 = new Button();
            number_4 = new Button();
            number_3 = new Button();
            number_2 = new Button();
            number_1 = new Button();
            ctn = new Button();
            tan = new Button();
            cos = new Button();
            sin = new Button();
            memory_get = new Button();
            pow = new Button();
            cube_root = new Button();
            square_root = new Button();
            memory_add = new Button();
            memory_clear = new Button();
            clear = new Button();
            equal = new Button();
            number_0 = new Button();
            clear_current = new Button();
            not = new Button();
            SuspendLayout();
            // 
            // text
            // 
            text.Font = new Font("Segoe UI", 16F);
            text.Location = new Point(257, 109);
            text.MaxLength = 12;
            text.Name = "text";
            text.ReadOnly = true;
            text.RightToLeft = RightToLeft.No;
            text.Size = new Size(273, 43);
            text.TabIndex = 1;
            text.Text = "0";
            text.TextAlign = HorizontalAlignment.Right;
            // 
            // number_7
            // 
            number_7.Font = new Font("Segoe UI", 16F);
            number_7.Location = new Point(260, 167);
            number_7.Name = "number_7";
            number_7.Size = new Size(70, 70);
            number_7.TabIndex = 5;
            number_7.Text = "7";
            number_7.UseVisualStyleBackColor = true;
            number_7.Click += NumberClick;
            // 
            // number_8
            // 
            number_8.Font = new Font("Segoe UI", 16F);
            number_8.Location = new Point(360, 167);
            number_8.Name = "number_8";
            number_8.Size = new Size(70, 70);
            number_8.TabIndex = 6;
            number_8.Text = "8";
            number_8.UseVisualStyleBackColor = true;
            number_8.Click += NumberClick;
            // 
            // number_9
            // 
            number_9.Font = new Font("Segoe UI", 16F);
            number_9.Location = new Point(460, 167);
            number_9.Name = "number_9";
            number_9.Size = new Size(70, 70);
            number_9.TabIndex = 7;
            number_9.Text = "9";
            number_9.UseVisualStyleBackColor = true;
            number_9.Click += NumberClick;
            // 
            // number_6
            // 
            number_6.Font = new Font("Segoe UI", 16F);
            number_6.Location = new Point(460, 259);
            number_6.Name = "number_6";
            number_6.Size = new Size(70, 70);
            number_6.TabIndex = 10;
            number_6.Text = "6";
            number_6.UseVisualStyleBackColor = true;
            number_6.Click += NumberClick;
            // 
            // number_5
            // 
            number_5.Font = new Font("Segoe UI", 16F);
            number_5.Location = new Point(360, 259);
            number_5.Name = "number_5";
            number_5.Size = new Size(70, 70);
            number_5.TabIndex = 9;
            number_5.Text = "5";
            number_5.UseVisualStyleBackColor = true;
            number_5.Click += NumberClick;
            // 
            // number_4
            // 
            number_4.Font = new Font("Segoe UI", 16F);
            number_4.Location = new Point(260, 259);
            number_4.Name = "number_4";
            number_4.Size = new Size(70, 70);
            number_4.TabIndex = 8;
            number_4.Text = "4";
            number_4.UseVisualStyleBackColor = true;
            number_4.Click += NumberClick;
            // 
            // number_3
            // 
            number_3.Font = new Font("Segoe UI", 16F);
            number_3.Location = new Point(460, 351);
            number_3.Name = "number_3";
            number_3.Size = new Size(70, 70);
            number_3.TabIndex = 13;
            number_3.Text = "3";
            number_3.UseVisualStyleBackColor = true;
            number_3.Click += NumberClick;
            // 
            // number_2
            // 
            number_2.Font = new Font("Segoe UI", 16F);
            number_2.Location = new Point(360, 351);
            number_2.Name = "number_2";
            number_2.Size = new Size(70, 70);
            number_2.TabIndex = 12;
            number_2.Text = "2";
            number_2.UseVisualStyleBackColor = true;
            number_2.Click += NumberClick;
            // 
            // number_1
            // 
            number_1.Font = new Font("Segoe UI", 16F);
            number_1.Location = new Point(260, 351);
            number_1.Name = "number_1";
            number_1.Size = new Size(70, 70);
            number_1.TabIndex = 11;
            number_1.Text = "1";
            number_1.UseVisualStyleBackColor = true;
            number_1.Click += NumberClick;
            // 
            // ctn
            // 
            ctn.Font = new Font("Segoe UI", 16F);
            ctn.Location = new Point(147, 259);
            ctn.Name = "ctn";
            ctn.Size = new Size(70, 70);
            ctn.TabIndex = 17;
            ctn.Text = "ctn";
            ctn.UseVisualStyleBackColor = true;
            ctn.Click += CtnClick;
            // 
            // tan
            // 
            tan.Font = new Font("Segoe UI", 16F);
            tan.Location = new Point(47, 259);
            tan.Name = "tan";
            tan.Size = new Size(70, 70);
            tan.TabIndex = 16;
            tan.Text = "tan";
            tan.UseVisualStyleBackColor = true;
            tan.Click += TanClick;
            // 
            // cos
            // 
            cos.Font = new Font("Segoe UI", 16F);
            cos.Location = new Point(147, 167);
            cos.Name = "cos";
            cos.Size = new Size(70, 70);
            cos.TabIndex = 15;
            cos.Text = "cos";
            cos.UseVisualStyleBackColor = true;
            cos.Click += CosClick;
            // 
            // sin
            // 
            sin.Font = new Font("Segoe UI", 16F);
            sin.Location = new Point(47, 167);
            sin.Name = "sin";
            sin.Size = new Size(70, 70);
            sin.TabIndex = 14;
            sin.Text = "sin";
            sin.UseVisualStyleBackColor = true;
            sin.Click += SinClick;
            // 
            // memory_get
            // 
            memory_get.Font = new Font("Segoe UI", 16F);
            memory_get.Location = new Point(460, 472);
            memory_get.Name = "memory_get";
            memory_get.Size = new Size(70, 70);
            memory_get.TabIndex = 21;
            memory_get.Text = "-M";
            memory_get.UseVisualStyleBackColor = true;
            memory_get.Click += MemoryGetClick;
            // 
            // pow
            // 
            pow.Font = new Font("Segoe UI", 16F);
            pow.Location = new Point(582, 351);
            pow.Name = "pow";
            pow.Size = new Size(70, 70);
            pow.TabIndex = 20;
            pow.Text = "^";
            pow.UseVisualStyleBackColor = true;
            pow.Click += PowClick;
            // 
            // cube_root
            // 
            cube_root.Font = new Font("Segoe UI", 16F);
            cube_root.Location = new Point(582, 167);
            cube_root.Name = "cube_root";
            cube_root.Size = new Size(70, 70);
            cube_root.TabIndex = 19;
            cube_root.Text = "crt";
            cube_root.UseVisualStyleBackColor = true;
            cube_root.Click += CubeRootClick;
            // 
            // square_root
            // 
            square_root.Font = new Font("Segoe UI", 16F);
            square_root.Location = new Point(582, 259);
            square_root.Name = "square_root";
            square_root.Size = new Size(70, 70);
            square_root.TabIndex = 18;
            square_root.Text = "sqrt";
            square_root.UseVisualStyleBackColor = true;
            square_root.Click += SquareRootClick;
            // 
            // memory_add
            // 
            memory_add.Font = new Font("Segoe UI", 16F);
            memory_add.Location = new Point(360, 472);
            memory_add.Name = "memory_add";
            memory_add.Size = new Size(70, 70);
            memory_add.TabIndex = 22;
            memory_add.Text = "+M";
            memory_add.UseVisualStyleBackColor = true;
            memory_add.Click += MemoryAddClick;
            // 
            // memory_clear
            // 
            memory_clear.Font = new Font("Segoe UI", 16F);
            memory_clear.Location = new Point(260, 472);
            memory_clear.Name = "memory_clear";
            memory_clear.Size = new Size(70, 70);
            memory_clear.TabIndex = 23;
            memory_clear.Text = "MC";
            memory_clear.UseVisualStyleBackColor = true;
            memory_clear.Click += MemoryClearClick;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI", 16F);
            clear.Location = new Point(147, 472);
            clear.Name = "clear";
            clear.Size = new Size(70, 70);
            clear.TabIndex = 24;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += ClearClick;
            // 
            // equal
            // 
            equal.Font = new Font("Segoe UI", 16F);
            equal.Location = new Point(582, 472);
            equal.Name = "equal";
            equal.Size = new Size(70, 70);
            equal.TabIndex = 25;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += EqualClick;
            // 
            // number_0
            // 
            number_0.Font = new Font("Segoe UI", 16F);
            number_0.Location = new Point(147, 351);
            number_0.Name = "number_0";
            number_0.Size = new Size(70, 70);
            number_0.TabIndex = 26;
            number_0.Text = "0";
            number_0.UseVisualStyleBackColor = true;
            number_0.Click += NumberClick;
            // 
            // clear_current
            // 
            clear_current.Font = new Font("Segoe UI", 16F);
            clear_current.Location = new Point(47, 472);
            clear_current.Name = "clear_current";
            clear_current.Size = new Size(70, 70);
            clear_current.TabIndex = 27;
            clear_current.Text = "CE";
            clear_current.UseVisualStyleBackColor = true;
            clear_current.Click += ClearCurrentClick;
            // 
            // not
            // 
            not.Font = new Font("Segoe UI", 16F);
            not.Location = new Point(47, 351);
            not.Name = "not";
            not.Size = new Size(70, 70);
            not.TabIndex = 28;
            not.Text = "~";
            not.UseVisualStyleBackColor = true;
            not.Click += NotClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 580);
            Controls.Add(not);
            Controls.Add(clear_current);
            Controls.Add(number_0);
            Controls.Add(equal);
            Controls.Add(clear);
            Controls.Add(memory_clear);
            Controls.Add(memory_add);
            Controls.Add(memory_get);
            Controls.Add(pow);
            Controls.Add(cube_root);
            Controls.Add(square_root);
            Controls.Add(ctn);
            Controls.Add(tan);
            Controls.Add(cos);
            Controls.Add(sin);
            Controls.Add(number_3);
            Controls.Add(number_2);
            Controls.Add(number_1);
            Controls.Add(number_6);
            Controls.Add(number_5);
            Controls.Add(number_4);
            Controls.Add(number_9);
            Controls.Add(number_8);
            Controls.Add(number_7);
            Controls.Add(text);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox text;
        private Button number_7;
        private Button number_8;
        private Button number_9;
        private Button number_6;
        private Button number_5;
        private Button number_4;
        private Button number_3;
        private Button number_2;
        private Button number_1;
        private Button ctn;
        private Button tan;
        private Button cos;
        private Button sin;
        private Button memory_get;
        private Button pow;
        private Button cube_root;
        private Button square_root;
        private Button memory_add;
        private Button memory_clear;
        private Button clear;
        private Button equal;
        private Button number_0;
        private Button clear_current;
        private Button not;
    }
}
