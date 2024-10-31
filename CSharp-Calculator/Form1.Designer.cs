namespace CSharp_Calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainDisplay = new System.Windows.Forms.TextBox();
            this.summaryDisplay = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.divisionBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.mainDisplay);
            this.panel1.Controls.Add(this.summaryDisplay);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 142);
            this.panel1.TabIndex = 0;
            // 
            // mainDisplay
            // 
            this.mainDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDisplay.Location = new System.Drawing.Point(28, 62);
            this.mainDisplay.Name = "mainDisplay";
            this.mainDisplay.ReadOnly = true;
            this.mainDisplay.Size = new System.Drawing.Size(248, 44);
            this.mainDisplay.TabIndex = 1;
            // 
            // summaryDisplay
            // 
            this.summaryDisplay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.summaryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryDisplay.Location = new System.Drawing.Point(28, 28);
            this.summaryDisplay.Name = "summaryDisplay";
            this.summaryDisplay.ReadOnly = true;
            this.summaryDisplay.Size = new System.Drawing.Size(248, 35);
            this.summaryDisplay.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.divisionBtn);
            this.panel2.Controls.Add(this.equalBtn);
            this.panel2.Controls.Add(this.zeroBtn);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.multiplyBtn);
            this.panel2.Controls.Add(this.nineBtn);
            this.panel2.Controls.Add(this.eightBtn);
            this.panel2.Controls.Add(this.sevenBtn);
            this.panel2.Controls.Add(this.minusBtn);
            this.panel2.Controls.Add(this.sixBtn);
            this.panel2.Controls.Add(this.fiveBtn);
            this.panel2.Controls.Add(this.fourBtn);
            this.panel2.Controls.Add(this.plusBtn);
            this.panel2.Controls.Add(this.threeBtn);
            this.panel2.Controls.Add(this.twoBtn);
            this.panel2.Controls.Add(this.oneBtn);
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 311);
            this.panel2.TabIndex = 1;
            // 
            // divisionBtn
            // 
            this.divisionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionBtn.Location = new System.Drawing.Point(235, 234);
            this.divisionBtn.Name = "divisionBtn";
            this.divisionBtn.Size = new System.Drawing.Size(41, 42);
            this.divisionBtn.TabIndex = 15;
            this.divisionBtn.Text = "÷";
            this.divisionBtn.UseVisualStyleBackColor = true;
            this.divisionBtn.Click += new System.EventHandler(this.divisionBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.Location = new System.Drawing.Point(166, 234);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(41, 42);
            this.equalBtn.TabIndex = 14;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBtn.Location = new System.Drawing.Point(97, 234);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(41, 42);
            this.zeroBtn.TabIndex = 13;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(28, 234);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(41, 42);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBtn.Location = new System.Drawing.Point(235, 170);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(41, 42);
            this.multiplyBtn.TabIndex = 11;
            this.multiplyBtn.Text = "x";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineBtn.Location = new System.Drawing.Point(166, 170);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(41, 42);
            this.nineBtn.TabIndex = 10;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBtn.Location = new System.Drawing.Point(97, 170);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(41, 42);
            this.eightBtn.TabIndex = 9;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenBtn.Location = new System.Drawing.Point(28, 170);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(41, 42);
            this.sevenBtn.TabIndex = 8;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.Location = new System.Drawing.Point(235, 104);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(41, 42);
            this.minusBtn.TabIndex = 7;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixBtn.Location = new System.Drawing.Point(166, 104);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(41, 42);
            this.sixBtn.TabIndex = 6;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveBtn.Location = new System.Drawing.Point(97, 104);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(41, 42);
            this.fiveBtn.TabIndex = 5;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.Location = new System.Drawing.Point(28, 104);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(41, 42);
            this.fourBtn.TabIndex = 4;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(235, 39);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(41, 42);
            this.plusBtn.TabIndex = 3;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.Location = new System.Drawing.Point(166, 39);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(41, 42);
            this.threeBtn.TabIndex = 2;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.Location = new System.Drawing.Point(97, 39);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(41, 42);
            this.twoBtn.TabIndex = 1;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.Location = new System.Drawing.Point(28, 39);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(41, 42);
            this.oneBtn.TabIndex = 0;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "CSharp-Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox summaryDisplay;
        private System.Windows.Forms.TextBox mainDisplay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button divisionBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button oneBtn;
    }
}

